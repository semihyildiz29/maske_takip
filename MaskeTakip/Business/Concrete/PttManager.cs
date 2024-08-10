using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Business.Concrete
{
    // Eksik olan IApplicantService arayüzü
    public interface IApplicantService
    {
        bool CheckPerson(Person person);
    }

    // Eksik olan Person sınıfı
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
        public long NationalIdentity { get; set; }
    }

    public class PttManager
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi ");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERILEMEDI ");
            }
        }
    }

    // Örnek bir ForeignerManager sınıfı IApplicantService'i implemente eden
    public class ForeignerManager : IApplicantService
    {
        public bool CheckPerson(Person person)
        {
            // Kişiyi kontrol etme mantığını buraya yazın
            return true;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Test kodu
        var pttManager = new Business.Concrete.PttManager(new Business.Concrete.ForeignerManager());
        var person = new Business.Concrete.Person { FirstName = "Semih" };
        pttManager.GiveMask(person);

        Console.ReadLine();
    }
}

