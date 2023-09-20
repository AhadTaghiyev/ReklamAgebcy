using HomeService.service.Dtos;
using HomeService.service.Dtos.AdvantageDto;
using HomeService.service.Dtos.BlogDto;
using HomeService.service.Dtos.CommentDto;
using HomeService.service.Dtos.CostDto;
using HomeService.service.Dtos.PositionDto;
using HomeService.service.Dtos.QuestionDto;
using HomeService.service.Dtos.ServiceDto;
using HomeService.service.Dtos.TeamDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class HomeVM
    {
        public GetAll<AdvantageGetDto> Advantages { get; set; }
        public GetAll<TeamGetDto> Teams { get; set; }
        public GetAll<ServicegetDto> Services { get; set; }
        public GetAll<QuestionGetDto> Questions { get; set; }
        public GetAll<PositionGetDto> Positions { get; set; }
        public GetAll<CostGetDto> Costs { get; set; }
        public GetAll<CommentGetDto> Comments { get; set; }
        public GetAll<BlogGetDto> Blogs { get; set; }
        public SettingGetDto settingGet { get; set; }

    }
}
