using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class CommentLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int CommentId { get; set; }
        public Language Language { get; set; }
        public Comment Comment { get; set; }
    }
}
