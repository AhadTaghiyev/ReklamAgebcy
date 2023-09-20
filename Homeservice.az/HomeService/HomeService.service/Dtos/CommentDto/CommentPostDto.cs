using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.CommentDto
{
   public class CommentPostDto
    {
        public string FullName { get; set; }
        public List<string> Texts { get; set; }
        public List<string> Keys { get; set; }
    }
}
