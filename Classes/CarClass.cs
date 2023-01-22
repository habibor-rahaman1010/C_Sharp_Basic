//ites my generic class in c# programming language...
namespace CreateNewCar
{
    class Car<T>
    {
        public T model;
        public T brand;
        public T color;
        public T gearBox;
        public T speed;
        public T hoursPower;
        public T cc;
        public T carType;
        public T price;

        public Car(T model, T brand, T color, T gearBox, T speed, T hoursPower, T cc, T carType, T price)
        {
            this.model = model;
            this.brand = brand;
            this.color = color;
            this.gearBox = gearBox;
            this.speed = speed;
            this.hoursPower = hoursPower;
            this.cc = cc;
            this.carType = carType;
            this.price = price;
        }

        public void DisplayData()
        {
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Brand: " + this.brand);
            Console.WriteLine("Gear Box: " + this.gearBox);
            Console.WriteLine("Speed: " + this.speed);
            Console.WriteLine("Hourse Power: " + this.hoursPower);
            Console.WriteLine("CC: " + this.cc);
            Console.WriteLine("Care Type: " + this.carType);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("\n");
        }

        public void PrintInfo<Type>(Car<Type> data)
        {
            Console.WriteLine("Model: " + data.model);
            Console.WriteLine("Brand: " + data.brand);
            Console.WriteLine("Gear Box: " + data.gearBox);
            Console.WriteLine("Speed: " + data.speed);
            Console.WriteLine("Hourse Power: " + data.hoursPower);
            Console.WriteLine("CC: " + data.cc);
            Console.WriteLine("Care Type: " + data.carType);
            Console.WriteLine("Price: " + data.price);
            Console.WriteLine("\n");
        }
    }
}
