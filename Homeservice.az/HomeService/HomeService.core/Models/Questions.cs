using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Questions
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public List<QuestionLanguage> QuestionLanguages { get; set; }
    }
}
