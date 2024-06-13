using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_App
{
    internal class Game1
    {
        List<Car> cars = new List<Car>()
        {
            new Car(Gamestate.sprite, "Bil 1", 0, 0),
        };
        internal void firstCarGame()
        {
            Gamestate.finishLine = 1000;
            while (cars[0]._distanceDriven < Gamestate.finishLine)
            {
                if (cars[0]._distanceDriven < 500) cars[0].accelerate(10);
                else if (cars[0]._distanceDriven >= 500 && cars[0]._speed > 10) cars[0].accelerate(-10);
                cars[0].drive();
                display();
                Thread.Sleep(30);
            }
            Console.WriteLine("Bilen er fremme og har parkert!");
        }

        private void display()
        {
            Console.Clear();
            Console.WriteLine($"{cars[0]._avatar}");
        }
    }
}
