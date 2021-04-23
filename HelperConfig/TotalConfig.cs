using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperConfig {
    public class TotalConfig {
        public MeCabConfig MeCabConfig { get; set; }
        public TotalConfig() {
            MeCabConfig = new MeCabConfig();
        }
    }
}
