using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.86;
            //orangePrice = 20.65;
            //strawberryPrice = 4.89;
            //potatoPrice = 8.50;
            //tomatoPrice = 10.25;

            //Console.WriteLine("----Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("----Çilek Birim Fiyatı: "+ strawberryPrice);
            //Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice);
            //Console.WriteLine("----Domates Birim Fiyat: " + tomatoPrice);

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.250;
            //orangeGram = 1.500;
            //strawberryGram = 1.650;
            //potatoGram = 4.859;
            //tomatoGram = 6.158;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice+ " - Gramaj: "
            //    + appleGram + " - Toplam Fiyat: "+  appleTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: "
            //    + orangeGram + " - Toplam Fiyat: " + orangeTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: "
            //    + strawberryGram + " - Toplam Fiyat: " + strawberryTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: "
            //    + potatoGram + " - Toplam Fiyat: " + potatoTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: "
            //    + tomatoGram + " - Toplam Fiyat: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ücret: " + shoppingTotalPrice + " TL");



            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerPhone, passengerEmail, fromCity, toCity;

            //Console.Write("Lütfen adınızı giriniz: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Lütfen soyadınızı giriniz: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Lütfen telefon numaranızı giriniz: ");
            //passengerPhone = Console.ReadLine();

            //Console.Write("Lütfen e-posta adresinizi giriniz: ");
            //passengerEmail = Console.ReadLine();

            //Console.Write("Lütfen kalkış şehrinizi giriniz: ");
            //fromCity = Console.ReadLine();

            //Console.Write("Lütfen varış şehrinizi giriniz: ");
            //toCity = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("**** Yolcu Bilgileri ****");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone);
            //Console.WriteLine("E-Posta: " + passengerEmail);
            //Console.WriteLine("Güzergah: " + fromCity + " ---> " + toCity);
            //Console.WriteLine("Uçuşunuz başarıyla oluşturulmuştur. İyi yolculuklar dileriz.");
            //Console.WriteLine();


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 7500;
            //computerPrice = 20000;
            //chairPrice = 3500;
            //tvPrice = 15000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı adedini giriniz: ");
            //shoeCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar adedini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye adedini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon adedini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) +
            //    (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
            //Console.WriteLine();

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + result);


            #endregion

            #region Klavyeden Tek Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyetinizi giriniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
