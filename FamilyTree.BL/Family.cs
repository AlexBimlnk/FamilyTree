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
        public IPerson Mother { get; set; }
        public IPerson Father { get; set; }
        public IPerson MarriagePartner { get; set; }


        #region Старшие родственники

        public List<IPerson> GrandParents()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> GrandFathers()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> GrandMothers()
        {
            throw new NotImplementedException();
        }

        public List<IPerson> Aunts()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> Uncles()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Ровесники родственники

        public List<IPerson> Brothers()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> Sisters()
        {
            throw new NotImplementedException();
        }

        public List<IPerson> Cousins()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> CousinsBrothers()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> CousinsSisters()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Младшие родственники

        public List<IPerson> Children()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> Daughters()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> Sons()
        {
            throw new NotImplementedException();
        }

        public List<IPerson> NephewsAndNieces()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> Nephews()
        {
            throw new NotImplementedException();
        }
        public List<IPerson> Nieces()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
