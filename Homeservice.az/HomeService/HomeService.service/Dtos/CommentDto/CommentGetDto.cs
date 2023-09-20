using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.CommentDto
{
    public class CommentGetDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string TextAz { get; set; }
        public string TextEn { get; set; }
        public string TextRu { get; set; }
    }
}
