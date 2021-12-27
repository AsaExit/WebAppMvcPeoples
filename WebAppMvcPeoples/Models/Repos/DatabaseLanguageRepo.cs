using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Data;


namespace WebAppMvcPeoples.Models.Repos
{
    public class DatabaseLanguageRepo : ILanguageRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DatabaseLanguageRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }
        public Language Create(Language createLanguage)
        {
            throw new NotImplementedException();
        }


        public List<Language> GetAll()
        {
            throw new NotImplementedException();
        }

        public Language FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Language language)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Language language)
        {
            throw new NotImplementedException();
        }
    }
}
