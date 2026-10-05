using System.IO;

namespace inspection_log_viewer
{
    public static class DbConfig
    {
        public static string ConnectionString
        {
            get
            {
                string dbPath = Path.Combine(AppContext.BaseDirectory, "inspection_system.db");
                string configPath = Path.Combine(AppContext.BaseDirectory, "dbpath.txt");
                if (File.Exists(configPath))
                {
                    dbPath = File.ReadAllText(configPath).Trim();
                }
                return $"Data Source={dbPath}";
            }
        }
    }
}
