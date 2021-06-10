using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_CashFlowManager
{
    class Employee : IPayable
    {
        private string _Name;
        private string _SSN;
        private string _LastName;
        private decimal _Payment;
        private decimal _HoursWorked;

        public Employee()
        {
        }

        public Employee(string Name, string LastName, string SSN,decimal Payment, decimal HoursWorked)
        {
            _Name = Name;
            _LastName = LastName;
            _SSN = SSN;
            _Payment = Payment;
            _HoursWorked = HoursWorked;
            
        }

        virtual public decimal GetHoursWorked()
        {
            decimal HoursWorked = _HoursWorked;
            return HoursWorked;
        }

        virtual public string GetLastName()
        {
           string LastName = _LastName;
            return _LastName;
        }

        virtual public LedgerType GetLedgerType()
        {
            return GetLedgerType();
        }

        virtual public string GetName()
        {
            string Name = _Name;
            return Name;
        }

        virtual public decimal GetPayment()
        {
            decimal Payment = _Payment;
                return Payment;
        }

        virtual public string GetSSN()
        {
            string SSN = _SSN;
            return SSN;
        }
    }
}
