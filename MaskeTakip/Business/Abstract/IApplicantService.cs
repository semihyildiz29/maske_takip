using System;
using System.Collections.Generic;

namespace Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
        public long NationalIdentity { get; set; }
    }
}

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Entities.Person person);
        List<Entities.Person> GetList();
        bool CheckPerson(Entities.Person person);
    }
}

namespace Business.Concrete
{
    public class PttManager
    {
        private Business.Abstract.IApplicantService _applicantService;

        public PttManager(Business.Abstract.IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Entities.Person person)
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

    public class ForeignerManager : Business.Abstract.IApplicantService
    {
        private List<Entities.Person> _persons = new List<Entities.Person>();

        public void ApplyForMask(Entities.Person person)
        {
            _persons.Add(person);
        }

        public List<Entities.Person> GetList()
        {
            return _persons;
        }

        public bool CheckPerson(Entities.Person person)
        {
            // Kişiyi kontrol etme mantığını buraya yazın
            return true;
        }
    }
}

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicantService = new Business.Concrete.ForeignerManager();
            var pttManager = new Business.Concrete.PttManager(applicantService);

            var person = new Entities.Person { FirstName = "Semih", LastName = "YILDIZ", DateOfBirthYear = 2000, NationalIdentity = 1234567890 };

            pttManager.GiveMask(person);

            Console.ReadLine();
        }
    }
}
