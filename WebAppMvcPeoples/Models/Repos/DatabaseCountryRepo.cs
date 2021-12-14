using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Data;

namespace WebAppMvcPeoples.Models.Repos
{
    public class DatabaseCountryRepo : ICountryRepo
    {
        readonly PeopleDbContext _countryListContext;
        public DatabaseCountryRepo(PeopleDbContext countryListContext)
        {
            _countryListContext = countryListContext;
        }
        public Country Create(string countryname)
        {
            Country newCountry = new Country(countryname);
            _countryListContext.Add(newCountry);
            _countryListContext.SaveChanges();
            return newCountry;
        }

        public List<Country> Read()
        {
            List<Country> countryList = _countryListContext.Countries.ToList();
            return countryList;
        }

        public Country Read(int Id)
        {
            return _countryListContext.Countries.Find(Id);
        }
        public bool Update(Country country)
        {
            _countryListContext.Countries.Update(country);
            int countryUp=_countryListContext.SaveChanges();

            if (countryUp > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Country country)
        {
            _countryListContext.Countries.Remove(country);
            int countryDel = _countryListContext.SaveChanges();

            if (countryDel > 0)
            {
                return true;
            }
            return false;
        }
    }
}
