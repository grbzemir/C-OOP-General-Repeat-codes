using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Yapıcı_metot_ve_kalıtım
{
    public class BaseClass

    {
        public BaseClass() 
        
        {
            Console.WriteLine("Baseclass constructor çağırıldı");

        }

        public BaseClass(string Message)
        {

            Console.WriteLine(Message);
        }

    }

    public class DerivedClass:BaseClass 
    
    {

        public DerivedClass():base("BaseClass Parametreli Constructor cagırıldı")
        
        { 

        Console.WriteLine("Derivedclass constructor çağırıldı");
 
         }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseClass baseClass = new BaseClass();

            Console.ReadKey();

        }
    }
}
