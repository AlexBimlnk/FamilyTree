using System;
using FamilyTree.DI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public class Family : IFamily
    {
        private List<IPerson> _brothers = new List<IPerson>();
        private List<IPerson> _sisters = new List<IPerson>();
        private List<IPerson> _children = new List<IPerson>();

        public IPerson Mother { get; set; }
        public IPerson Father { get; set; }
        public IPerson MarriagePartner { get; set; }


        #region Старшие родственники

        public List<IPerson> GrandParents()
        {
            List<IPerson> grandParents = new List<IPerson>();
            grandParents.AddRange(GrandMothers());
            grandParents.AddRange(GrandFathers());

            return grandParents;
        }
        public List<IPerson> GrandFathers()
        {
            List<IPerson> grandFathers = new List<IPerson>();
            grandFathers.Add(Mother.Family.Father);
            grandFathers.Add(Father.Family.Father);

            return grandFathers;
        }
        public List<IPerson> GrandMothers()
        {
            List<IPerson> grandMothers = new List<IPerson>();
            grandMothers.Add(Mother.Family.Mother);
            grandMothers.Add(Father.Family.Mother);

            return grandMothers;
        }

        public List<IPerson> Aunts()
        {
            List<IPerson> aunts = new List<IPerson>();
            aunts.AddRange(Mother.Family.Sisters());
            aunts.AddRange(Father.Family.Sisters());

            return aunts;
        }
        public List<IPerson> Uncles()
        {
            List<IPerson> uncles = new List<IPerson>();
            uncles.AddRange(Mother.Family.Brothers());
            uncles.AddRange(Father.Family.Brothers());

            return uncles;
        }

        #endregion


        #region Ровесники родственники

        public List<IPerson> Brothers()
        {
            return _brothers;
        }
        public List<IPerson> Sisters()
        {
            return _sisters;
        }

        public List<IPerson> Cousins()
        {
            List<IPerson> cousins = new List<IPerson>();

            foreach (var i in Uncles())
                cousins.AddRange(i.Family.Children());

            foreach (var i in Aunts())
                cousins.AddRange(i.Family.Children());


            return cousins;
        }
        public List<IPerson> CousinsBrothers()
        {
            return RelativesOrderByGender(Cousins(), Genders.Man);
        }
        public List<IPerson> CousinsSisters()
        {
            return RelativesOrderByGender(Cousins(), Genders.Woman);
        }

        #endregion


        #region Младшие родственники

        public List<IPerson> Children()
        {
            return _children;
        }
        public List<IPerson> Daughters()
        {
            return RelativesOrderByGender(Children(), Genders.Woman);
        }
        public List<IPerson> Sons()
        {
            return RelativesOrderByGender(Children(), Genders.Man);
        }

        public List<IPerson> NephewsAndNieces()
        {
            List<IPerson> nephewsAndNieces = new List<IPerson>();

            foreach (var i in Children())
                nephewsAndNieces.AddRange(i.Family.Children());

            return nephewsAndNieces;
        }
        public List<IPerson> Nephews()
        {
            return RelativesOrderByGender(NephewsAndNieces(), Genders.Man);
        }
        public List<IPerson> Nieces()
        {
            return RelativesOrderByGender(NephewsAndNieces(), Genders.Woman);
        }

        #endregion


        #region Добавление родственников

        public void AddChild(IPerson child)
        {
            _children.Add(child);
        }

        public void AddBrother(IPerson brother)
        {
            _brothers.Add(brother);
        }
        public void AddSister(IPerson sister)
        {
            _sisters.Add(sister);
        }

        #endregion


        /// <summary>
        /// Формирует список из заданной коллекции по выбраному полу.
        /// </summary>
        /// <param name="collection"> Коллекция из которой выбрать элементы. </param>
        /// <param name="gender"> Пол, по которому отобрать элементы. </param>
        /// <returns> Список IPerson, являющийся выборкой по полу.  </returns>
        private List<IPerson> RelativesOrderByGender(List<IPerson> collection, Genders gender)
        {
            List<IPerson> list = new List<IPerson>();

            foreach (var i in collection)
            {
                if (i.Gender == gender)
                    list.Add(i);
            }

            return list;
        }
    }
}
