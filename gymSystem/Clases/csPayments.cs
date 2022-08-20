using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.Clases
{
    class csPayments
    {
        private int _IDPAGO;
        private int _IDCLIENTE;
        private String _PAGOCONCEPTO;
        private String _IDSERVICIO;
        private float _PAGOVALOR;
        private DateTime _PAGOFECHA;

        public csPayments() { }

        public csPayments(int iDPAGO, int iDCLIENTE, string pAGOCONCEPTO, string iDSERVICIO, float pAGOVALOR, DateTime pAGOFECHA)
        {
            IDPAGO = iDPAGO;
            IDCLIENTE = iDCLIENTE;
            PAGOCONCEPTO = pAGOCONCEPTO;
            IDSERVICIO = iDSERVICIO;
            PAGOVALOR = pAGOVALOR;
            PAGOFECHA = pAGOFECHA;
        }

        public int IDPAGO { get => _IDPAGO; set => _IDPAGO = value; }
        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        public string PAGOCONCEPTO { get => _PAGOCONCEPTO; set => _PAGOCONCEPTO = value; }
        public string IDSERVICIO { get => _IDSERVICIO; set => _IDSERVICIO = value; }
        public float PAGOVALOR { get => _PAGOVALOR; set => _PAGOVALOR = value; }
        public DateTime PAGOFECHA { get => _PAGOFECHA; set => _PAGOFECHA = value; }
    }
}
