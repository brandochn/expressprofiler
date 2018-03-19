using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;

namespace ExpressProfiler
{
    [XmlRoot(ElementName = "Connection")]
    public class Connection
    {
        [XmlElement(ElementName = "ApplicationName")]
        public string ApplicationName { get; set; }
        [XmlElement(ElementName = "Catalog")]
        public string Catalog { get; set; }
        [XmlElement(ElementName = "CreationDate")]
        public string CreationDate { get; set; }
        [XmlElement(ElementName = "DataSource")]
        public string DataSource { get; set; }
        [XmlElement(ElementName = "IntegratedSecurity")]
        public string IntegratedSecurity { get; set; }
        [XmlElement(ElementName = "Password")]
        public string Password { get; set; }
        [XmlElement(ElementName = "UserId")]
        public string UserId { get; set; }        
    }

    [XmlRoot(ElementName = "RecentConnection")]
    public class RecentConnection
    {
        [XmlElement(ElementName = "Connections")]
        public List<Connection> Connections { get; set; }

        public void Add(Connection connection)
        {
            if (Connections == null)
                return;
            if (connection == null)
                return;

            if (Connections.Any(c => c.DataSource == connection.DataSource && c.UserId == connection.UserId))
            {
                foreach (var c in Connections)
                {
                    if (c.DataSource == connection.DataSource &&
                        c.UserId == connection.UserId)
                    {
                        c.Password = connection.Password;
                    }
                }
            }
            else
            {
                Connections.Add(connection);
            }
        }
    }
}
