namespace ExpressProfiler
{
    partial class RecentConnectionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.integratedSecurityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvConnections
            // 
            this.dgvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConnections.AutoGenerateColumns = false;
            this.dgvConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataSourceDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.catalogDataGridViewTextBoxColumn,
            this.applicationNameDataGridViewTextBoxColumn,
            this.integratedSecurityDataGridViewTextBoxColumn});
            this.dgvConnections.DataSource = this.connectionBindingSource;
            this.dgvConnections.Location = new System.Drawing.Point(13, 86);
            this.dgvConnections.MultiSelect = false;
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.ReadOnly = true;
            this.dgvConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnections.Size = new System.Drawing.Size(759, 264);
            this.dgvConnections.TabIndex = 2;
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(ExpressProfiler.Connection);
            // 
            // dataSourceDataGridViewTextBoxColumn
            // 
            this.dataSourceDataGridViewTextBoxColumn.DataPropertyName = "DataSource";
            this.dataSourceDataGridViewTextBoxColumn.HeaderText = "Server";
            this.dataSourceDataGridViewTextBoxColumn.Name = "dataSourceDataGridViewTextBoxColumn";
            this.dataSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataSourceDataGridViewTextBoxColumn.Width = 63;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "User";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 54;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 78;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "Creation Date";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationDateDataGridViewTextBoxColumn.Width = 97;
            // 
            // catalogDataGridViewTextBoxColumn
            // 
            this.catalogDataGridViewTextBoxColumn.DataPropertyName = "Catalog";
            this.catalogDataGridViewTextBoxColumn.HeaderText = "Catalog";
            this.catalogDataGridViewTextBoxColumn.Name = "catalogDataGridViewTextBoxColumn";
            this.catalogDataGridViewTextBoxColumn.ReadOnly = true;
            this.catalogDataGridViewTextBoxColumn.Visible = false;
            this.catalogDataGridViewTextBoxColumn.Width = 68;
            // 
            // applicationNameDataGridViewTextBoxColumn
            // 
            this.applicationNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.HeaderText = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.Name = "applicationNameDataGridViewTextBoxColumn";
            this.applicationNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationNameDataGridViewTextBoxColumn.Visible = false;
            this.applicationNameDataGridViewTextBoxColumn.Width = 112;
            // 
            // integratedSecurityDataGridViewTextBoxColumn
            // 
            this.integratedSecurityDataGridViewTextBoxColumn.DataPropertyName = "IntegratedSecurity";
            this.integratedSecurityDataGridViewTextBoxColumn.HeaderText = "IntegratedSecurity";
            this.integratedSecurityDataGridViewTextBoxColumn.Name = "integratedSecurityDataGridViewTextBoxColumn";
            this.integratedSecurityDataGridViewTextBoxColumn.ReadOnly = true;
            this.integratedSecurityDataGridViewTextBoxColumn.Visible = false;
            this.integratedSecurityDataGridViewTextBoxColumn.Width = 118;
            // 
            // RecentConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.dgvConnections);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RecentConnectionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recent Database Connections";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvConnections;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn integratedSecurityDataGridViewTextBoxColumn;
    }
}