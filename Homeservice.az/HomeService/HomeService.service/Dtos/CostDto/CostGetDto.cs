using HomeService.core.Models;
using HomeService.service.Dtos.SkilDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.CostDto
{
    public class CostGetDto
    {
        public int Id { get; set; }
        public string TitleAz { get; set; }
        public string TitleEn { get; set; }
        public string TitleRu { get; set; }
        public string DescriptionAz { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionRu { get; set; }
        public List<Skill> Skills { get; set; }


    }
}
