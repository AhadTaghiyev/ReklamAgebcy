using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.AdvantageDto
{
   public class AdvantagePostDto
    {
        public string Icon { get; set; }
        public List<string> Texts { get; set; }
        public List<string> Keys { get; set; }
    }
    public class AdvantageValifator : AbstractValidator<AdvantagePostDto>
    {
        public AdvantageValifator()
        {
            RuleFor(x => x.Icon).NotEmpty();
            RuleFor(x => x).Custom((x, context) =>
            {
                if(x.Texts.Count>0)
                foreach (var item in x.Texts)
                {
                    if (item == null)
                        context.AddFailure("Texts", "Text Boş ola bilməz");
                }
            });
        }
    }
}
