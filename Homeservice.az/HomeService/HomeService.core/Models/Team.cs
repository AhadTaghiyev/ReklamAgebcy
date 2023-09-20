using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Team
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public bool IsDeleted { get; set; }

        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public int PositionId { get; set; }
        public Position  Position { get; set; }
       
    }
}
