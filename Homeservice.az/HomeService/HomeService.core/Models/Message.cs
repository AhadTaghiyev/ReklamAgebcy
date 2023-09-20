using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class Message
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public bool IsDeleted { get; set; }

        public string Content { get; set; }
    }
}
