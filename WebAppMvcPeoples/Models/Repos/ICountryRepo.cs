using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.Repos
{
    public interface ICountryRepo
    {
        Country Create(string countryname);
        List<Country> Read();
        Country Read(int Id);

        bool Update(Country country);
        bool Delete(Country country);
    }
}
