using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Inhouse : Part
    {
        public string MachineId { get; set; }

        public Inhouse(int partid, string name, double price, int inStock, int min, int max, string machineId) : 
            base(partid, name, price, inStock, min, max)
        {
            MachineId = machineId;
        }

        public override string ToString()
        {
            return string.Format($"{this.GetType()},{base.ToString()},{MachineId}");
        }

    }
}
