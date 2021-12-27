using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.Repos
{// inherent
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        private static List<Person> peopleList = new List<Person>();
        private static int idCounter = 0;

        public Person Create(Person person)
        {
            person.PersonId = ++idCounter;
            peopleList.Add(person);

            return person;
        }

        public List<Person> GetAll()
        {
            return peopleList;
        }

        public Person GetById(int id)
        {
            
            foreach (Person person in peopleList)
            {
                if (person.PersonId == id)
                {
                    return  person;
                    
                }
            }
            return null;
        }

        public bool Update(Person person)
        {
            Person orgPerson = GetById(person.PersonId);
            if (orgPerson == null)
            {
                return false;
            }
            else
            {
                orgPerson.Name = person.Name;
                orgPerson.PhoneNumber = person.PhoneNumber;
                orgPerson.City = person.City;
                
                return true;
            }
        }
        public bool Delete(Person person)
        {
            return peopleList.Remove(person);
        }


    }//End of Class name
}//End of namespace
