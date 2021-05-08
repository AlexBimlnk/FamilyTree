using FamilyTree.DI;

namespace FamilyTree.BL
{
    public static class DependencyInjector
    {
        /// <summary>
        /// Внедряет зависимость IPerson, связывая его с классом Person. 
        /// </summary>
        /// <param name="person"> IPerson интерфейс, который надо связать. </param>
        public static void CreateDependency(out IPerson person)
        {
            person = new Person();
        }

        /// <summary>
        /// Внедряет зависимость IFamily, связывая его с классом Family. 
        /// </summary>
        /// <param name="person"> IFamily интерфейс, который надо связать. </param>
        public static void CreateDependency(out IFamily family)
        {
            family = new Family();
        }

        /// <summary>
        /// Внедряет зависимость IDate, связывая его с классом Date. 
        /// </summary>
        /// <param name="person"> IDate интерфейс, который надо связать. </param>
        public static void CreateDependency(out IDate date)
        {
            date = new Date();
        } 
    }
}
