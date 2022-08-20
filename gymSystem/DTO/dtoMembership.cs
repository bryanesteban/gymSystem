using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.DTO
{

    class dtoMembership
    {
        int _IDMEMBRESIA;
        String _CLIIDENTIFICACION;
        String _MEMCLIENT;
        String _MEMTIPO;
        DateTime _MEMFECHAINICIO;
        DateTime _MEMFECHAFIN;
        float _MEMCOSTO;

        public dtoMembership() { }

        public dtoMembership(int iDMEMBRESIA, string cLIIDENTIFICACION, string mEMCLIENT, string mEMTIPO, DateTime mEMFECHAINICIO, DateTime mEMFECHAFIN, float mEMCOSTO)
        {
            _IDMEMBRESIA = iDMEMBRESIA;
            _CLIIDENTIFICACION = cLIIDENTIFICACION;
            _MEMCLIENT = mEMCLIENT;
            _MEMTIPO = mEMTIPO;
            _MEMFECHAINICIO = mEMFECHAINICIO;
            _MEMFECHAFIN = mEMFECHAFIN;
            _MEMCOSTO = mEMCOSTO;
        }

        public int IDMEMBRESIA { get => _IDMEMBRESIA; set => _IDMEMBRESIA = value; }
        public string MEMCLIENT { get => _MEMCLIENT; set => _MEMCLIENT = value; }
        public string MEMTIPO { get => _MEMTIPO; set => _MEMTIPO = value; }
        public DateTime MEMFECHAINICIO { get => _MEMFECHAINICIO; set => _MEMFECHAINICIO = value; }
        public DateTime MEMFECHAFIN { get => _MEMFECHAFIN; set => _MEMFECHAFIN = value; }
        public float MEMCOSTO { get => _MEMCOSTO; set => _MEMCOSTO = value; }
        public string CLIIDENTIFICACION { get => _CLIIDENTIFICACION; set => _CLIIDENTIFICACION = value; }
    }
}
