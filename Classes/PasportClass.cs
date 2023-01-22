namespace CretaePassport
{
    class ParrantInfo<T>
    {
        public T? fatherName;
        public T? fatherNid;
        public T? motherName;
        public T? motherNid;
    }

    class Passport<T> : ParrantInfo<T>
    {
        public T name;
        public T myNid;
        public T gender;
        public T dateOfBirth;
        public T nationality;
        public T expire;

        public Passport(T fatherName, T fatherNid, T motherName, T motherNid, T name, T myNid, T gender, T dateOfBirth, T nationality, T expire)
        {
            this.fatherName = fatherName;
            this.fatherNid = fatherNid;
            this.motherName = motherName;
            this.motherNid = motherNid;
            this.name = name;
            this.myNid = myNid;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.nationality = nationality;
            this.expire = expire;
        }

        public void PrintInfo<Type>(Passport<Type> data)
        {
            Console.WriteLine("Father Name: " + data.fatherName);
            Console.WriteLine("Father Nid: " + data.fatherNid);
            Console.WriteLine("Mother Name: " + data.motherName);
            Console.WriteLine("Mother Nid" + data.motherNid);
            Console.WriteLine("Name: " + data.name);
            Console.WriteLine("Nid: " + data.myNid);
            Console.WriteLine("Gender: " + data.gender);
            Console.WriteLine("Date of Birth: " + data.dateOfBirth);
            Console.WriteLine("Nationality: " + data.nationality);
            Console.WriteLine("Expire: " + data.expire);
            Console.WriteLine("\n");
        }
    }
}