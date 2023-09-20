using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.CostDto
{
   public class CostPostDto
    {
        public List<string> Texts { get; set; }
        public List<string> Keys { get; set; }
        public List<string> SkillTexts { get; set; }
        public List<string> SkillContents { get; set; }
       
    }
}
