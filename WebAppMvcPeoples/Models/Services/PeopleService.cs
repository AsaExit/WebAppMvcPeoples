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

        //ILanguageRepo _languageRepo;
        public PeopleService(IPeopleRepo peopleRepo) // _languageRepo = languageRepo
        {
            _peopleRepo = peopleRepo;

           // _languageRepo = languageRepo;
        }
        public Person Create(CreatePersonViewModel createPerson)
        {
            if (string.IsNullOrWhiteSpace(createPerson.Name))
            {
                throw new ArgumentException("Name may not consist of backspace(s)/whitespace(s)");
            }
            Person person = new Person()
            {
                Name = createPerson.Name,
                PhoneNumber = createPerson.PhoneNumber,
                CityId = createPerson.CityId
            };

            person = _peopleRepo.Create(person);

            return person;
        }
        public List<Person> GetAll()
        {
            return _peopleRepo.GetAll();
        }

        public List<Person> Search(string search)
        {
            List<Person> searchPerson = _peopleRepo.GetAll();
            //
            foreach (Person item in _peopleRepo.GetAll())
            {
                if (item.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    searchPerson.Add(item);
                }
            }
            //searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper()) || p.City.Contains(search.ToUpper())).ToList();
            if (searchPerson.Count == 0)
            {
                throw new ArgumentException("Could not find what you where looking for");
            }
            return searchPerson;
        }
        public Person FindById(int id)
        {
            return _peopleRepo.GetById(id);

        }
        public bool Edit(int id, CreatePersonViewModel editPerson)
        {
            Person person = FindById(id);
            if (person == null)
            {
                return false;
            }
            person.Name = editPerson.Name;
            person.PhoneNumber = editPerson.PhoneNumber;
            person.CityId = editPerson.CityId;
            return _peopleRepo.Update(person);
        }

        public bool Remove(int id)
        {
            Person personToDelete = _peopleRepo.GetById(id);
            bool success = _peopleRepo.Delete(personToDelete);

            return success;
        }


        public PersonLanguageViewModel PersonLanguage(Person person)
        {
            throw new NotImplementedException();
        }

        public void removeLanguage(Person person, int languageId)
        {
            throw new NotImplementedException();
        }

        public void AddLanguage(Person person, int languageId)
        {
            throw new NotImplementedException();
        }
    }
}
