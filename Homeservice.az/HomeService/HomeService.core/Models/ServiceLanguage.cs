using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class ServiceLanguage
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int LanguageId { get; set; }
        public Service Service { get; set; }
        public Language Language { get; set; }
    }
}
