using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.DTO
{
    class dtoClient
    {

        int _IDCLIENTE;
        String _CLIIDENTIFICACION;
        String _CLINOMBRES;
        String _CLIAPELLIDOS;
        DateTime _CLIFECHANACIMIENTO;
        DateTime _CLIFECHAINSCRIPCION;
        String _CLITELEFONO;
        String _CLIDIRECCION;
        float _CLISALDOPENDIENTE;

        public dtoClient() { }

        public dtoClient(int iDCLIENTE, string cLIIDENTIFICACION, string cLINOMBRES, string cLIAPELLIDOS, DateTime cLIFECHANACIMIENTO, DateTime cLIFECHAINSCRIPCION, string cLITELEFONO, string cLIDIRECCION, float cLISALDOPENDIENTE)
        {
            IDCLIENTE = iDCLIENTE;
            CLIIDENTIFICACION = cLIIDENTIFICACION;
            CLINOMBRES = cLINOMBRES;
            CLIAPELLIDOS = cLIAPELLIDOS;
            CLIFECHANACIMIENTO = cLIFECHANACIMIENTO;
            CLIFECHAINSCRIPCION = cLIFECHAINSCRIPCION;
            CLITELEFONO = cLITELEFONO;
            CLIDIRECCION = cLIDIRECCION;
            CLISALDOPENDIENTE = cLISALDOPENDIENTE;
        }

        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        public string CLIIDENTIFICACION { get => _CLIIDENTIFICACION; set => _CLIIDENTIFICACION = value; }
        public string CLINOMBRES { get => _CLINOMBRES; set => _CLINOMBRES = value; }
        public string CLIAPELLIDOS { get => _CLIAPELLIDOS; set => _CLIAPELLIDOS = value; }
        public DateTime CLIFECHANACIMIENTO { get => _CLIFECHANACIMIENTO; set => _CLIFECHANACIMIENTO = value; }
        public DateTime CLIFECHAINSCRIPCION { get => _CLIFECHAINSCRIPCION; set => _CLIFECHAINSCRIPCION = value; }
        public string CLITELEFONO { get => _CLITELEFONO; set => _CLITELEFONO = value; }
        public string CLIDIRECCION { get => _CLIDIRECCION; set => _CLIDIRECCION = value; }
        public float CLISALDOPENDIENTE { get => _CLISALDOPENDIENTE; set => _CLISALDOPENDIENTE = value; }
    }
}
