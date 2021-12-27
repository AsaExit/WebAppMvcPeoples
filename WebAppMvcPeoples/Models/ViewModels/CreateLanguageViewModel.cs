using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CreateLanguageViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter a language, it is Required!")]
        [StringLength(80, MinimumLength = 1)]
        [Display(Name = "Language name")]
        public string LanguageName { get; set; }
    }
}
