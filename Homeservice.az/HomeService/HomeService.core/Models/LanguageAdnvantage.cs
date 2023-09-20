using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class LanguageAdnvantage
    {
        public int Id { get; set; }
        public int AdvantageId { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public Advantage Advantage { get; set; }
    }
}
