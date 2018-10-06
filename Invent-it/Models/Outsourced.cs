using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partId, string name, double price, int inStock, int min, int max, string companyName):
            base(partId, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        public override string ToString()
        {
            return string.Format($"{this.GetType()},{base.ToString()},{CompanyName}");
        }

    }
}
