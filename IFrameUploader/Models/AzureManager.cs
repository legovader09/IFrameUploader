using System.Collections.Generic;

namespace IFrameUploader.Models
{
    public class AzureManager
    {
        internal string ConnectionString { get; set; }
        internal string Path { get; set; }
        public AzureManager(string connectionString = "", string path = "")
        {
            ConnectionString = connectionString;
            Path = path;
        }
    }
}
