namespace P04HTMLDispatcher
{
    using System;

    public static class HTMLDispatcher
    {
        public static ElementBuilder CreateImage(string src, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttribute("src", src);
            img.AddAttribute("alt", alt);
            img.AddAttribute("title", title);
            img.SelfClosing(true);
            return img;
        }

        public static ElementBuilder CreateURL(string url, string title, string text)
        {
            ElementBuilder link = new ElementBuilder("a");
            link.AddAttribute("href", url);
            link.AddAttribute("title", title);
            link.AddContent(text);
            return link;
        }

        public static ElementBuilder CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("type", type);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);
            input.SelfClosing(true);
            return input;
        }
    }
}
