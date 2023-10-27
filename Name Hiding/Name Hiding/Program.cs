using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Hiding
{

    public class BaseClass

    {

        public int a;
        public void Islem()

        {

            Console.WriteLine("Temel sınıftaki a değişkeni = " + a);


        }
    }

    public class DerivedClass:BaseClass 
    
    {


        new public int a;
        public DerivedClass(int aTemelSınıf, int aTureyenSınıf)

        { 
            base.a=aTemelSınıf;
            a = aTureyenSınıf;
           
                
         }

        new public void Islem()

        {

            Console.WriteLine("Türetilmiş sınıftaki a değişkeni = " + a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)

        {

            DerivedClass dcs = new DerivedClass(1,11);
            //dcs.Islem();
            //((BaseClass)dcs).a = 1;
            //dcs.a = 2;
            ((BaseClass)dcs).Islem();
            dcs.Islem();

            Console.ReadLine();
        }
    }
}
