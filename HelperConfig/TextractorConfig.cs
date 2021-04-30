using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperConfig {
    public class TextractorConfig {
        public string Path { get; set; }

        public TextractorConfig() {
            Path = @".\Data\Textractor";
        }
    }
}
