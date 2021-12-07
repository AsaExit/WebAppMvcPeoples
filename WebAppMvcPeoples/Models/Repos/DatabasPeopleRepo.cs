﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models;
using WebAppMvcPeoples.Models.Repos;

namespace WebAppMvcPeoples.Data
{
    public class DatabasPeopleRepo : IPeopleRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DatabasPeopleRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }
        public Person Create(string name, string phonenumber, string city)
        {
            Person newPerson = new Person(name, phonenumber, city);

            _peopleDbContext.Add(newPerson);
            _peopleDbContext.SaveChanges();

            return newPerson;
        }


        public List<Person> Read()
        {
            //return _peopleDbContext.People.ToList();
            List<Person> pList = _peopleDbContext.People.ToList();

            return pList;
        }

        public Person Read(int id)
        {
            return _peopleDbContext.People.Find(id);
        }

        public bool Update(Person person)
        {

            _peopleDbContext.People.Update(person);
            _peopleDbContext.SaveChanges();
            return true;
        }
        public bool Delete(Person person)
        {
            _peopleDbContext.People.Remove(person);
            _peopleDbContext.SaveChanges();
            return true;
        }
    }
}
