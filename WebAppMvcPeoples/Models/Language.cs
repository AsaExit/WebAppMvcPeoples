﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{
    public class Language
    {
        public Language()
        {}
        public Language(string languageName)=> LanguageName = languageName;
        [Key]
        public int LanguageId { get; set;}
        public string LanguageName { get; set; }
        public List<PersonLanguage> PersonLanguages { get; set; } //Navigation Property
    }
}
