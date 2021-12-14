using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{
    public class Language
    {
        //public string languageName;
        public Language()
        {
                
        }

        public Language(string languageName)
        {
            LanguageName = languageName;
        }
        public int LanguageId
        {
            get; set;
        }
        public string LanguageName
        {
            get; set;
        }
    }
}
