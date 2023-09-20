using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.QuestionDto
{
   public class QuestionGetDto
    {
        public int Id { get; set; }
        public string QuestionAz { get; set; }
        public string QuestionEn { get; set; }
        public string QuestionRU { get; set; }
        public string AnswerAz { get; set; }
        public string AnswerEn { get; set; }
        public string AnswerRu { get; set; }
    }
}
