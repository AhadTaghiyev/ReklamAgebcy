using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.PositionDto
{
   public class PositionGetDto
    {
        public int Id { get; set; }
        public string PositionAz { get; set; }
        public string PositionEn { get; set; }
        public string PositionRu { get; set; }
    }
}
