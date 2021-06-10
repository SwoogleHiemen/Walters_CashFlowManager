using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_CashFlowManager
{
    class Invoice : IPayable
    {
        string _PartNumber;
        string _PartDescription;
        int _Quantity;
        decimal _Price;
        public Invoice(string PartNumber, int Quantity, string PartDescription, decimal Price) 
        {
            _PartNumber = PartNumber;
            _PartDescription = PartDescription;
            _Quantity = Quantity;
            _Price = Price;
        }
        //Invoice will be differnet from Hourly and Salaried, but i can still use their methods in 
        // a similar way.

        virtual public LedgerType GetLedgerType()//Lets Main know that this is the Invoice class
        {
            return LedgerType.INVOICE;
        }

       
        
        public string GetName()//instead of getting the name, this will get the part number
        {
            string PartNumber = _PartNumber;
            return PartNumber;
        }

        public string GetLastName()// ill use this method to get the part description
        {
            string PartDescription = _PartDescription;
            return PartDescription;
        }

        public string GetSSN()// I wont use this one, so ill keep it as throw...
        {
            throw new NotImplementedException();
        }

        public decimal GetPayment()//represents Price in this case
        {
            decimal Price = _Price;
            return Price;
        }

        public decimal GetHoursWorked()//represents Quantity in this case
        {
            int Quantity = _Quantity;
            return Quantity;
        }

       
    }
}
