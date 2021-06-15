using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_CashFlowManager
{
    class Salaried : Employee
    {
        private string _Name;
        private string _LastName;
        private string _SSN;
        private decimal _Payment;
        private decimal _HoursWorked;
        private decimal _TotalEarnings;
        public Salaried(string Name, string LastName, string SSN, decimal Payment, decimal HoursWorked,decimal TotalEarnings) : base(Name, LastName, SSN, Payment, HoursWorked, TotalEarnings)
        {
            _Name = Name;
            _LastName = LastName;
            _SSN = SSN;
            _Payment = Payment;
            _HoursWorked = HoursWorked;
            _TotalEarnings = TotalEarnings;
        }
       
        public override string GetName()
        {
            return base.GetName();
        }
        public override LedgerType GetLedgerType()
        {
            return LedgerType.SALARIED;
        }
        public override string GetLastName()
        {
            return base.GetLastName();
        }
        public override string GetSSN()
        {
            return base.GetSSN();
        }
        public override decimal GetPayment()
        {
            //didn't uses a GetEarnings here as Get Payment in this case
            //will do the same thing
            return base.GetPayment();
        }
        public override decimal GetHoursWorked()
        {
            return base.GetHoursWorked();
        }
        public override decimal TotalEarnings()
        {
            decimal TotalEarnings = 0;
            TotalEarnings = _Payment;
            return TotalEarnings;
        }
    }
}
