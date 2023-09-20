using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Setting
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string IntroImage { get; set; }
        public string AboutImage { get; set; }
        public string HomePhone { get; set; }
        public bool IsDeleted { get; set; }

        public string CellPhone { get; set; }
        public string Adress { get; set; }
        public List<Social> SocialLinks { get; set; }
        public List<LanguageSetting> LanguageSettings { get; set; }
    }
}
