using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using MernisServiceReference;

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

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Entities.Person person)
        {
            // Maske başvuru işlemi
        }

        public List<Entities.Person> GetList()
        {
            // Kişi listesi döndüren gerçek bir uygulama yazılmalı
            return new List<Entities.Person>();
        }

        public async Task<bool> CheckPersonAsync(Entities.Person person)
        {
            var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = await client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(
                    person.NationalIdentity,
                    person.FirstName,
                    person.LastName,
                    person.DateOfBirthYear
                )
            ));
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Entities.Person person);
        List<Entities.Person> GetList();
        Task<bool> CheckPersonAsync(Entities.Person person);
    }
}

namespace Application
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var applicantService = new Business.Concrete.PersonManager();
            var person = new Entities.Person
            {
                FirstName = "Semih",
                LastName = "YILDIZ",
                DateOfBirthYear = 2000,
                NationalIdentity = 1234567890
            };

            bool isValid = await applicantService.CheckPersonAsync(person);

            Console.WriteLine(isValid ? $"{person.FirstName} için maske verildi." : $"{person.FirstName} için maske VERİLEMEDİ.");
            Console.ReadLine();
        }
    }
}
