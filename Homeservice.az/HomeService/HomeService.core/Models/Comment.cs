using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Comment
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool IsDeleted { get; set; }

        public List<CommentLanguage> CommentLanguages { get; set; }
    }
}
