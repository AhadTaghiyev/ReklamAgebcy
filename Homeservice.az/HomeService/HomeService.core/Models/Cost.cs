using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Cost
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public List<Skill> Skills { get; set; }
        public List<CostLanguage> CostLanguages { get; set; }
    }
}
