using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
        public List<BlogLanguage> BlogLanguages { get; set; }
    }
}
