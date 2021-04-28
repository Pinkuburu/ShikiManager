using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperConfig {
    public class MeCabConfig {
        public string DicPath { get; set; }
        public MeCabDicType DicType { get; set; }

        public MeCabConfig() {
            DicPath = @".\Data\Dic\ipadic-2.7.0-20070801";
            DicType = MeCabDicType.IPADIC;
        }
    }

    public enum MeCabDicType {
        IPADIC,
        UNIDIC
    }
}
