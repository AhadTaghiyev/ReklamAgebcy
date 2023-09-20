using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Advantage
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public bool IsDeleted { get; set; }
        public List<LanguageAdnvantage> LanguageAdnvantage { get; set; }

    }
}
