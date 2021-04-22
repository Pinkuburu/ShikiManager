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
        private const string dataPathConst = @".\data";
        private const string configPathConst = @".\data\config.json";

        // Readonly
        private static readonly string appBasePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        private static readonly string configPath = Path.Combine(appBasePath, configPathConst);
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };

        // Value
        public static TotalConfig config;

        private ConfigHelper() { }

        public static async void ReadConfigAsync() {
            if (File.Exists(configPath)) {
                using (FileStream readStream = new FileStream(configPath, FileMode.Create, FileAccess.Read, FileShare.Read)) {
                    config = await JsonSerializer.DeserializeAsync<TotalConfig>(readStream, jsonSerializerOptions);
                }
                return;
            } else {
                //instance = new ConfigHelper();
                // TODO
            }
        }

        public static async void WriteConfigAsync() {
            using (FileStream writeStream = new FileStream(configPath, FileMode.Create, FileAccess.Write)) {
                await JsonSerializer.SerializeAsync<TotalConfig>(writeStream, config, jsonSerializerOptions);
            }
        }
    }
}
