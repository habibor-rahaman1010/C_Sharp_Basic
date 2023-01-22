using System.Collections.Generic;
namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>() { "Bill gates", "Microsoft" };
            name.Add("Habibor Rahaman");
            name.Add("Tamim Sahriar Subeen");
            name.Add("Tamid Rafi");
            name.Add("Tamid Rafi");
            name.Add("Tamid Rafi");

            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
