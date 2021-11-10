using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.Repos
{// inherent
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        private List<Person> people = new List<Person>();
        private static int idCounter = 0;
        private static List<Person> peopleList;
        
        public Person Create(string name,string phonenumber,string city)
        {
            Person person = new Person(name,phonenumber, city);
            
            person.PersonId = ++idCounter;
            person.Name = name;
            person.PhoneNumber = phonenumber;
            person.City = city;
            peopleList.Add(person);
            return person;
        }
        public List<Person> Read()
        {
            return peopleList;
        }
        public Person ReadById(int id)
        {
            Person person = null;
            foreach (Person aPerson in peopleList)
            {
                if (aPerson.PersonId == id)
                {
                     person = aPerson;
                    break;
                }

            }return person;
        }
        public bool Update(Person person)// Put/ Push
        {
            Person orgPerson = ReadById(person.PersonId);
            if (orgPerson == null)
            {
                return false;
            }
            else
            {
                
                orgPerson.Name = person.Name;
                orgPerson.City = person.City;
                orgPerson.PhoneNumber = person.PhoneNumber;
                return true;
            }

        }
        public bool Delete(Person person)
        {
            
            return peopleList.Remove(person);
        }
        
    }//End of Class name
}//End of namespace
