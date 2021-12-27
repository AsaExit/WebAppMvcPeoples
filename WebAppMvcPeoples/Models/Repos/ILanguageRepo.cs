using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Repos
{
    public interface ILanguageRepo
    {
        Language Create(Language language);
        List<Language> GetAll();
        Language FindById(int id);

        bool Update(Language language);
        bool Delete(Language language);
    }
}
