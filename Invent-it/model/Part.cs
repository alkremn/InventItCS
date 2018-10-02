using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    abstract class Part
    {

        private int _partid;

        
        public string Name { get; set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }


        protected Part (int partid, string name, double price, int inStock, int min, int max)
        {
            PartId = partid;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public int PartId
        {
            get => _partid;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Invalid ID number");
                }

                _partid = value;
            }
        }


    }
}
