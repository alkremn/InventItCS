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

        private BindingList<Part> parts = new BindingList<Part>();

        private BindingList<Product> products = new BindingList<Product>();

        public BindingList<Part> Parts { get { return parts; }}

        public BindingList<Product> Products { get { return products; }}

        private static int _partId = 0;

        private static int _productId = 0;


        public void RemovePartByIndex(int id)
        {
            Part partToRemove = FindPartById(id);

            if (partToRemove != null)
                Parts.Remove(partToRemove);
        }

        public int GetNewPartId
        {
            get
            {
                return ++_partId;
            }
        }

        public int GetNewProductId
        {
            get
            {
                return ++_productId;
            }
        }

        public bool AddPart(Part part)
        {
            if (part != null)
            {
                Part existingPart = FindPartById(part.PartId);

                if (existingPart == null)
                {
                    _partId++;
                    parts.Add(part);
                    return true;
                }
                else
                {
                    RemovePartByIndex(part.PartId);
                    parts.Add(part);
                    parts = SortParts(parts);
                    return true;
                }
            }
            return false;
        }

        public bool AddParts(BindingList<Part> parts)
        {
            if (parts != null && parts.Count != 0)
            {
                foreach (var part in parts)
                {
                    AddPart(part);
                }
                return true;
            }
            return false;
        }

        public bool AddProduct(Product product)
        {
            if (product != null)
            {
                Product existingProduct = FindProductById(product.ProductId);
                if (existingProduct == null)
                {
                    products.Add(product);
                    return true;
                }
                else
                {
                    products.Remove(product);
                    products.Add(product);
                    return true;
                }
            }
            return false;
        }

        public bool AddProducts(BindingList<Product> products)
        {
            if (products != null && products.Count != 0)
            {
                foreach (var product in products)
                {
                    AddProduct(product);
                }
                return true;
            }
            return false;
        }

       

        public void RemoveProductByIndex(int id)
        {
            Product productToRemove = FindProductById(id);
            if (productToRemove != null)
                Products.Remove(productToRemove);
        }

        public Part FindPartById(int id)
        {
            var partById = from part in parts where part.PartId == id select part;

            if (partById.Any())
            {
                return partById.First();
            }
            return null;
        }

        public Product FindProductById(int id)
        {
            var productById = from product in products where product.ProductId == id select product;

            if(productById.Any())
            {
                return productById.First();
            }
            return null;
        }

        private BindingList<Part> SortParts(BindingList<Part> partsToSort)
        {
            List<Part> parts = new List<Part>(partsToSort);
            parts.Sort((first, second) => first.PartId.CompareTo(second.PartId));

            return new BindingList<Part>(parts);
        }

    }
}
