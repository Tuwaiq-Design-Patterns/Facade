using System;

namespace Facade_Design_Pattern
{

    public class BankOperation
    {
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", cust.Name, amount);

            bool eligible = true;


            if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }

    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }

    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }

    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
    
            BankOperation operation = new BankOperation();

            Customer customer = new Customer("Samirah ALhusayni");
            bool eligible = operation.IsEligible(customer, 100000);

            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
