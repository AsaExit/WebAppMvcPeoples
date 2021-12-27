﻿using Microsoft.EntityFrameworkCore;
using System;
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
        public Person Create(Person person)
        {
            _peopleDbContext.People.Add(person);
            _peopleDbContext.SaveChanges();

            return person;
        }


        public List<Person> GetAll()
        {
            return _peopleDbContext.People.Include(person=> person.City).ThenInclude(person=> person.Country).Include(person => person.PersonLanguages).ToList();

        }

        public Person GetById(int id)
        {
            return _peopleDbContext.People.Include(person => person.City).ThenInclude(person => person.Country).Include(person => person.PersonLanguages).SingleOrDefault(person => person.PersonId == id);
        }
        
           
        

        public bool Update(Person person)
        {

            _peopleDbContext.People.Update(person);
           int result= _peopleDbContext.SaveChanges();
            if (result > 0)
            {
                return true;

            }
            return false;
        }
        public bool Delete(Person person)
        {
            _peopleDbContext.People.Remove(person);
           int result= _peopleDbContext.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
