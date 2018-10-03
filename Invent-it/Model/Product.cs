using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Product
    {

        public List<Part> AssociatedParts { get; set; } = new List<Part>();

        private int _productId;

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }


        public Product(int productId, string partName, double price, int inStock, int min, int max)
        {
            ProductId = productId;
            ProductName = partName;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public int ProductId
        {
            get => _productId;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Invalid ID number");
                }

                _productId = value;
            }
        }
    }
}
