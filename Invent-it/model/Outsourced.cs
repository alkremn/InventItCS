using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partId, string name, double price, int inStock, int min, int max, string companyName):
            base(partId, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

    }
}
