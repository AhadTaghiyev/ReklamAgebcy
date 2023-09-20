using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Position
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public List<PositionLanguage> PositionLanguages { get; set; }
        public List<Team> Teams { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}
