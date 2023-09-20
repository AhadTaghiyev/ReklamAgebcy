using FluentValidation;
using HomeService.core.Models;
using HomeService.service.Extentions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos
{
    public class SettingPostDto
    {
        public IFormFile Logo { get; set; }

        public List<string> Languages { get; set; }
        public IFormFile IntroImage { get; set; }
        public IFormFile AboutImage { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Adress { get; set; }
        public List<string> SocialLinks { get; set; }
        public List<string> SocialIcons { get; set; }
        public List<string> LanguageText { get; set; }
        public List<string> LanguageTextKey { get; set; }

    }

    public class SettingPostValidator : AbstractValidator<SettingPostDto>
    {
        public SettingPostValidator()
        {
          
            RuleFor(x =>x).Custom((x, context) => {
                if (x.Logo != null)
                {
                    if (!x.Logo.IsImage())
                        context.AddFailure("Logo", "Zehmet olmasa image file daxil edin");

                    if (!x.Logo.IsSizeOk(2))
                        context.AddFailure("Logo", "Image olcusu maximum 2mb ola biler");
                }

                if (x.IntroImage != null)
                {
                    if (!x.IntroImage.IsImage())
                        context.AddFailure("IntroImage", "Zehmet olmasa image file daxil edin");

                    if (!x.IntroImage.IsSizeOk(2))
                        context.AddFailure("IntroImage", "Image olcusu maximum 2mb ola biler");
                }


                if (x.AboutImage != null)
                {
                    if (!x.AboutImage.IsImage())
                        context.AddFailure("AboutImage", "Zehmet olmasa image file daxil edin");

                    if (!x.AboutImage.IsSizeOk(2))
                        context.AddFailure("AboutImage", "Image olcusu maximum 2mb ola biler");
                }

            });
        }
    }
}
