using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person persona; 
        
        public Person Person
        {
            get 
            {
                return this.persona;
            }
        }
        private int number;

        private List<Node> childrens = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.childrens.AsReadOnly();
            }
        }

        public Node(int number, Person persona)
        {
            this.number = number;
            this.persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.childrens.Add(n);
        }

        public void Accept(Visitor visitor)   
        {
            visitor.Visit(this);
        }     
    }
}
