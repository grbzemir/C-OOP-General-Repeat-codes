using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    // miras alma kalıtım 

    public class Customer

    {
        public string name;
        public string lastname;
        public string city;

        public void PrintFullName()

        {

            Console.WriteLine(name + " " +  lastname);
            
        }
    }

    public class LocalCustomer:Customer

    {
        public int MonthlyPayment;


        public void PrintMonthlyPayment()

        {
            Console.WriteLine("Monthly payment = " + MonthlyPayment);

        }


    }

    public class  ForeignCustomer:Customer
    {
        public int YearlyPayment;
        public string Country;

        public void PrintCountry() 
        
        {
            Console.WriteLine("Yearly payment = " + YearlyPayment);
        }
    }
    public class Program
    {
        static void Main(string[] args)

        {

            LocalCustomer lcs = new LocalCustomer();
            lcs.name = "Emir";
            lcs.lastname = "Gürbüz";
            lcs.city = "istanbul";
            lcs.MonthlyPayment = 10000;
            lcs.PrintFullName();
            lcs.PrintMonthlyPayment();

            Console.WriteLine("**************************");

            ForeignCustomer fcs = new ForeignCustomer();
            fcs.name = "yetkin";
            fcs.lastname = "Gürbüz";
            fcs.city = "İstanbul";
            fcs.Country = "Türkiye";
            fcs.YearlyPayment = 12342;
            lcs.PrintFullName();
            lcs.PrintMonthlyPayment();


            Console.ReadKey();
        }
    }
}
