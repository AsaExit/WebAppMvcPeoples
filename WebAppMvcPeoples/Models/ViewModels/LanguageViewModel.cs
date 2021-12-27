using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class LanguageViewModel
    {
        public List<Language> LanguageListView { get; set; }
        public string FilterString { get; set; }
        public LanguageViewModel() =>LanguageListView = new List<Language>(); 
    }
}
