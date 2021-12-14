using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.Repos;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepo _countryRepo;

        public CountryService(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }
        public Country Add(CreateCountryViewModel country)
        {
            Country makeCountry = _countryRepo.Create(country.CountryName);
            return makeCountry;
        }

        public CountryViewModel All()
        {
            CountryViewModel countryViewMod = new CountryViewModel() 
            { CountryListView = _countryRepo.Read() };
            return countryViewMod;
        }

        public CountryViewModel FindBy(CountryViewModel search)
        {
            search.CountryListView.Clear();
            //
            foreach (Country item in _countryRepo.Read())
            {
                if (item.CountryName.Contains(search.FilterString, StringComparison.OrdinalIgnoreCase))
                {
                    search.CountryListView.Add(item);
                }
            }
            //searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper()) || p.City.Contains(search.ToUpper())).ToList();
            if (search.CountryListView.Count == 0)
            {
                throw new ArgumentException("Could not find what you where looking for");
            }
            return search;
        }

        public Country FindById(int Id)
        {
            Country countryFound = _countryRepo.Read(Id);
            return countryFound;
        }
        public bool Edit(int Id, CreateCountryViewModel editCountry)
        {
            Country orginalCountry = FindById(Id);
            if (orginalCountry == null)
            {
                return false;
            }
            orginalCountry.CountryName = editCountry.CountryName;
            return _countryRepo.Update(orginalCountry);
        }

        public bool Remove(int Id)
        {
            Country countryToDelete = _countryRepo.Read(Id);
            bool succses = _countryRepo.Delete(countryToDelete);
            return succses;
        }

    }
}
