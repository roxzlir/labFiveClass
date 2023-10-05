namespace labFiveClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            circle1.GetArea();
            circle2.GetArea();
        }
    }
}