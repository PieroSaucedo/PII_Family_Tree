using System;

namespace Library
{
    public class NodeVisitorName : Visitor
    {
        public string largestName = "";
        public override void Visit(Node node)
        {
            foreach (Node children in node.Children)
            {
                if (largestName.Length < children.Person.Name.Length)
                {
                    largestName = children.Person.Name;
                }
            }
            Console.WriteLine($"El hijo con el nombre más largo es {largestName}");
        }
    }
}
