﻿using System;

namespace Model
{
    public abstract class Part
    {

        private int _partid;

        public string PartName { get; private set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        protected Part(int partid, string partName, double price, int inStock, int min, int max)
        {
            PartId = partid;
            PartName = partName;
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
