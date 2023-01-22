using CreateNewCar;
using CretaePassport;

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

            foreach (Car<object> item in carList)
            {
                //item.DisplayData();
                //item.PrintInfo<object>(item);
            }

            //heare is my passport data insert int this class...
            Passport<object> habib = new Passport<object>(
                "Kiron Bepary",
                "8367318938",
                "Pira Begum",
                "7812378723",
                "Habibor Rahaman",
                "6463935095",
                "Male",
                "05-03-1999",
                "Bangladeshi",
                "29-12-2025"
            );
            Passport<object> allen = new Passport<object>(
                "Jems Watt",
                "4782378232",
                "Jully Nafis",
                "7812378723",
                "Zayen Malik",
                "19239238334",
                "Male",
                "07-08-1992",
                "Pakistani",
                "21-12-2029"
            );
            Passport<object> sobuj = new Passport<object>(
                "Kiron Bepary",
                "8367318938",
                "Pira Begum",
                "7812378723",
                "Mursalin Sobuj",
                "7812738732",
                "Male",
                "04-01-1993",
                "Bangladeshi",
                "28-12-2027"
            );
            List<object> pasports = new List<object>()
            {
                habib, allen, sobuj
            };

            //use for loop
            for (int i = 0; i < pasports.Count; i++)
            {
                habib.PrintInfo<object>((Passport<object>)pasports[i]);
            }

            //use foretxh 
            foreach (Passport<object> item in pasports)
            {
                item.PrintInfo<object>(item);
            }

        }
    }
}
