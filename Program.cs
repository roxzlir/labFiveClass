namespace labFiveClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi ska räkna ut area på cirklar!");
            Console.WriteLine("Du får nu skriva in radien för en cirkel som du vill veta arean på.");
            Circle circle1 = new Circle(GetInputNumber()); //Skapar ett objekt och kör metoden för inmatning för att få ett värde för int _radius
            Console.WriteLine("Och nu en till!");
            Circle circle2 = new Circle(GetInputNumber());
            

            circle1.GetArea(); //Efter objekt är skapat kör vi klass metoden som kör matte formeln och skriver ut svaret
            circle2.GetArea();
        }

        public static int GetInputNumber() //Skapar en metod för att felsökning av inmatning från användare så vi är säker på att vi får ett heltal.
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