using System;

namespace Library
{
    public class Person
    {
        public Person(string name, int edad)
        {
            this.Name = name;
            this.Edad = edad;
        }

        private string name;

        private int edad;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                this.name = value;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }

            set
            {
                this.edad = value;
            }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name}, y mi edad es {this.Edad}");
        }
    }
}
