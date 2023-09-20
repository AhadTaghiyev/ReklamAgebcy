using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.MessageDto
{
    public class MessagePostDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
