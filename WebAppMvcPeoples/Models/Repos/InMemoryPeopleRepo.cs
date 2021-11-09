using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.Repos
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        static int idCounter = 0;
        static List<Person> peopleList;
        //static List<Person> people=new List<Person>();
        public Person Create(string FirstName, string LastName, string City, string PhoneNumber)
        {
            Person person = new Person();

            person.PersonId = ++idCounter;
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.City = City;
            person.PhoneNumber = PhoneNumber;
            peopleList.Add(person);
            return person;
        }
        public List<Person> GetAll()
        {
            return peopleList;
        }
        public Person GetById(int id)
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
        public Person Update(Person person)
        {
            person.PersonId = ++idCounter;
            peopleList.Add(person);
            return person;
        }
        public bool Delete(Person person)
        {
            peopleList.Remove(person);
            return true;
        }

    }//End of Class name
}//End of namespace
