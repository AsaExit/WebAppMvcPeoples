﻿using System;
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
        private readonly ILanguageRepo _languageRepo;
        public PeopleService(IPeopleRepo peopleRepo, ILanguageRepo languageRepo)
        {
            _peopleRepo = peopleRepo;
            _languageRepo = languageRepo;
        }
        public Person Add(CreatePersonViewModel createPerson)
        {

            if (string.IsNullOrWhiteSpace(createPerson.Name))

            {
                throw new ArgumentException("Name,Phonenuber or City, not be consist of backspace(s)/whitespace(s)");
            }
            Person person = new Person()
            {
                Name = createPerson.Name,
                PhoneNumber = createPerson.PhoneNumber,
                CityId = createPerson.CityId
            };
            _peopleRepo.Create(person);
            return person;
        }
        public List<Person> All()
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
            //return _peopleRepo.Read(id);
            Person foundPerson = _peopleRepo.GetById(id);

            return foundPerson;
        }
        public bool Edit(int id, CreatePersonViewModel editPerson)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            Person personToDelete = _peopleRepo.GetById(id);
            if (personToDelete != null)
            {
                _peopleRepo.Delete(personToDelete);
            }
        }

        public PersonLanguageViewModel PersonLanguage(Person person)
        {
            throw new NotImplementedException();
        }

        public void RemoveLanguage(Person person, int languageId)
        {
            PersonLanguage language = person.PersonLanguages.SingleOrDefault(persLang => persLang.LanguageId == languageId);
            person.PersonLanguages.Remove(language);
            _peopleRepo.Update(person);
        }

        public void AddLanguage(Person person, int languageId)
        {
            PersonLanguage language = new PersonLanguage()
            {
                LanguageId = languageId,
                PersonId = person.Id
            };

            person.PersonLanguages.Add(language);

            _peopleRepo.Update(person);
        }
    }
}

