using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class LanguageSetting
    {
        public int Id { get; set; }
        public int SettingId { get; set; }
        public int LanguageId { get; set; }
        public Setting Setting { get; set; }
        public Language Language { get; set; }
    }
}
