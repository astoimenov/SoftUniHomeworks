using System;

namespace P02LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Battery bat = new Battery("Li-Ion", 4, 2550);
            Laptop first = new Laptop("Lenovo Yoga 2 Pro", 869.88, "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "Lenovo", 8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", bat);
            Laptop second = new Laptop("HP 250 G2", 699.00);

            Console.WriteLine(first.ToString());
            Console.WriteLine();
            Console.WriteLine(second.ToString());
        }
    }
}
