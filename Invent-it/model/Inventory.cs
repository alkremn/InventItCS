using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Model
{
    public class Inventory
    {
        public BindingList<Part> Parts { get; set; } = new BindingList<Part>();

        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        
        

        public void RemovePartByIndex(int id)
        {
            if (id < 0 || id > Parts.Count)
                throw new ArgumentException();

            Part partToRemove = FindPartById(id);

            if (partToRemove != null)
                Parts.Remove(partToRemove);
        }

        public void RemoveProductByIndex(int id)
        {
            if (id < 0 || id > Products.Count)
                throw new ArgumentException();

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
