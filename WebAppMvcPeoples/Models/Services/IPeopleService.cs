using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
    public interface IPeopleService
    {
        Person Add(CreatePersonViewModel person);

        List<Person> GetAll();

        Person FindById(int id);
        Person Edit(Person person);
        bool Delete(Person person);

    }// End of interface

}// End of namespace
