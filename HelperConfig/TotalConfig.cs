using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperConfig {
    public class TotalConfig {
        public LocaleEmulatorConfig LocaleEmulatorConfig { get; set; }
        public MeCabConfig MeCabConfig { get; set; }
        public NtleasConfig NtleasConfig { get; set; }
        public TextractorConfig TextractorConfig { get; set; }

        public TotalConfig() {
            LocaleEmulatorConfig = new LocaleEmulatorConfig();
            MeCabConfig = new MeCabConfig();
            NtleasConfig = new NtleasConfig();
            TextractorConfig = new TextractorConfig();
        }
    }
} 
