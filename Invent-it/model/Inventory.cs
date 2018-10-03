using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Inventory
    {
        private List<Part> _parts;

        private List<Product> _products;

        public List<Part> Parts { get; set; } = new List<Part>();


        public List<Product> Products { get; set; } = new List<Product>();


        public Inventory()
        {
            _parts = new List<Part>();
            _products = new List<Product>();
        }

        public List<Part> GetParts()
        {
            return _parts;
        }

        public void AddParts(List<Part> parts)
        {
            this._parts.AddRange(parts);
        }

    }
}
