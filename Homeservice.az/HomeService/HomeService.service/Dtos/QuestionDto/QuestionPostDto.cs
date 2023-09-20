using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.QuestionDto
{
   public class QuestionPostDto
    {
        public List<string> Text { get; set; }
        public List<string> Keys { get; set; }
    }
}
