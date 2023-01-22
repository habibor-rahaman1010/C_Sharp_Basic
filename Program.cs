using CreateNewCar;
using System.Collections.Generic;
namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car<object> car1 = new Car<object>("BMW Seven Series", "BMW", "Balck", 6, 220, 600, 12000, "Sports", 21000000);
            Car<object> car2 = new Car<object>("Toyota", "X-Corola", "Silver", 5, 150, 300, 1500, "Normal", 1500000);
            Car<object> car3 = new Car<object>("Vogatti Veron", "Vogatti", "Balck", 8, 420, 1200, 20000, "Sports", 4700000);
            Car<object> car4 = new Car<object>("Mercidies Benze", "Mercidies", "Silver", 6, 220, 600, 5000, "Sports", 2500000);
            Car<object> car5 = new Car<object>("Voxwagen Gen-Fource", "Voxwagen", "light Balck", 6, 220, 800, 1200, "Sports", 1800000);


            List<object> carList = new List<object>() { car1, car2, car3, car4, car5 };
            carList.Add(new Car<object>("BMW Seven Series", "BMW", "Balck", 6, 220, 600, 12000, "Sports", 21000000));
        }
    }
}
