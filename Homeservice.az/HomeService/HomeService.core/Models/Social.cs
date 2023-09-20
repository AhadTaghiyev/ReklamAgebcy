using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Social
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string SocialLinks { get; set; }
        public string SocialIcons { get; set; }
        public int SettingId { get; set; }

    }
}
