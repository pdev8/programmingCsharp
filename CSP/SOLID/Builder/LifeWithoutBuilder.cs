using System;
using System.Text;

namespace CSP.SOLID.Builder
{
    public class LifeWithoutBuilder
    {
        public static void Run()
        {
            BuildHtmlString();
        }

        public static void BuildHtmlString()
        {
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");

            ////Console.WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.Append($"<li>{word}</li>");
            }
            sb.Append("</ul>");

            Console.WriteLine(sb);
        }
    }
}