using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.Repos;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
    public class PeopleService : IPeopleService
    {
        IPeopleRepo _peopleRepo;
        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }
        public Person Create(CreatePersonViewModel createPerson)
        {
            Person person = _peopleRepo.Create(createPerson.Name, createPerson.PhoneNumber, createPerson.City);

            return person;
        }
        public List<Person> GetAll()
        {
            return _peopleRepo.Read();
        }

        public List<Person> FindByCity(string city)
        {
            throw new NotImplementedException();
        }

        public Person FindById(int id)
        {
            //return _peopleRepo.Read(id);
            Person foundPerson = _peopleRepo.Read(id);

            return foundPerson;
        }
        public bool Edit(int id, CreatePersonViewModel editPerson)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            Person personToDelete = _peopleRepo.Read(id);
            bool success = _peopleRepo.Delete(personToDelete);

            return success;
        }
    }
}
