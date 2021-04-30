using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperConfig {
    public class NtleasConfig {
        public string Path { get; set; }

        public NtleasConfig() {
            Path = @".\Data\Ntleas";
        }
    }
}
