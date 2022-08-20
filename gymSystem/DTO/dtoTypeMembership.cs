using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.DTO
{
    class dtoTypeMembership
    {
        int IDTIPOMEM;
        String TIPDESCRIPTION;

        public dtoTypeMembership() { }

        public dtoTypeMembership(int iDTIPOMEM, string tIPDESCRIPTION)
        {
            IDTIPOMEM = iDTIPOMEM;
            TIPDESCRIPTION1 = tIPDESCRIPTION;
        }

        public int IDTIPOMEM1 { get => IDTIPOMEM; set => IDTIPOMEM = value; }
        public string TIPDESCRIPTION1 { get => TIPDESCRIPTION; set => TIPDESCRIPTION = value; }
    }
}
