using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class PersonLanguageViewModel
    {
        public List<Language> LanguageListView { get; set; }
        public Person Person { get; set; }
        public List<Language> AllLanguages { get; set; }
        public List<Language> SpeakesLanguage { get; set; }

        public IEnumerable<SelectListItem>LanguageSelectList { get; set; }
        public IEnumerable<String> LanguageSelectedContainerView { get; set; }
        public PersonLanguageViewModel() {
            AllLanguages = new List<Language>();
            SpeakesLanguage = new List<Language>();
        }
    }


}
