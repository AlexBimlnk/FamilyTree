using System;
using System.Collections.Generic;
using FamilyTree.DI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public class Person : IPerson
    {
        protected int age = -1;
        protected IFamily family;
        protected IDate birth;
        protected IDate death;

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; }
        }
        public Genders Gender { get; set; }


        public IDate Birth => birth;
        public IDate Death => death;


        public IFamily Family => family;


        public string DataPath { get; set; }


        public Person()
        {
            CreatePersonDependency();
        }

        public Person(string name, string lastName, string patronymic,
                      int age, string dateBirth, string dateDeath)
        {
            CreatePersonDependency();

            bool result;

            Name = name;
            LastName = lastName;
            Patronymic = patronymic;
            Age = age;

            int[] buffer = Array.ConvertAll(dateBirth.Split('.'), x => int.Parse(x));

            birth = new Date();
            birth.TrySetDate(buffer[0], buffer[1], buffer[2], out result);

            buffer = Array.ConvertAll(dateDeath.Split('.'), x => int.Parse(x));

            death = new Date();
            death.TrySetDate(buffer[0], buffer[1], buffer[2], out result);
        }


        public virtual string FullName()
        {
            return $"{LastName} {Name} {Patronymic}";
        }

        public string YearsOfLife()
        {
            return $"{Birth.FullDate} - {Death.FullDate}";
        }


        /// <summary>
        /// Внедрение зависимостей.
        /// </summary>
        private void CreatePersonDependency()
        {
            DependencyInjector.CreateDependency(out birth);
            DependencyInjector.CreateDependency(out death);
            DependencyInjector.CreateDependency(out family);
        }
    }
}
