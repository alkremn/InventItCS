﻿using System;
using System.ComponentModel;

namespace Model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

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
        public override string ToString()
        {
            return string.Format($",{ProductId},{ProductName},{Price},{InStock},{Min},{Max},");
        }
    }
}
