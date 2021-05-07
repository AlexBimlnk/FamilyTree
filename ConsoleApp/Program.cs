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
            IPerson person1 = new Person("Name", "LastName", "Pat",12,"12.12.1912", "12.12.1912");
            IPerson person2 = new Woman("Name", "MaidenName", "LastName", "Pat",12,"12.12.1912", "12.12.1912");

            Console.WriteLine(person1.Age);
            Console.WriteLine(person2.Age);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);
            Console.WriteLine(person1.FullName());
            Console.WriteLine(person2.FullName());
            Console.ReadKey();
        }
    }
}
