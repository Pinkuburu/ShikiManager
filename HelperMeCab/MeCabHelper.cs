using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMeCab;
using NMeCab.Core;
using NMeCab.Specialized;

namespace HelperMeCab {
    public class MeCabHelper {
        private static MeCabIpaDicTagger ipaDicTagger = null;
        private static MeCabUniDic22Tagger uniDicTagger = null;

        private MeCabHelper() { }

        public static MeCabIpaDicTagger GetIpaDicTagger(string dicDir, string[] userDirDics = null) {
            if (uniDicTagger != null) { uniDicTagger.Dispose(); }
            if (ipaDicTagger == null) { ipaDicTagger = MeCabIpaDicTagger.Create(dicDir, userDirDics); }
            return ipaDicTagger;
        }

        public static MeCabUniDic22Tagger GetUniDicTagger(string dicDir, string[] userDirDics = null) {
            if (ipaDicTagger != null) { ipaDicTagger.Dispose(); }
            if (uniDicTagger == null) { uniDicTagger = MeCabUniDic22Tagger.Create(dicDir, userDirDics); }
            return uniDicTagger;
        }
    }
}
