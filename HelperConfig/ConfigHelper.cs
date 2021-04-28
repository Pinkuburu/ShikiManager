using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Unicode;
using System.Text.Encodings.Web;

namespace HelperConfig {
    public class ConfigHelper {
        // Const
        private const string dataPathConst = @".\Data";
        private const string configPathConst = @".\Data\Config.json";

        // Readonly
        private static readonly string appBasePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        private static readonly string configPath = Path.Combine(appBasePath, configPathConst);
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };

        // Value
        private static TotalConfig config;

        /// <summary>
        /// Config instance.
        /// </summary>
        public static TotalConfig Config { get => config;}
        
        /// <summary>
        /// This is a static class.
        /// </summary>
        private ConfigHelper() { }

        /// <summary>
        /// Read config from local.
        /// </summary>
        public static void ReadConfig() {
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
        public static void WriteConfig() {
            Directory.CreateDirectory(dataPathConst);
            string jsonString = JsonSerializer.Serialize<TotalConfig>(config, jsonSerializerOptions);
            File.WriteAllText(configPath, jsonString);
        }
    }
}
