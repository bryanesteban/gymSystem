using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.Clases
{
    class csProduct
    {
        int     _IDPRODUCTO;
        String  _PRONOMPROVEEDOR;
        String _PROCODIGOBARRAS;
        String _PRONOMBRE;
        int     _PROEXISTENCIA;
        float   _PROVALOR;
        float _PROCOSTOUNIDAD;

        public csProduct()
        {

        }
        public csProduct(int iDPRODUCTO, string pRONOMPROVEEDOR, string pROCODIGOBARRAS, string pRONOMBRE, int pROEXISTENCIA, float pROVALOR, float pROCOSTOUNIDAD)
        {
            IDPRODUCTO = iDPRODUCTO;
            PRONOMPROVEEDOR = pRONOMPROVEEDOR;
            PROCODIGOBARRAS = pROCODIGOBARRAS;
            PRONOMBRE = pRONOMBRE;
            PROEXISTENCIA = pROEXISTENCIA;
            PROVALOR = pROVALOR;
            PROCOSTOUNIDAD = pROCOSTOUNIDAD;
        }

        public int IDPRODUCTO { get => _IDPRODUCTO; set => _IDPRODUCTO = value; }
        public string PRONOMPROVEEDOR { get => _PRONOMPROVEEDOR; set => _PRONOMPROVEEDOR = value; }
        public string PROCODIGOBARRAS { get => _PROCODIGOBARRAS; set => _PROCODIGOBARRAS = value; }
        public string PRONOMBRE { get => _PRONOMBRE; set => _PRONOMBRE = value; }
        public int PROEXISTENCIA { get => _PROEXISTENCIA; set => _PROEXISTENCIA = value; }
        public float PROVALOR { get => _PROVALOR; set => _PROVALOR = value; }
        public float PROCOSTOUNIDAD { get => _PROCOSTOUNIDAD; set => _PROCOSTOUNIDAD = value; }
    }
}
