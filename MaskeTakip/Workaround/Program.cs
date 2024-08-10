using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Semih");
            SelamVer(isim: "Ekrem");
            SelamVer(isim: "Kerem");
            SelamVer();

            int sonuc = Topla(6, 58);

            string ogrenci1 = "Semih";
            string ogrenci2 = "Ekrem";
            string ogrenci3 = "Kerem";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Semih";
            ogrenciler[1] = "Ekrem";
            ogrenciler[2] = "Kerem";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Semih";
            person1.LastName = "YILDIZ";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 123;

            Vatandas person2 = new Vatandas();
            person2.Ad = "Sude";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc.ToString());
            return sonuc;
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
        public long NationalIdentity { get; set; }
    }

    public interface IApplicantService
    {
        bool CheckPerson(Person person);
    }

    public class ForeignerManager : IApplicantService
    {
        public bool CheckPerson(Person person)
        {
            // Implement your logic here
            return true;
        }
    }

    public class PttManager
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
        }
    }
}

