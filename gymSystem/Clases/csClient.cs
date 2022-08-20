using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.Clases
{
    class csClient
    {
        int IDCLIENTE;
        String CLIIDENTIFICACION;
        String CLINOMBRE;
        String CLISEGUNDONOMBRE;
        String CLIAPELLIDOPATERNO;
        String CLIAPELLIDOMATERNO;
        DateTime CLIFECHANACIMIENTO;
        DateTime CLIFECHAINSCRIPCION;
        String CLITELEFONO;
        String CLIDIRECCION;
        float CLISALDOPENDIENTE;

        public csClient()
        {

        }
        public csClient(int iDCLIENTE, string cLIIDENTIFICACION, string cLINOMBRE, string cLISEGUNDONOMBRE, string cLIAPELLIDOPATERNO, string cLIAPELLIDOMATERNO, DateTime cLIFECHANACIMIENTO, DateTime cLIFECHAINSCRIPCION, string cLITELEFONO, string cLIDIRECCION, float cLISALDOPENDIENTE)
        {
            IDCLIENTE1 = iDCLIENTE;
            CLIIDENTIFICACION1 = cLIIDENTIFICACION;
            CLINOMBRE1 = cLINOMBRE;
            CLISEGUNDONOMBRE1 = cLISEGUNDONOMBRE;
            CLIAPELLIDOPATERNO1 = cLIAPELLIDOPATERNO;
            CLIAPELLIDOMATERNO1 = cLIAPELLIDOMATERNO;
            CLIFECHANACIMIENTO1 = cLIFECHANACIMIENTO;
            CLIFECHAINSCRIPCION1 = cLIFECHAINSCRIPCION;
            CLITELEFONO1 = cLITELEFONO;
            CLIDIRECCION1 = cLIDIRECCION;
            CLISALDOPENDIENTE1 = cLISALDOPENDIENTE;
        }

        public int IDCLIENTE1 { get => IDCLIENTE; set => IDCLIENTE = value; }
        public string CLIIDENTIFICACION1 { get => CLIIDENTIFICACION; set => CLIIDENTIFICACION = value; }
        public string CLINOMBRE1 { get => CLINOMBRE; set => CLINOMBRE = value; }
        public string CLISEGUNDONOMBRE1 { get => CLISEGUNDONOMBRE; set => CLISEGUNDONOMBRE = value; }
        public string CLIAPELLIDOPATERNO1 { get => CLIAPELLIDOPATERNO; set => CLIAPELLIDOPATERNO = value; }
        public string CLIAPELLIDOMATERNO1 { get => CLIAPELLIDOMATERNO; set => CLIAPELLIDOMATERNO = value; }
        public DateTime CLIFECHANACIMIENTO1 { get => CLIFECHANACIMIENTO; set => CLIFECHANACIMIENTO = value; }
        public DateTime CLIFECHAINSCRIPCION1 { get => CLIFECHAINSCRIPCION; set => CLIFECHAINSCRIPCION = value; }
        public string CLITELEFONO1 { get => CLITELEFONO; set => CLITELEFONO = value; }
        public string CLIDIRECCION1 { get => CLIDIRECCION; set => CLIDIRECCION = value; }
        public float CLISALDOPENDIENTE1 { get => CLISALDOPENDIENTE; set => CLISALDOPENDIENTE = value; }
    }
}
