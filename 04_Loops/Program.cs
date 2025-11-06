using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z: artış ya da azalış

            //int i;

            //for (i=1;i<=5;i++) //i 1den başlasın, i<=5 olana kadar i bir bir artsın
            //{
            //    Console.WriteLine("C# eğitimi");
            //}

            //for (int i = 1; i <= 20; i++)  //1DEN 20YE KADAR OLAN SAYILARI YAZDIRDIK
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3) //3den 50ye kadar 3er artan sayılar
            //{
            //    Console.WriteLine(i);
            //}

            //başlangıç ve bitiş değerleri kullanıcıdan alınabilir
            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++) 
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++) //5e tam bölünen sayılar
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++) //1den 10a kadar sayıları topla
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i); //2ye tam bölünen sayıları gösterir
            //    }
            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine(totalValue); //2ye tam bölünen sayıların toplamını


            //1-50 arasında 7ye tam bölünen kaç sayı var?
            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}   
            //Console.WriteLine(count);

            //bir bakteri türü her saatin sonunda kendini 2ye bölerek çoğaltmaktadır..
            //yeni oluşan bakteriler de her saatin sonunda 2ye bölünerek çoğalmaktadır..
            //24 saatin sonunda bu ortamda kaç tane bakteri bulunur?
            //int bacterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bacterium *=2;
            //    Console.WriteLine(i + ". Saat sonunda : " + bacterium);
            //}
            #endregion

            #region While Döngüsü 
            //While döngüsü şart sağlandığı müddetçe anlam taşımaktadır. Arttırma işlemi işlemlerin olduğu yerde yapılır.
            //SYNTAX: 
            // While(Şart) {
            // işlemler {

            //int i = 1;

            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Örnek
            //Klavyeden girilen 3 basamaklı sayılının basamakları toplamını hesaplayan kodu yazınız.

            //Console.WriteLine("3 basamaklı sayı giriniz : ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
