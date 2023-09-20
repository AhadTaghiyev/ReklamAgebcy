using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.ServiceDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(ServicePostDto postDto)
        {


            Service service = new Service
            {
                Icon = postDto.Icon,
                ServiceLanguages = new List<ServiceLanguage>()
            };
            await _unitOfWork.ServiceRepository.AddAsync(service);

            for (int i = 0; i < postDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = postDto.Texts[i],
                    Key = postDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                ServiceLanguage serviceLanguage = new ServiceLanguage
                {
                    Language = language,
                    Service = service
                };
                service.ServiceLanguages.Add(serviceLanguage);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<ServicegetDto> Get(int id)
        {
            Service service = await _unitOfWork.ServiceRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "ServiceLanguages.Language");

            if (service == null)
                throw new ItemNotFoundExeption("Item is not found");

            ServicegetDto serviceget = new ServicegetDto
            {
                Icon = service.Icon,
                Id = service.Id,
                TitleAz = service.ServiceLanguages.FirstOrDefault(x =>x.ServiceId == id && x.Language.Key == "TitleAz").Language.Text,
                TitleEn = service.ServiceLanguages.FirstOrDefault(x => x.ServiceId == id && x.Language.Key == "TitleEn").Language.Text,
                TitleRu = service.ServiceLanguages.FirstOrDefault(x => x.ServiceId == id && x.Language.Key == "TitleRu").Language.Text,
                DescriptionAz = service.ServiceLanguages.FirstOrDefault(x => x.ServiceId == id && x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionEn = service.ServiceLanguages.FirstOrDefault(x => x.ServiceId == id && x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionRu = service.ServiceLanguages.FirstOrDefault(x => x.ServiceId == id && x.Language.Key == "DescriptionRu").Language.Text,
            };
            return serviceget;
        }

        public async Task<GetAll<ServicegetDto>> GetAll()
        {
            var query =  _unitOfWork.ServiceRepository.GetAll(x => !x.IsDeleted, "ServiceLanguages");

            GetAll<ServicegetDto> GetDto = new GetAll<ServicegetDto>();
            

            GetDto.Items = query.Select(x => new ServicegetDto()
            {
                Icon = x.Icon,
                Id = x.Id,
                TitleAz = x.ServiceLanguages.FirstOrDefault(x => x.Language.Key == "TitleAz").Language.Text,
                TitleEn = x.ServiceLanguages.FirstOrDefault(x => x.Language.Key == "TitleEn").Language.Text,
                TitleRu = x.ServiceLanguages.FirstOrDefault(x => x.Language.Key == "TitleRu").Language.Text,
                DescriptionAz = x.ServiceLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionEn = x.ServiceLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionRu = x.ServiceLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionRu").Language.Text,

            }).ToList();
            return GetDto;
        }

        public async Task RemoveAync(int id)
        {
            Service service = await _unitOfWork.ServiceRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "ServiceLanguages.Language");

            if (service == null)
                throw new ItemNotFoundExeption("Item is not found");

            service.IsDeleted = true;
            await _unitOfWork.CommitAsync();

        }

        public async Task Update(int id, ServicePostDto servicePostDto)
        {
            Service service = await _unitOfWork.ServiceRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "ServiceLanguages.Language");

            if (service == null)
                throw new ItemNotFoundExeption("Item is not found");

            List<ServiceLanguage> RemovableLanguages = service.ServiceLanguages.Where(x => x.ServiceId == id).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (ServiceLanguage ServiceLanguage in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(ServiceLanguage.Language);
                }



            for (int i = 0; i < servicePostDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = servicePostDto.Texts[i],
                    Key = servicePostDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                ServiceLanguage serviceLanguage = new ServiceLanguage
                {
                    Language = language,
                    Service = service
                };
                service.ServiceLanguages.Add(serviceLanguage);
            }
            service.Icon = servicePostDto.Icon;

            await _unitOfWork.CommitAsync();
        }

  
    }
}
