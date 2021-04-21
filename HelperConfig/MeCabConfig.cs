using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace HelperConfig {
    class MeCabConfig {
        private string dicPath;

        public string DicPath { get => dicPath; set => dicPath = value; }

        public async void ReadConfig() {
            //if (File.Exists()) {

            //}
            //await JsonSerializer.DeserializeAsync<MeCabConfig>();
        }
    }
}
