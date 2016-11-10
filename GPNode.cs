using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rybocompleks.GUI
{
    public class GPNode
    {
        public string stageName { get; set; }
        public int houres { get; set; }
        public int minutes { get; set; }
        public int temperature { get; set; }
        public int oxygen { get; set; }
        public int LightPerDay { get; set; }
        public int pH { get; set; }
    }
}
