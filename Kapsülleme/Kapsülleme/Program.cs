using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
     
    public class Ogrenci

    {
        private int _id;
        private string _Name;
        private static int _Devamsizlik = 20;
        
        public void SetId(int Id)

        {

            if(Id<=0)

            {
                Console.WriteLine("Id 0 veya 0 dan küçük olamaz");
            }

            else

            {
                this._id = Id;
            }


        }
        
        public int GetId()

        { 

            return this.GetId();
        
        }

        public void SetName(string Name) 
        
        { 
           
            if(string.IsNullOrEmpty(Name)) 
            
            {

                Console.WriteLine("isim null veya boş olamaz");
            }

            else
            {
                 this._Name = Name;
            }

        }

        public string GetName() 
        
        
        {

            if(string.IsNullOrEmpty(this._Name)) 
            
            {

                return "isim girilmemiş";
            
            }

            else 
            
            { return this._Name; 
            
            }
        
        
        }

        public int GetDevamizlik() 
        
        {

            return Ogrenci._Devamsizlik;
        
        }

       
    }



    //Bazı işlemleri birleştirerek bir araya getirmek
    public class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci();
            
            ogrenci.SetId(1);
            ogrenci.SetName("Emir");
            Console.WriteLine(ogrenci.GetDevamizlik());

            Console.WriteLine("ID = {0} / İsmi = {1} Aşılması gereken devamsızlık süresi {2} gündür ", ogrenci.GetId(), ogrenci.GetName(), ogrenci.GetDevamizlik());
            Console.ReadKey();

        }
    }
}
