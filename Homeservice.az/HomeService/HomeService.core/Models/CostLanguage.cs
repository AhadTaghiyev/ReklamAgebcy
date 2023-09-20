using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
    public class CostLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int CostId { get; set; }
        public Language Language { get; set; }
        public Cost Cost { get; set; }
    }
}
