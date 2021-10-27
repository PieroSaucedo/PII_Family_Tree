using System;

namespace Library
{
    public class NodeVisitorAge : Visitor
    {
        public override void Visit(Node node)
        {
            foreach (Node children in node.Children)
            {
                sumaEdad += children.Person.Edad;
            }
            sumaEdad += node.Person.Edad;
            Console.WriteLine($"La suma de las edades es de {sumaEdad} años");
        }   
    }
}
