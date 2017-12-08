using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStore.model
{
    public class Order
    {
        public string NomUser { get; set; }
        public string NomCase { get; set; }
        public string NomCpu { get; set; }
        public string NomGpu { get; set; }
        public string NomMotherBoard { get; set; }
        public string NomRam { get; set; }
        public double FinalPrice { get; set; }
    }
}
