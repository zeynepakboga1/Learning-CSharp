using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {//kulanıcı giriş sayfası uygulaması 
         //kullanıcı adı ve şifresini doğru girerse tebikler başarılı bir şekilde giriş yaptınız 
         //yanliş girerse hata uyarısı ve 3 hak tanınıyor kullanıcıya 

            int haksayisi = 3;
            while (true)
            {
                Console.WriteLine(  "kullanıcı adınızı  giriniz;");
                string kullanici_adi=Console.ReadLine();
                Console.WriteLine(  "şifrenizi giriniz");
                string  sifre =Console.ReadLine();
                if (kullanici_adi == "merve" && sifre == "12345")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız ");
                    Console.ReadLine();
                    break;
                  
                }
                
                else
                    Console.WriteLine("kullanıcı adınız veya şifreniz yanlış");
                if (haksayisi > 0)
                {
                    haksayisi -= 1;
                }
                 if(haksayisi==0)
                {
                    Console.WriteLine(  "ana sayfaya giriş yapamazsınız");
                    Console.ReadLine();
                    break;
                }

                Console.ReadLine();


            }

        }
    }
}
