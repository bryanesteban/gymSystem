using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.Clases
{
    class csMembership
    {
        int IDMEMBRESIA;
        int IDCLIENTE;
        int IDTIPOMEM;
        DateTime MEMFECHAINICIO;
        DateTime MEMFECHAFIN;
        float MEMAVANCEPAGO;
        float MEMCOSTO;

        public csMembership()
        {

        }

        public csMembership(int iDMEMBRESIA, int iDCLIENTE, int iDTIPOMEM, DateTime mEMFECHAINICIO, DateTime mEMFECHAFIN, float mEMCOSTO)
        {
            IDMEMBRESIA = iDMEMBRESIA;
            IDCLIENTE = iDCLIENTE;
            IDTIPOMEM = iDTIPOMEM;
            MEMFECHAINICIO = mEMFECHAINICIO;
            MEMFECHAFIN = mEMFECHAFIN;
            MEMCOSTO = mEMCOSTO;
        }

        public int IDMEMBRESIA1 { get => IDMEMBRESIA; set => IDMEMBRESIA = value; }
        public int IDCLIENTE1 { get => IDCLIENTE; set => IDCLIENTE = value; }
        public int IDTIPOMEM1 { get => IDTIPOMEM; set => IDTIPOMEM = value; }
        public DateTime MEMFECHAINICIO1 { get => MEMFECHAINICIO; set => MEMFECHAINICIO = value; }
        public DateTime MEMFECHAFIN1 { get => MEMFECHAFIN; set => MEMFECHAFIN = value; }
        public float MEMAVANCEPAGO1 { get => MEMAVANCEPAGO; set => MEMAVANCEPAGO = value; }
        public float MEMCOSTO1 { get => MEMCOSTO; set => MEMCOSTO = value; }
    }
}
