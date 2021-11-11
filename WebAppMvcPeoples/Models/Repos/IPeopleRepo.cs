using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.Repos
{// Roles we vill follow CRUD
     public interface IPeopleRepo
    {
        // C Create
        //Person Create(Person person);
        public Person Add(string name, string phonenumber, string city); // set this to public later after removing interface:s public

        // R Read the people list
        public List<Person> Read();// set this to public later after removing interface:s public

        public Person Read(int id);// set this to public later after removing interface:s public


        // U Update the people list
        public bool Update(Person person);// set this to public later after removing interface:s public


        // D Delete a person from the list
        public bool Delete(Person person);
    }//End of Interface
}//End of namespace
