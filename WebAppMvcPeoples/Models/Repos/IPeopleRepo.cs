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
        Person Create(string FistName, string LastName, string City, string PhoneNumber); // set this to public later after removing interface:s public

        // R Read the people list
        List<Person> GetAll();// set this to public later after removing interface:s public

        Person GetById(int id);// set this to public later after removing interface:s public


        // U Update the people list
        Person Update(Person person);// set this to public later after removing interface:s public


        // D Delete a person from the list
        bool Delete(Person person);
    }//End of Interface
}//End of namespace
