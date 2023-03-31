using System;

namespace _31032023.tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nece eded group yaratmaq isteyirsiz ?");

            //int count;
            //string countStr=Console.ReadLine();

            //while (!int.TryParse(countStr,out count))
            //{
            //    Console.WriteLine("Daxil etdiyiniz deyerin formati duzgun deyil!!");
            //    countStr = Console.ReadLine();
            //}
            //Group[] groups = new Group[count];
            //int counter = 1;
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"{++i} - inci obyektin datalarini daxil edin:");
            //    i--;
            //    Console.WriteLine("No :");
            //    string no=Console.ReadLine();

            //    Console.WriteLine("StudentLimit :");
            //    int limit;
            //    string limitStr = Console.ReadLine();

            //    while (!int.TryParse(limitStr, out limit))
            //    {
            //        Console.WriteLine("Daxil etdiyiniz deyerin formati duzgun deyil!!");
            //        limitStr = Console.ReadLine();
            //    }

            //    groups[i] = new Group
            //    {
            //        No = no,
            //        StudentLimit = limit
            //    };
            //}

            //foreach (var item in groups)
            //{
            //    Console.WriteLine(item.GetInfo());
            //}

            Console.WriteLine("Car obyektinin melumatlarini daxil edin:");

            Console.WriteLine("Brandini daxil edin :");
            string brand=Console.ReadLine();

            Console.WriteLine("Modelini daxil edin :");
            string model=Console.ReadLine();

            Console.WriteLine("Benzin hecmini daxil edin:");
            int fuelCapasity=int.Parse(Console.ReadLine());

            Console.WriteLine("HAl hazirdaki benzin deyeri:");
            int nowCapasity = int.Parse(Console.ReadLine());

            Console.WriteLine("1km- e nece litr benzin isledir:");
            int fuelFor1km=int.Parse(Console.ReadLine());

            Car car = new Car
            {
                Brand = brand,  
                Model = model,  
                FuelCapasity = fuelCapasity,
                NowCapasity= nowCapasity,
                FuelFor1Km=fuelFor1km   
            };
            Console.WriteLine(car.GetInfo());
            Console.WriteLine("==================");

            Console.WriteLine("Nece km yol gedilib?");
            int way = int.Parse(Console.ReadLine());
            car.Drive(way);

            Console.WriteLine("==============");
            Console.WriteLine(car.GetInfo());

        }
    }
}
