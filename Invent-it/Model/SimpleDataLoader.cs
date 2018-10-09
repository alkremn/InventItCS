using System;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    class SimpleDataLoader
    {
        public static List<Part> ReadSimplePartsFromCSV()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string filePath = Path.Combine(directory.FullName, "SamplePartsData.csv");
            List<Part> parts = new List<Part>();

            string line;
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        var parseValues = GetValues(values);

                        if (values[0].Equals("Model.InHouse"))
                        {
                            parts.Add(new Inhouse(parseValues.Item1, values[2], parseValues.Item2, parseValues.Item3,
                                parseValues.Item4, parseValues.Item5, int.Parse(values[7])));
                        }
                        else
                        {
                            parts.Add(new Outsourced(parseValues.Item1, values[2], parseValues.Item2, parseValues.Item3,
                                parseValues.Item4, parseValues.Item5, values[7]));
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Cannot find {e.FileName} to load!");
            }
            return parts;
        }

        private static Tuple<int, double, int, int, int> GetValues(string[] values)
        {
            int.TryParse(values[1], out int id);
            double.TryParse(values[3], out double price);
            int.TryParse(values[4], out int inStock);
            int.TryParse(values[5], out int min);
            int.TryParse(values[6], out int max);

            return Tuple(id, price, inStock, min, max);
        }

        public static List<Product> ReadSimpleProductsFromCSV()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string filePath = Path.Combine(directory.FullName, "SampleProductsData.csv");

            List<Product> parts = new List<Product>();
            string line;
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        var parseValues = GetValues(values);

                        parts.Add(new Product(parseValues.Item1, values[2], parseValues.Item2, parseValues.Item3,
                                parseValues.Item4, parseValues.Item5));
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Cannot find {e.FileName} to load!");
            }
            return parts;
        }

        private static Tuple<int, double, int, int, int> Tuple(int id, double price, int inStock, int min, int max)
        {
            return new Tuple<int, double, int, int, int>(id, price, inStock, min, max);
        }
    }
}
