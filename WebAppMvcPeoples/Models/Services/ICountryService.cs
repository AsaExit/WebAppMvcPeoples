using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
    public interface ICountryService
    {
        Country Add(CreateCountryViewModel Country);

        CountryViewModel All();

        CountryViewModel FindBy(CountryViewModel search);

        Country FindById(int Id);

        bool Edit(int Id, CreateCountryViewModel Country);

        bool Remove(int Id);

    }
}
