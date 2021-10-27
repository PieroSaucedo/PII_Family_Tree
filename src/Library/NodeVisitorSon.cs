using System;

namespace Library
{
    public class NodeVisitorSon : Visitor
    {
        public string elMayor = "";
        public int age = 0;
        public override void Visit(Node node)
        {  
            foreach (Node children in node.Children)
            {
                if (children.Person.Edad > age)
                {
                    age = children.Person.Edad;
                    elMayor = children.Person.Name;
                }
            }
        Console.WriteLine($"El hijo mayor es {elMayor} y tiene {age} años");
        }
    }
}