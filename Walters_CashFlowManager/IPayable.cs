using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_CashFlowManager
{
    interface IPayable
    {
   
        LedgerType GetLedgerType(); 
        string GetName();
        string GetLastName();
        string GetSSN();
        decimal GetPayment();
        decimal GetHoursWorked();
        decimal GetEarnings();
    }
    public enum LedgerType
    {
        SALARIED,
        HOURLY,
        INVOICE
    }
    

}
