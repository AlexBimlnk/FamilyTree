using FamilyTree.BL;
using FamilyTree.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person1 = new Person("Name", "LastName", "Pat", 12, "12.12.1912", "12.12.1912");
            IPerson person2 = new Woman("Name", "MaidenName", "LastName", "Pat", 12, "12.12.1912", "12.12.1912");
            IPerson person3 = new Man("Name", "LastName", "Pat", 12, "12.12.1912", "12.12.1912");
            IPerson person4 = new Woman();

            person4.LastName = "LastName";
            person4.Name = "Name";
            person4.Patronymic = "Pat";
            person1.Family.Mother = person2;
            person1.Family.AddChild(person3);
            person1.Family.AddChild(person4);

            Console.WriteLine($"Children count: {person1.Family.Children().Count}");

            Console.WriteLine(person1.Age);
            Console.WriteLine(person2.Age);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);
            Console.WriteLine(person1.FullName());
            Console.WriteLine(person2.FullName());
            Console.WriteLine(person2.Gender == Genders.Woman);
            Console.WriteLine(person3.Gender == Genders.Man);
            Console.WriteLine(person4.Gender == Genders.Woman);
            Console.WriteLine(person4.FullName());
            Console.ReadKey();
        }
    }
}
