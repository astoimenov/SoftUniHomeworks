namespace P04HTMLDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ElementBuilder
    {
        private readonly string elementName;
        private readonly Dictionary<string, string> attrDictionary = new Dictionary<string, string>();
        private string content = string.Empty;
        private bool isSelfClosing = false;

        public ElementBuilder(string elementName)
        {
            this.elementName = elementName;
        }

        public static string operator *(ElementBuilder element, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += element.ToString();
            }

            return result;
        }

        public void AddAttribute(string attr, string value)
        {
            this.attrDictionary.Add(attr, value);
        }

        public void AddContent(string content)
        {
            this.content = content;
        }

        public void SelfClosing(bool selfClosing)
        {
            this.isSelfClosing = selfClosing;
        }

        public override string ToString()
        {
            string attributes = this.attrDictionary.Aggregate(
                string.Empty, (current, attribute) => current + (" " + attribute.Key + "=\"" + attribute.Value + "\""));
            string result = !this.isSelfClosing ? 
                string.Format("<{0}{1}>{2}</{0}>", this.elementName, attributes, this.content) : 
                string.Format("<{0}{1}/>", this.elementName, attributes);
            return result;
        }
    }
}
