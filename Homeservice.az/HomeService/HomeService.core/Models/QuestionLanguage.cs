using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class QuestionLanguage
    {

        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int QuestionId { get; set; }
        public Language Language { get; set; }
        public Questions Question { get; set; }
    }
}
