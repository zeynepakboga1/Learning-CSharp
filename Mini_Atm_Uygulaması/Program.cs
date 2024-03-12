using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Atm_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        { // Mini ATM uygulaması yapma
            //kullanıcıya nasıl bir işlem yapmak istediğini sor
            //1bakiye görüntüleme
            //3para yatırma
            //2para çekme
            //qya basarsa çıkış yaptır
            Console.WriteLine("ATM'ye hoşgeldiniz");
            Console.WriteLine("yapmak istediğiniz işlemi seçiniz:");
            string secim = Console.ReadLine();
            int bakiye = 500;
                       
            if (secim == "1")
            {
                
                Console.WriteLine("mevcut bakiyeniz="+ bakiye);
                Console.ReadLine();
            }


            else if (secim == "2")

            {
                Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar > bakiye)
                {
                    Console.WriteLine(  "bakiyenizden fazla para cekemezsiniz");
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("kalan tutar=" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();

                }
                
                
        }


            else if (secim == "3")

            {
                Console.WriteLine("yatırılacak tutarı giriniz");
                int yatirma = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("toplam bakiye="+( bakiye + yatirma));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("ATM'den cıkıs yapılıyor");
                Console.WriteLine("iyi günler dileriz");
            }
            else
            {
                Console.WriteLine("lütfen gecerli bir deger giriniz");
                Console.ReadLine();
            }
        }

           
            

            }


        }
    

