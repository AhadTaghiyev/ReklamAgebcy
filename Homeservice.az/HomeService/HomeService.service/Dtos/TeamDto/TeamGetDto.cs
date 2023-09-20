using HomeService.service.Dtos.PositionDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.TeamDto
{
   public class TeamGetDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public int PositionId { get; set; }
        public GetAll<PositionGetDto> Positions { get; set; }
    }
}
