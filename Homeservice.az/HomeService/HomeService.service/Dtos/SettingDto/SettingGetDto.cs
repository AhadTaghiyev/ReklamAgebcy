using HomeService.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos
{
   public class SettingGetDto
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string IntroTitleAz { get; set; }
        public string IntroTitleEn { get; set; }
        public string IntroTitleRu { get; set; }
        public string IntroTextAz { get; set; }
        public string IntroTextEn { get; set; }
        public string IntroTextRU { get; set; }
        public string IntroImage { get; set; }
        public string AboutTextAz { get; set; }
        public string AboutTextEn { get; set; }
        public string AboutTextRU { get; set; }
        public string AboutImage { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Adress { get; set; }
        public List<Social> SocialLinks { get; set; }

    }
}
