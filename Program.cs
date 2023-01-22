using CreateNewCar;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car<object> car1 = new Car<object>("BMW Seven Series", "BMW", "Balck", 6, 220, 600, 1200, "Sports", 2000000);
        }
    }
}
