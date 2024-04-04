using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerÖrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {//kullanıcının girdiği sayı dizinin içinde var mı varsa kaç tane var yoksa yoktur diye uyarın.

            int[] sayilar = { 10, 20, 10, 45, 80, 20, 40, 70, 40, 70, 50 };
            int adet = 0;
            int sayi;
            Console.WriteLine(  "lütfen bir sayi giriniz=");
             sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
                if (sayi == 0)
                {
                    Console.WriteLine("girmiş olduğunuz sayi dizede bulunmamaktadır");
                }
                else
                {
                    Console.WriteLine("girmiş olduğunuz sayi dizede bulundu ...");
                    Console.WriteLine("Adet=" + adet);
                }
            
                Console.ReadLine();

            //kullanıcıdan on tane int değer alan ve şunları yazan değer oluşturunuz
            //kaç adet tek çift eleman olduğu
            //çift değerlerin toplamı tek değerlerin toplamı
            //sonolarak kontrol yapsın çıft değerlerin toplamı tek değerlerin toplamını geçiyorsa < yazdırsın 

                

            


        }


















    }
    }

