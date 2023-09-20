using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
   public class PositionLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int PositionId { get; set; }
        public Language Language { get; set; }
        public Position Position { get; set; }
    }
}
