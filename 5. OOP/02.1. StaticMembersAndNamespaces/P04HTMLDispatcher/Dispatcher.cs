namespace P04HTMLDispatcher
{
    using System;

    public class Dispatcher
    {
        public static void Main()
        {
            ElementBuilder a = new ElementBuilder("a");
            a.AddAttribute("href", "#");
            a.AddAttribute("class", "link");
            a.AddContent("abv.bg");
            Console.WriteLine(a);
            Console.WriteLine(a * 2);
            Console.WriteLine();

            ElementBuilder img = HTMLDispatcher.CreateImage("image1.jpg", "test image", "test image");
            Console.WriteLine(img.ToString());
            ElementBuilder input = HTMLDispatcher.CreateInput("submit", "submit", "Submit");
            Console.WriteLine(input.ToString());
        }
    }
}
