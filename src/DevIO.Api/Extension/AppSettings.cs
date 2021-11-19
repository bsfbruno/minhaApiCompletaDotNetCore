using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Extension
{
    public class AppSettings
    {
        public String Secret {get; set;}
        public int ExpiracaoHoras {get; set;}
        public String Emissor {get; set;}
        public String ValidoEm {get; set;}
    }
}
