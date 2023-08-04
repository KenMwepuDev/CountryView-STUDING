using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMobileAppMaui.Model
{
    public class Country
    {
        public NameInfos name { get; set; }

        public int Population { get; set; }

        public string flagImage { get; set; }
    }

    public class NameInfos
    {
        public string common { get; set; }
        public string official { get; set; }

    }
}
