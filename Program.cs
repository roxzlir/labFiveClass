namespace labFiveClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi ska räkna ut area på cirklar!");
            
            Circle circle1 = new Circle(GetInputNumber());
            Circle circle2 = new Circle(GetInputNumber());
            
            
            circle1.GetArea();
            circle2.GetArea();
        }

        public static int GetInputNumber()
        {
            Console.WriteLine("Vänligen skriv in vilken radie din cirkel har: ");
            int result;
            while (true)
            {
                string inputNumber = Console.ReadLine();
                if (int.TryParse(inputNumber, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du måste mata in ett heltal");
                }
            }
            return result;
        }
    }

}