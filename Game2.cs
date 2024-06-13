using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_App
{
    internal class Game2
    {
        List<Car> cars = new List<Car>()
        {
            new Car(Gamestate.sprite, "Bil 1", 0, 0),
            new Car(Gamestate.sprite, "Bil 2", 0, 0)
        };

        internal void secondCarGame()
        {
            Gamestate.finishLine = 10000;
            while (cars.All(car => car._distanceDriven < Gamestate.finishLine))
            {
                displayGame2();
                foreach (var car in cars) car.randomDrive();
                Thread.Sleep(30);
            }
            displayGame2();
            genResultGame2();
        }

        private void displayGame2()
        {
            Console.Clear();
            foreach (var car in cars) Console.WriteLine($@"{car._avatar}
");
        }

        void genResultGame2()
        {
            if (cars[0]._distanceDriven > 10000) Console.WriteLine($"{cars[0]._name} vant kappløpet!");
            else if (cars[1]._distanceDriven > 10000) Console.WriteLine($"{cars[1]._name} vant kappløpet!");
            else if (cars[0]._distanceDriven > 10000 && cars[1]._distanceDriven > 10000)
                Console.WriteLine("Det ble uavgjort!");
        }
    }
}
