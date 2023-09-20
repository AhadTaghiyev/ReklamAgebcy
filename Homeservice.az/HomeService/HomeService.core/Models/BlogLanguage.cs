using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class BlogLanguage
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int LanguageId { get; set; }
        public Blog Blog { get; set; }
        public Language Language { get; set; }
    }
}
