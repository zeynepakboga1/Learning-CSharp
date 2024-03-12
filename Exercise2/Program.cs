using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*kullanıcıdan değer alma 
            string sayi = "isminizi giriniz";
            Console.WriteLine(  sayi);
            Console.ReadLine();*/
            //kullanıcıdan iki tane sayı alan ve ikisinin toplamını ekrana yzdıran programı yaz
            Console.WriteLine("lüten birinci sayiyi giriniz");
            string sayi1 = Console.ReadLine();
            Console.WriteLine("lüten ikinci sayiyi giriniz");
            string sayi2= Console.ReadLine();
            int sayiInt = Convert.ToInt32(sayi1);
            int sayiInt2 = Convert.ToInt32(sayi2);
            int sonuc = sayiInt + sayiInt2;
            Console.WriteLine("isleminizin sonucu=" + sonuc);
            
            Console.ReadLine();
            // öğrencinin notu elliden büyükse başarılı değilse değil  diyen kodu yazdirma
            Console.WriteLine(  "lütfen notunuzu giriniz =");
            string not = Console.ReadLine();
            int notInt = Convert.ToInt32(not);
            if (notInt > 50) 
            Console.WriteLine(  "başarılı");
            else
                Console.WriteLine(  "başarısız");
            Console.ReadLine();

            // kullanıcıdan 3 not alma bu üç sayının ortalamasını alıp harf notu oluşturma
            Console.WriteLine(  "ilk notunuzu giriniz");
            string not1 = Console.ReadLine();
            int not1Int = Convert.ToInt32(not1);
            Console.WriteLine(  "ikinci notunuzu giriniz ");
            string not2 = Console.ReadLine();
            int not2Int = Convert.ToInt32(not2);
            Console.WriteLine(  "üçüncü notunuzu giriniz");
            string not3 = Console.ReadLine();
            int not3Int = Convert.ToInt32(not3);
            int sonuc1 =( not1Int + not2Int + not3Int)/3;
            if (sonuc1 >= 80 && sonuc1 <= 100) 
             Console.WriteLine(  "A+ aldınız");
            else if(sonuc1>=60&& sonuc1<=79)
                Console.WriteLine(  "A aldınız");
            else if(sonuc1<=40&&sonuc1<=59)
                Console.WriteLine(  "B aldınız");
            else
                Console.WriteLine( "F aldınız");
            Console.ReadLine();
            




        }
    }
}
