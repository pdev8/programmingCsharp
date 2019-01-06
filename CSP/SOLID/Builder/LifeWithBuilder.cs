using System;
using System.Collections.Generic;
using System.Text;

namespace CSP.SOLID.Builder
{
    public class LifeWithBuilder
    {
        public static void Run()
        {
            var builder = new HtmlBuilder("ul");

            builder.AddChild("li", "hello").AddChild("li", "world");

            Console.WriteLine(builder);
        }
    }

    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            this.root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            this.root.Elements.Add(element);

            return this;
        }

        public override string ToString()
        {
            return this.root.ToString();
        }

        public void Clear()
        {
            this.root = new HtmlElement
            {
                Name = this.rootName
            };
        }
    }

    public class HtmlElement
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public List<HtmlElement> Elements = new List<HtmlElement>();

        private const int indentSize = 2;

        public HtmlElement() { }

        public HtmlElement(string name, string text)
        {
            this.Name = name ?? string.Empty;
            this.Text = text ?? string.Empty;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();

            var i = new string(' ', indentSize * indent);

            sb.AppendLine($"{i}<{this.Name}>");

            if (!string.IsNullOrWhiteSpace(this.Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(this.Text);
            }

            foreach (var element in this.Elements)
            {
                sb.Append(element.ToStringImpl(indent + 1));
            }

            sb.AppendLine($"{i}</{this.Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.ToStringImpl(0);
        }
    }
}