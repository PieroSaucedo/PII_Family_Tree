using System;

namespace Library
{
    public class Person
    {
        public Person(string name, string edad)
        {
            this.Name = name;
            this.Edad = edad;
        }

        private string name;

        private string edad;

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
        public string Edad
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
