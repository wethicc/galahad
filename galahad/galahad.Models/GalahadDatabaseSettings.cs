using System;
using System.Collections.Generic;
using System.Text;

namespace galahad.Models
{
    public class GalahadDatabaseSettings : IGalahadDatabaseSettings
    {
        public string UserCollectionName { get; set; }
        public string EventCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IGalahadDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string EventCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
