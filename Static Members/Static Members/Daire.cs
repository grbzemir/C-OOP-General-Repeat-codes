using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members
{
    public class Daire
    
    {
        int _r;
        // tek bir adreste tutması için static kullandım
        public static float _PI = 3.14f;

        static Daire()

        {
            Daire._PI = 3.14f;
            Console.WriteLine("Static yapıcı metod cagırıldı");
        }

        public Daire(int r)

        { 
            
            this._r = r;
            Console.WriteLine("instance metot cagırıldı");
        }
         
        public float AlanHesapla()
            
        {

            return this._r*this._r * Daire._PI;
        }

        // not sınıf isimlerine adları üzerinden ulaşılır
         
        public static void deneme()

        {
            
        }

    }
}
