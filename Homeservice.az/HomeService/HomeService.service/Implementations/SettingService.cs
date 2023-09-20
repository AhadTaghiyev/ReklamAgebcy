using AutoMapper;
using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.LanguageDto;
using HomeService.service.Exeptions;
using HomeService.service.Extentions;
using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
    public class SettingService : ISettingService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;

        public SettingService(IMapper mapper, IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _env = env;
        }

        public async Task<SettingGetDto> GetByIdAsync(int id)
        {
            Setting setting = await _unitOfWork.SettingRepository.GetAsync(x => x.Id == id, "SocialLinks", "LanguageSettings.Language");

            if (setting == null)
                throw new ItemNotFoundExeption("Item is not found");

            SettingGetDto getDto = _mapper.Map<SettingGetDto>(setting);
            getDto.IntroTitleAz = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "IntroTitleAz").Language.Text;
            getDto.IntroTitleEn = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "IntroTitleEn").Language.Text;
            getDto.IntroTitleRu = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "IntroTitleRu").Language.Text;
            getDto.IntroTextAz = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "IntroTextAz").Language.Text;
            getDto.IntroTextEn = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "IntroTextEn").Language.Text;
            getDto.IntroTextRU = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "IntroTextRu").Language.Text;
            getDto.AboutTextAz = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "AboutTextAz").Language.Text;
            getDto.AboutTextEn = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "AboutTextEn").Language.Text;
            getDto.AboutTextRU = setting.LanguageSettings.FirstOrDefault(x => x.Language.Key == "AboutTextRu").Language.Text;

            return getDto;
        }

        public async Task<SettingGetDto> GetSetting()
        {
            Setting setting = await _unitOfWork.SettingRepository.GetSetting("SocialLinks", "LanguageSettings.Language");
            SettingGetDto getDto = _mapper.Map<SettingGetDto>(setting);
            return getDto;

        }

        public async Task Update(int id, SettingPostDto settingPostDto)
        {
            Setting setting = await _unitOfWork.SettingRepository.GetAsync(x => x.Id == id, "SocialLinks", "LanguageSettings.Language");
            if (setting == null)
                throw new ItemNotFoundExeption("Item is not found");


            setting.Adress = settingPostDto.Adress;
            setting.CellPhone = settingPostDto.CellPhone;
            setting.HomePhone = settingPostDto.HomePhone;

            List<LanguageSetting> RemovableLanguages = setting.LanguageSettings.Where(x => x.SettingId == id ).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (LanguageSetting LanguageSetting in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(LanguageSetting.Language);
                }

            List<Social> RemovableSocials = setting.SocialLinks.ToList();

            setting.SocialLinks.RemoveAll(x => RemovableSocials.Any());
            for (int i = 0; i < settingPostDto.SocialIcons.Count; i++)
            {

                Social NewSocial = new Social
                {
                    SocialIcons = settingPostDto.SocialIcons[i],
                    SocialLinks = settingPostDto.SocialLinks[i],
                    SettingId = id
                };
                setting.SocialLinks.Add(NewSocial);

            }

            for (int i = 0; i < settingPostDto.LanguageTextKey.Count; i++)
            {
                Language language = new Language
                {
                    Text = settingPostDto.LanguageText[i],
                    Key = settingPostDto.LanguageTextKey[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);
                LanguageSetting languageSetting = new LanguageSetting
                {
                    Language = language,
                    SettingId = id
                };
                setting.LanguageSettings.Add(languageSetting);

            }

            if (settingPostDto.Logo != null)
            {
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/design", setting.Logo);
                setting.Logo = settingPostDto.Logo.SaveImage(_env.WebRootPath, "design");
            }

            if (settingPostDto.IntroImage != null)
            {
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images/hero", setting.IntroImage);
                setting.IntroImage = settingPostDto.IntroImage.SaveImage(_env.WebRootPath, "assets/images/hero");
            }

            if (settingPostDto.AboutImage != null)
            {
                Helpers.Helper.DeleteImg(_env.WebRootPath, "images/about", setting.AboutImage);
                setting.AboutImage = settingPostDto.AboutImage.SaveImage(_env.WebRootPath, "assets/images/about");
            }

            setting.Adress = settingPostDto.Adress;
            setting.HomePhone = settingPostDto.HomePhone;
            await _unitOfWork.CommitAsync();

        }
    }
}
