using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class SimpleDataLoader
    {

        public static List<Part> GetSimpleParts()
        {
            return new List<Part>
            {
                new Inhouse(1, "Wheel", 1.99, 5, 1, 4, 12345),
                new Inhouse(2, "Tire", 2.99, 10, 4, 10, 524345),
                new Outsourced(3, "WindShield", 15.99, 40, 2, 8, "Wind Blow Inc."),
                new Outsourced(4, "Door", 10.99, 25, 3, 12, "Doors Co."),
            };
        }
        public static List<Product> GetSimpleProducts()
        {
            return new List<Product>()
            {
                new Product(1, "Boat", 14000, 5, 2, 10),
                new Product(2, "Plane", 100_000, 4, 1, 3),
                new Product(3, "Car", 20000, 9, 1, 5),
                new Product(4, "Bike", 500, 3, 1, 8)
            };
        }

    }
}
