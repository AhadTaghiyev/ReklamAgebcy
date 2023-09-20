using HomeService.service.Dtos;
using HomeService.service.Dtos.QuestionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class QuestionVM
    {
        public QuestionPostDto QuestionPostDto { get; set; }
        public QuestionGetDto QuestionGetDto { get; set; }
        public GetAll<QuestionGetDto> GetAll { get; set; }
    }
}
