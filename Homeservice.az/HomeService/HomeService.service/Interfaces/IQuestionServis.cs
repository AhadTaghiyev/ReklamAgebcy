using HomeService.service.Dtos;
using HomeService.service.Dtos.QuestionDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
   public interface IQuestionServis
    {

        Task CreateAsync(QuestionPostDto postDto);
        Task<QuestionGetDto> Get(int id);
        Task<GetAll<QuestionGetDto>> GetAll();
        Task RemoveAync(int id);
        Task Update(int id, QuestionPostDto questionPostDto);
    }
}
