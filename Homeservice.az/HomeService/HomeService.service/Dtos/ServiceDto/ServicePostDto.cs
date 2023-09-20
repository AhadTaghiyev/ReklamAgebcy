using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.ServiceDto
{
   public class ServicePostDto
    {
        public string Icon { get; set; }
        public List<string> Texts { get; set; }
        public List<string> Keys { get; set; }
    }
}
