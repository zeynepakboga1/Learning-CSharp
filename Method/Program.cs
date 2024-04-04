using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {//methodlara giriş /parametresiz geriye değer döndürmeyen methot tanımlama 
            //parametreli methot oluşturma
            Toplama(5, 5);
            carpma(4, 6);
            KullaniciBilgileri(14777, "merve", "deniz");
            SelamVer();
            Islem(320,50);
            int Islem2 = Islem(90, 100);
            Console.WriteLine(  "işleminşzin sonucu=" + Islem2);
            Console.ReadLine();
            string isim = Doldur("merve", "deniz");
            Console.WriteLine(  isim);
            Console.ReadLine();
        }
        static void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("girilen değer" + (sayi1 + sayi2));
            Console.ReadLine();


        }

        static void carpma(int rakam, int rakam2)
        {
            Console.WriteLine("girilen sayıların çarpımı" + (rakam * rakam2));
            Console.ReadLine();
        }

        static void KullaniciBilgileri(int tc, string isim, string soyisim)
        {
            Console.WriteLine("kullanıcı bilgileriniz" + tc + isim + soyisim);
            Console.ReadLine();
        }

        static void SelamVer()
        {
            Console.WriteLine(  "merhaba:)");
            Console.ReadLine();
        }
        //parametre alan geriye değer döndüren methot tanımlama
        //return anshtar kelimesi
        //methot sonu.
        static int Islem(int say,int say1)
        {
            int sonuç = say + say1;
            Console.ReadLine();
            return sonuç;
           

        }
        static string Doldur(string ism1,string ism2)
        {

            return ism1 + " " + ism2;
        }
        //return bir methodun bitişidir ondan sonra yazılacak kodlar çalişmaz 
        //değerleri döndürür

       






    }    
}    
   
         

          

    
          

         
          
