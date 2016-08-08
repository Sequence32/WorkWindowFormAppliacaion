using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWindowFormAppliacaion
{
   public  class Part
    {
        public string name { get; set; }
        public int partNo { get; set; }
        public double price { get; set; }
        public Part(string name, int partNo, double price)
        {      
            this.name = name;
            this.partNo = partNo;
            this.price = price;
        }
    }
    
}
