namespace Library
{
    public abstract class Visitor
    {  
        public abstract void Visit(Node node);
        public int sumaEdad{ get; set; } = 0;
    }
}