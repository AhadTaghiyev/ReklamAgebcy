using FluentValidation;
using HomeService.service.Extentions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos.TeamRepository
{
    public class TeamPostDto
    {
        public IFormFile FormFile { get; set; }
        public string FullName { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public int PositionId { get; set; }
      
    }

    public  class TeamPostValidator : AbstractValidator<TeamPostDto>
    {
        public TeamPostValidator()
        {
            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.FormFile != null)
                {
                    if (!x.FormFile.IsImage())
                        context.AddFailure("ImageFile", "Şəkil filesi daxil edin");

                    if (!x.FormFile.IsSizeOk(2))
                        context.AddFailure("ImageFile", "Şəkil olcusu maksimum 2 mb ola biler");
                }

            });
        }
    }
}
