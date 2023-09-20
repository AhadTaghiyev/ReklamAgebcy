using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.BlogDto
{
    public class BlogGetDto
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public string TitleAz { get; set; }
        public string TitleEn { get; set; }
        public string TitleRu { get; set; }
        public string DescriptionAz { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionRu { get; set; }
        public string ImageFile { get; set; }
    }
}

