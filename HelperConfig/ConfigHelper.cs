using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace HelperConfig {
    public class ConfigHelper {
        // Instance
        private static ConfigHelper instance;

        // Get instance
        public static ConfigHelper Instance { get { if (instance == null) instance = new ConfigHelper(); return instance; } }

        // Const
        private const string dataPathConst = @".\Data";
        private const string configPathConst = @".\Data\Config.json";

        // Readonly
        private readonly string appBasePath;
        private readonly string dataPath;
        private readonly string configPath;
        private readonly JsonSerializerOptions jsonSerializerOptions;

        // Value
        private TotalConfig config;

        // Get Property
        public TotalConfig Config { get => config; }
        public string AppBasePath { get => appBasePath; }
        public string DataPath { get => dataPath; }
        public string ConfigPath { get => configPath; }

        /// <summary>
        /// Constructor.
        /// </summary>
        private ConfigHelper() {
            appBasePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            dataPath = Path.Combine(appBasePath, dataPathConst);
            configPath = Path.Combine(appBasePath, configPathConst);
            jsonSerializerOptions = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
        }

        /// <summary>
        /// Read config from local.
        /// </summary>
        public void ReadConfig() {
            if (File.Exists(configPath)) {
                string jsonString = File.ReadAllText(configPath);
                config = JsonSerializer.Deserialize<TotalConfig>(jsonString, jsonSerializerOptions);
            } else {
                config = new TotalConfig();
            }
        }

        /// <summary>
        /// Write config to local.
        /// </summary>
        public void WriteConfig() {
            Directory.CreateDirectory(dataPath);
            string jsonString = JsonSerializer.Serialize<TotalConfig>(config, jsonSerializerOptions);
            File.WriteAllText(configPath, jsonString);
        }
    }
}
