using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Skill
    {
        public int Id { get; set; }
        public string SkillTitle { get; set; }
        public bool IsDeleted { get; set; }

        public string SkillContent { get; set; }
        public int CostId { get; set; }
        
    }
}
