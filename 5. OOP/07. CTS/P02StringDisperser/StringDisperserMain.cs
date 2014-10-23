namespace P02StringDisperser
{
    using System;

    public class StringDisperserMain
    {
        public static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            StringDisperser st = new StringDisperser("gosho", "pesha", "tanio");

            Console.WriteLine(st.ToString());
        }
    }
}
