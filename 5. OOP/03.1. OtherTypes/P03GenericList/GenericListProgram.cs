namespace P03GenericList
{
    using System;

    public class GenericListProgram
    {
        public static void Main()
        {
            GenericList<int> list = new GenericList<int>(2);
            list.Add(1);
            list.Add(2);
            list.Add(69);
            list.Add(97);
            list.Add(64);
            list.Add(28);
            list.Add(67);
            list.Add(123);

            Console.WriteLine("List: " + list);
            Console.WriteLine("List[6]: " + list[6]);
            Console.WriteLine("Index of 67: " + list.IndexOf(67));
            Console.WriteLine();

            list.RemoveAt(6);
            Console.WriteLine("List: " + list);
            Console.WriteLine("List[6]: " + list[6]);
            Console.WriteLine("Index of 67: " + list.IndexOf(67));
            Console.WriteLine();

            list.InsertAt(5, 72);
            Console.WriteLine("List: " + list);
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine();
            Console.WriteLine("Max: " + list.Max());
            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine();

            var attr = typeof(GenericList<>).GetCustomAttributes(typeof(Version), false);
            Console.WriteLine("Version: " + attr[0]);
        }
    }
}
