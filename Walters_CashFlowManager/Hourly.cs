using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_CashFlowManager
{
    class Hourly : Employee
    {
        private string _Name;
        private string _LastName;
        private string _SSN;
        private decimal _Payment;
        private decimal _HoursWorked;
        public Hourly(string Name, string LastName, string SSN, decimal Payment,decimal HoursWorked) : base(Name, LastName, SSN,Payment, HoursWorked)
        {
            _Name = Name;
            _LastName = LastName;
            _SSN = SSN;
            _Payment = Payment;
            _HoursWorked = HoursWorked;
        }
        
        public override string GetName()
        {
            return base.GetName();
        }
        public override LedgerType GetLedgerType()
        {
            
            return LedgerType.HOURLY;
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
            return base.GetPayment();
            
        }
        public override decimal GetHoursWorked()
        {
            return base.GetHoursWorked();
        }
        public override decimal GetEarnings()
        {
            decimal Payment=0M;
            if (_HoursWorked <= 40)
            {
                Payment = _Payment;
                Payment = Payment * _HoursWorked;
            }
            if (_HoursWorked > 40)
            {
                Payment = _Payment;
                Payment = (Payment * 40) + (Payment * (_HoursWorked - 40) * 1.5M);
            }
 
            return Math.Round(Payment,3);
        }
    }
}
