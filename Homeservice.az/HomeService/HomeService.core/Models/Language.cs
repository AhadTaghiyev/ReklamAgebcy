using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
  public  class Language
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Key { get; set; }
        public List<LanguageSetting> LanguageSettings { get; set; }
        public List<LanguageAdnvantage> LanguageAdnvantages { get; set; }
        public List<ServiceLanguage> ServiceLanguages { get; set; }
        public List<CommentLanguage> CommentLanguages { get; set; }
        public List<CostLanguage> CostLanguages { get; set; }
        public List<QuestionLanguage> QuestionLanguages { get; set; }
        public List<PositionLanguage> PositionLanguages { get; set; }
        public List<BlogLanguage> BlogLanguages { get; set; }

    }
}
