using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();

            //if(password == "abcd")
            //{
            //    Console.WriteLine("Hoşgeldiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı şifre girdiniz.");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.Write("Veriler Doğrulanamadı.");
            //}

            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number==5)
            //{
            //    Console.WriteLine("Sayı Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış.");
            //}

            //int exam1, exam2, exam3, average;
            //string result= "Hata";

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması: " + average + "\n");
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine("Sonuç: " + result);

            //string city;
            //Console.Write("Lütfen bir şehir ismi giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil.");
            //}

            //Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adınız Hatalı.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifrenizi Giriniz: ");
            //    string password = (Console.ReadLine());
            //    if (password != "1234")
            //    {
            //        Console.WriteLine("Şifreniz Hatalı.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sisteme Giriş Yaptınız. Hoşgeldiniz.");
            //    }
            //}




            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. Sayının 2. Sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen bir futbol takımı baş harfini giriniz (g/f/b/t): ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("Trabzonspor");
            //}
            //else
            //{
            //    Console.Write("Hatalı Giriş Yaptınız.");
            //}



            #endregion

            #region Örnek Proje Uygulaması


            //Console.WriteLine("****** C# Eğitim Kampı Restoran'a Hoşgeldiniz ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- İçecekler");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Lütfen detayını görmek istediğiniz menü öğesinin numarasını giriniz: ");
            //menuItem = Console.ReadLine();
            //Console.WriteLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("-------------Ana Yemekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kuru Fasulye - 20 TL");
            //    Console.WriteLine("2- Izgara Köfte - 25 TL");
            //    Console.WriteLine("3- Tavuk Sote - 30 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("Lütfen sipariş vermek istediğiniz menü öğesinin numarasını giriniz: ");
            //    string orderItem = Console.ReadLine();
            //    Console.WriteLine("Siparişiniz alınmıştır. Afiyet olsun.");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("-------------Çorbalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası - 10 TL");
            //    Console.WriteLine("2- Ezogelin Çorbası - 12 TL");
            //    Console.WriteLine("3- Tavuk Çorbası - 15 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------------");
            //    Console.WriteLine("Lütfen sipariş vermek istediğiniz menü öğesinin numarasını giriniz: ");
            //    string orderItem = Console.ReadLine();
            //    Console.WriteLine("Siparişiniz alınmıştır. Afiyet olsun.");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("-------------Tatlılar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Ayran - 5 TL");
            //    Console.WriteLine("2- Kola - 7 TL");
            //    Console.WriteLine("3- Fanta - 7 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------------");
            //    Console.WriteLine("Lütfen sipariş vermek istediğiniz menü öğesinin numarasını giriniz: ");
            //    string orderItem = Console.ReadLine();
            //    Console.WriteLine("Siparişiniz alınmıştır. Afiyet olsun.");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("-------------İçecekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Baklava - 20 TL");
            //    Console.WriteLine("2- Künefe - 25 TL");
            //    Console.WriteLine("3- Sütlaç - 15 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------------");
            //    Console.WriteLine("Lütfen sipariş vermek istediğiniz menü öğesinin numarasını giriniz: ");
            //    string orderItem = Console.ReadLine();
            //    Console.WriteLine("Siparişiniz alınmıştır. Afiyet olsun.");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay numarasını giriniz (1-12): ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak Ayındasınız."); break;
            //    case 2: Console.Write("Şubat Ayındasınız."); break;
            //    case 3: Console.Write("Mart Ayındasınız."); break;
            //    case 4: Console.Write("Nisan Ayındasınız."); break;
            //    case 5: Console.Write("Mayıs Ayındasınız."); break;
            //    case 6: Console.Write("Haziran Ayındasınız."); break;
            //    case 7: Console.Write("Temmuz Ayındasınız."); break;
            //    case 8: Console.Write("Ağustos Ayındasınız."); break;
            //    case 9: Console.Write("Eylül Ayındasınız."); break;
            //    case 10: Console.Write("Ekim Ayındasınız."); break;
            //    case 11: Console.Write("Kasım Ayındasınız."); break;
            //    case 12: Console.Write("Aralık Ayındasınız."); break;
            //    default: Console.Write("Hatalı Ay Numarası Girdiniz."); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi Uygulaması

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz (+, -, *, /): ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //        case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //        case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //        case '/':
            //        if (number2 != 0)
            //        {
            //            result = number1 / number2;
            //            Console.WriteLine("Sonuç: " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bir sayı sıfıra bölünemez.");
            //        }
            //        break;
            //        default:
            //        Console.WriteLine("Hatalı işlem simgesi girdiniz.");
            //        break;
            //}

            #endregion
            Console.Read();
        }
    }
}
