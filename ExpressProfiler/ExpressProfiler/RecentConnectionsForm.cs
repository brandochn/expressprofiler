using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpressProfiler
{
    public partial class RecentConnectionsForm : Form
    {
        private MainForm _mainForm = null;
        private RecentConnection _recentConnection = null;

        private RecentConnectionsForm()
        {
            InitializeComponent();
            ConnectEvents();
        }

        public RecentConnectionsForm(MainForm form) : this()
        {
            _mainForm = form;
            LoadConnections();
        }

        private void LoadConnections()
        {
            _recentConnection = _mainForm.ReadRecentConnections();
            ConvertUTCDateToLocalTime();
            connectionBindingSource.DataSource = _recentConnection?.Connections;
        }

        private void ConvertUTCDateToLocalTime()
        {
            if (_recentConnection?.Connections != null)
            {
                _recentConnection.Connections.ForEach(c => c.CreationDate = string.IsNullOrEmpty(c.CreationDate) ? string.Empty : DateTime.Parse(c.CreationDate).ToLocalTime().ToString());
            }
        }

        private List<Connection> SearchConnection(string searchTerm)
        {
            List<Connection> items = new List<Connection>();

            if (_recentConnection?.Connections != null)
            {
                foreach (var iter in _recentConnection.Connections)
                {
                    if (iter.DataSource.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) != -1 ||
                        iter.UserId.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        items.Add(iter);
                    }
                }
            }
            return items;
        }

        private void ConnectEvents()
        {
            txtSearch.KeyUp += TxtSearch_KeyUp;
            dgvConnections.DoubleClick += DgvConnections_DoubleClick;           
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    return;

                connectionBindingSource.DataSource = SearchConnection(txtSearch.Text);
            }

            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtSearch.Text.Length == 0)
            {
                LoadConnections();
            }
        }

        private void DgvConnections_DoubleClick(object sender, System.EventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null)
            {
                var currentRow = dataGridView.CurrentRow.DataBoundItem as Connection;
                if (currentRow != null)
                {
                    _mainForm.recent_servername = currentRow.DataSource;
                    _mainForm.recent__username = string.IsNullOrEmpty(currentRow.IntegratedSecurity) ? currentRow.UserId : string.Empty;
                    _mainForm.recent_userpassword = string.IsNullOrEmpty(currentRow.IntegratedSecurity) ? Cryptography.Decrypt(currentRow.Password) : string.Empty;
                    _mainForm.recent_auth = string.IsNullOrEmpty(currentRow.IntegratedSecurity) ? 1 : 0;
                    this.Close();
                }
            }
        }
    }
}