using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Inventory
    {
        public List<Part> Parts { get; set; } = new List<Part>();

        public List<Product> Products { get; set; } = new List<Product>();
        
        

        public void RemovePartByIndex(int id)
        {
            Part partToRemove = FindPartById(id);

            if (partToRemove != null)
                Parts.Remove(partToRemove);
        }

        public void RemoveProductByIndex(int id)
        {
            Product productToRemove = FindProductById(id);
            if (productToRemove != null)
                Products.Remove(productToRemove);
        }

        public Part FindPartById(int id)
        {
            var partById = from part in Parts where part.PartId == id select part;
            return partById.First();
        }

        public Product FindProductById(int id)
        {
            var productById = from product in Products where product.ProductId == id select product;
            return productById.First();
        }

    }
}
