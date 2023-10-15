using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labFiveClass
{
    internal class Circle //Skapar en klass och lägger till två fileds för radie och Pi.
    {
        public int _radius;
        public double _pi;
        public Circle(int radius) //Skapar constructor för att kunna använda mig av variablerna och vill att man måste retunera in ett värde för radie variabel
        {                         //_pi variabel står fast då det ej ska kunna ändras av användare
            _radius = radius;
            _pi = Math.PI;
        }

        public void GetArea() //Skapar en metod för att räkna ut arean, så när användaren matar in en radie så tar vi den in i formeln.
        {

            Console.WriteLine($"Arean på cirkeln är: { _radius* _radius *_pi}");
        }
       
    }
}
