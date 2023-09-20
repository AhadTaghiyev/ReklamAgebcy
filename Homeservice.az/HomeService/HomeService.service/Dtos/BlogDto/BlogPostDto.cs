using FluentValidation;
using HomeService.service.Extentions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.BlogDto
{
    public class BlogPostDto
    {
        public int PositionId { get; set; }
        public List<string> Texts { get; set; }
        public List<string> Keys { get; set; }
        public IFormFile ImageFile { get; set; }
    }

    public class BlogPostValidator : AbstractValidator<BlogPostDto>
    {
        public BlogPostValidator()
        {
            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.ImageFile!=null)
                {
                    if (!x.ImageFile.IsImage())
                        context.AddFailure("ImageFile", "Image File Teleb olunur");

                    if (!x.ImageFile.IsSizeOk(2))
                        context.AddFailure("ImageFile", "Maxsimum olcusu 2 mb ola biler");
                }
            });
        }
    }
}
