using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymSystem.DTO
{
    class dtoClientPayment
    {
        String _IDENTIFICATION;
        String _NAME;
        String _LASTNAME;
        String _PAYMENT;
        DateTime _DATEPAYMENT;
        String _CONCEPTPAYMENT;




        public dtoClientPayment()
        {

        }

        public dtoClientPayment(string iDENTIFICATION, string nAME, string lASTNAME, string pAYMENT, DateTime dATEPAYMENT, string cONCEPTPAYMENT)
        {
            IDENTIFICATION = iDENTIFICATION;
            NAME = nAME;
            LASTNAME = lASTNAME;
            PAYMENT = pAYMENT;
            DATEPAYMENT = dATEPAYMENT;
            CONCEPTPAYMENT = cONCEPTPAYMENT;
        }

        public string IDENTIFICATION { get => _IDENTIFICATION; set => _IDENTIFICATION = value; }
        public string NAME { get => _NAME; set => _NAME = value; }
        public string LASTNAME { get => _LASTNAME; set => _LASTNAME = value; }
        public string PAYMENT { get => _PAYMENT; set => _PAYMENT = value; }
        public DateTime DATEPAYMENT { get => _DATEPAYMENT; set => _DATEPAYMENT = value; }
        public string CONCEPTPAYMENT { get => _CONCEPTPAYMENT; set => _CONCEPTPAYMENT = value; }
    }
}
