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
        public Person Add(CreatePersonViewModel createPerson)
        {
            Person person = _peopleRepo.Create(createPerson.Name, createPerson.PhoneNumber, createPerson.City);
            if (string.IsNullOrWhiteSpace(createPerson.Name)
                || string.IsNullOrWhiteSpace(createPerson.PhoneNumber)
                || string.IsNullOrWhiteSpace(createPerson.City))
            {
                throw new ArgumentException("Name,Phonenuber or City, not be consist of backspace(s)/whitespace(s)");
            }

            return person;
        }
        public List<Person> All()
        {
            return _peopleRepo.Read();
        }

        public List<Person> Search(string search)
        {
            List<Person> searchPerson = _peopleRepo.Read();
            foreach (Person item in _peopleRepo.Read())
            {
                if (item.Name.Contains(search, StringComparison.OrdinalIgnoreCase)
                   || item.City.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                     searchPerson.Add(item);
                }
            }
            if (searchPerson.Count == 0)
            {
                throw new ArgumentException("Could not find what you where looking for");
            }
            return searchPerson;
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
