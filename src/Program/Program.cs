using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Pepito", 42);
            Person persona2 = new Person("Manuel", 14);
            Person persona3 = new Person("Alfredo", 8);
            Person persona4 = new Person("Lucas", 33);
            Person persona5 = new Person("WillSmith", 51);
            Person persona6 = new Person("Manuel", 19);
            Person persona7 = new Person("Carlitos", 24);
            Person persona8 = new Person("Rambo", 77);
            
            Node n1 = new Node(1, persona1);
            Node n2 = new Node(2, persona2);
            Node n3 = new Node(3, persona3);
            Node n4 = new Node(4, persona4);
            Node n5 = new Node(5, persona5);
            Node n6 = new Node(6, persona6);
            Node n7 = new Node(7, persona7);
            Node n8 = new Node(8, persona8);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            NodeVisitorAge ageVisitor = new NodeVisitorAge();
            n1.Accept(ageVisitor);

            NodeVisitorName nameVisitor = new NodeVisitorName();
            n2.Accept(nameVisitor);
            n3.Accept(nameVisitor);

            NodeVisitorSon sonVisitor = new NodeVisitorSon();
            n1.Accept(sonVisitor);
            n2.Accept(sonVisitor);
            n3.Accept(sonVisitor);
        }
    }
}
