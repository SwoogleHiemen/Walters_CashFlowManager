using System;
//Mason Walters
//IT112
//Notes: This assignement assumes you iput correct information.
// BEHAVIORS NOT IMPLEMENTED AND WHY: I implemented everything I needed
//to implement... I think.
namespace Walters_CashFlowManager
{
    class Program
    {
       
        static void Main(string[] args)
        {
            decimal TWP=0M;//TotalWeeklyPayroll
            decimal TIP = 0M;//TotalInvoicePayroll
            decimal TSP = 0M;//TotalSalariedPayroll
            decimal THP = 0M;//TotalHourlyPayroll
            ConsoleKeyInfo UserInput;
            int counter = 0;
            bool quite = false;
            //these are the first 3 invoices, 3 Salaried and 3 Hourly Employees
            Salaried SP1 = new Salaried("Greg", "Hefley", "456523346",13.00M,1M,1);
            Salaried SP2 = new Salaried("Mr.", "Beast", "124633692", 200000M, 1M,1);
            Salaried SP3 = new Salaried("Aloysius", "O'Hare", "420123420", 500000M, 1M,1);
            Hourly HP1 = new Hourly("Joe", "Swanson", "123456781", 14.50M, 40M,1);
            Hourly HP2 = new Hourly("Peter", "Griffin", "420696006", 12M, 23M,1);
            Hourly HP3 = new Hourly("Chris", "Evans", "345640467",40M, 48M,1);
            Invoice IN1 = new Invoice("2841", 3, "Rubix cube",13.78M);
            Invoice IN2 = new Invoice("7812", 1, "Water Bottle", 2M);
            Invoice IN3 = new Invoice("5827", 4, "GameCube Controller", 59.99M);
            //this is the array that will hold all of the Employees and invoices up to 50.
            IPayable[] Analysis = new IPayable[50];
            Analysis[0] = SP1;
            Analysis[1] = SP2;
            Analysis[2] = SP3;
            Analysis[3] = HP1;
            Analysis[4] = HP2;
            Analysis[5] = HP3;
            Analysis[6] = IN1;
            Analysis[7] = IN2;
            Analysis[8] = IN3;
            do
            {
                //These messeges will repeat until you press 5 to quite.
                Console.Clear();
                Console.WriteLine("Type the number next to the type you want to select:");
                Console.WriteLine("Salaried Employee: 1");
                Console.WriteLine("Hourly Employee: 2");
                Console.WriteLine("Invoice: 3");
                Console.WriteLine("Analysis Report: 4");
                Console.WriteLine("Exit: 5");
                UserInput = Console.ReadKey();
                //Pressing 1 will run this if statement, which will run you through the process
                // of creating a Weekly Salaried Employee
                if (UserInput.Key == ConsoleKey.D1)
                {
                    decimal HoursWorked = 0M;
                    decimal TotalEarnings = 0M;
                    Console.Clear();
                    Employee employee = new Employee();
                    
                    Console.WriteLine("What is this employee's first name?");
                    string Name = Console.ReadLine();
                    Console.WriteLine("What is this employee's Last name?");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("What is this employee's SSN number?" +
                        " (make sure just to type in just the 9 numbers, DO NOT include the dashes)");
                    string SSN = Console.ReadLine();
                    SSN = string.Format("{0:###-##-####}",SSN);
                    Console.WriteLine("What is this employee's weekly Salary?");
                    decimal Payment = decimal.Parse(Console.ReadLine());

                    //this is what actually puts the information in and creates the Employee,
                    //and you will see this in the next two if statements.
                    employee = new Salaried(Name, LastName, SSN, Payment, HoursWorked,TotalEarnings);
                    counter++;
                    Analysis[8 + counter] = employee;
                }
                // pressing 2 will run this if statement, which will run through the process
                // of creating a Hourly Paid Employee
                if (UserInput.Key == ConsoleKey.D2)
                {
                    decimal TotalEarnings = 0M;
                    Console.Clear();
                    Employee employee = new Employee();
                    Console.WriteLine("What is this employee's first name?");
                    string Name = Console.ReadLine();
                    Console.WriteLine("What is this employee's Last name?");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("What is this employee's SSN number?" +
                        " (make sure to ONLY include the 9 digits)");
                    string SSN = Console.ReadLine();
                    Console.WriteLine("What is this employee's Hourly Wage?");
                    decimal Payment = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("How Many hours this week did this Employee work?");
                    decimal HoursWorked = decimal.Parse(Console.ReadLine());

                    employee = new Hourly(Name, LastName, SSN, Payment, HoursWorked,TotalEarnings);
                    counter++;
                    Analysis[8 + counter] = employee;
                }

                // pressing 3 will run this if statement, which will run through the process
                // of creating a Invoice
                if (UserInput.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.WriteLine("What is the invoices part number?(make sure to ONLY include the 4 digits)");
                    string PartNumber = Console.ReadLine();
                    Console.WriteLine("How many of this item is there?");
                    int Quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the name of this product?");
                    string PartDescription = Console.ReadLine();
                    Console.WriteLine("How much does this item cost?"); 
                    decimal Price = decimal.Parse(Console.ReadLine());
                    Invoice employee = new Invoice(PartNumber, Quantity, PartDescription, Price);

                    employee = new Invoice(PartNumber, Quantity, PartDescription, Price);
                    counter++;
                    Analysis[8 + counter] = employee;
                }

                //pressing 4 will run this if statement, which will Generate a report reflecting
                //total output of all ledger items
                if (UserInput.Key == ConsoleKey.D4)
                {
                    //resetting the variables for the beginning of each report
                    TWP = 0;
                    TIP = 0;
                    THP = 0;
                    TSP = 0;
                    Console.Clear();
                    for (int i = 0 ; i < 9 + counter; i++)
                    {
                        

                        if (Analysis[i].GetLedgerType() == LedgerType.SALARIED)
                        {
                            Console.WriteLine("========Salaried Employees========");
                            Console.WriteLine("Salaried Employee: "+ Analysis[i].GetName() + " " + Analysis[i].GetLastName());
                            Console.WriteLine("SSN: " + string.Format("{0:###-##-####}", int.Parse(Analysis[i].GetSSN())));
                            Console.WriteLine("Weekly Salary: "+ string.Format("{0:C}", Analysis[i].GetPayment()));
                            Console.WriteLine("Earned: " + string.Format("{0:C}", Analysis[i].GetPayment()));
                            Console.WriteLine("");
                            //TWP +=  Analysis[i].GetPayment();
                           // TSP += Analysis[i].GetPayment();
                            TWP += Analysis[i].TotalEarnings();
                            TSP += Analysis[i].TotalEarnings();
                        }
                        if (Analysis[i].GetLedgerType() == LedgerType.HOURLY) 
                        {
                            
                            Console.WriteLine("========Hourly Employees========");
                            Console.WriteLine("Hourly Employee: " + Analysis[i].GetName() + " " + Analysis[i].GetLastName());
                            Console.WriteLine("SSN: " + string.Format("{0:###-##-####}", int.Parse(Analysis[i].GetSSN())));
                            Console.WriteLine("Hourly Wage Salary: " + string.Format("{0:C}", Analysis[i].GetPayment()));
                            Console.WriteLine("Hours Worked:" + Analysis[i].GetHoursWorked());
                            Console.WriteLine("Earned: " + string.Format("{0:C}", Analysis[i].GetEarnings()));
                            Console.WriteLine("");
                            //TWP += Analysis[i].GetEarnings();
                            //THP += Analysis[i].GetEarnings();
                            TWP += Analysis[i].TotalEarnings();
                            THP += Analysis[i].TotalEarnings();
                        }
                        if (Analysis[i].GetLedgerType() == LedgerType.INVOICE)
                        {
                            
                            Console.WriteLine("============Invoices============");
                            string RandomNumber = DateTime.Now.Ticks.ToString();
                            RandomNumber =RandomNumber.Remove(1,12);
                            Console.WriteLine("Invoice: "+ string.Format("{0:######}",RandomNumber) +string.Format("{0:_####}", decimal.Parse(Analysis[i].GetName())));
                            Console.WriteLine("Quantity: "+ Analysis[i].GetHoursWorked());
                            Console.WriteLine("Part Description: "+ Analysis[i].GetLastName());
                            Console.WriteLine("Unit Price: " + string.Format("{0:C}", Analysis[i].GetPayment()));
                            Console.WriteLine("Extended Price: " + string.Format("{0:C}", Analysis[i].GetEarnings()));
                            Console.WriteLine("");
                            //TWP += Analysis[i].GetEarnings();
                            // TIP += Analysis[i].GetEarnings();
                            TWP += Analysis[i].TotalEarnings();
                            TIP += Analysis[i].TotalEarnings();
                        }
                    }
                    //when the above loop ends, then it will run this final messege, giving the 
                    //total weekly payout and the category breakdown.
                    Console.WriteLine("Total Weekly Payout: " + string.Format("{0:C}",TWP));
                    Console.WriteLine("============Category Breakdown============");
                    Console.WriteLine("Invoices: " + string.Format("{0:C}", TIP));
                    Console.WriteLine("Salaried Payroll: "+ string.Format("{0:C}", TSP));
                    Console.WriteLine("Hourly Payroll: "+ string.Format("{0:C}", THP,3));
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                //pressing 5 will quite the program
                if (UserInput.Key == ConsoleKey.D5)
                {
                    quite = true;
                }


            } while (quite == false);
                Console.Clear();
                Console.WriteLine("Have a nice day!");
            





        }
    }
}
