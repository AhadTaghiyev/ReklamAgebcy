using AutoMapper;
using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.TeamDto;
using HomeService.service.Dtos.TeamRepository;
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
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public TeamService(IUnitOfWork unitOfWork,IMapper mapper,IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _env = env;
        }
        public async Task CreateAsync(TeamPostDto postDto)
        {
            Team team = _mapper.Map<Team>(postDto);

            if(postDto.FormFile!=null)
            team.Image = postDto.FormFile.SaveImage(_env.WebRootPath, "assets/images/team");

            await _unitOfWork.TeamRepository.AddAsync(team);
            await _unitOfWork.CommitAsync();

        }

        public async Task<TeamGetDto> Get(int id)
        {
            Team team = await _unitOfWork.TeamRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "Position");

            if (team == null)
                throw new ItemNotFoundExeption("Item is not found");

            TeamGetDto getDto = _mapper.Map<TeamGetDto>(team);
            return getDto;
        }

        public async Task<GetAll<TeamGetDto>> GetAll()
        {
            var query = _unitOfWork.TeamRepository.GetAll(x=>!x.IsDeleted,"Position");

            GetAll<TeamGetDto> getAll = new GetAll<TeamGetDto>();

            getAll.Items = query.Select(x => new TeamGetDto() { Id = x.Id, FullName = x.FullName, FacebookLink = x.FacebookLink, InstagramLink = x.InstagramLink ,TwitterLink=x.TwitterLink,PositionId=x.PositionId,Image=x.Image}).ToList();
            return getAll;
        }

        public async Task RemoveAync(int id)
        {
            Team team = await _unitOfWork.TeamRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "Position");
            if (team == null)
                throw new ItemNotFoundExeption("Item is not found");

              team.IsDeleted= true;

            await _unitOfWork.CommitAsync();
        }

        public async Task Update(int id, TeamPostDto postDto)
        {
            Team team = await _unitOfWork.TeamRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "Position");

            if (team == null)
                throw new ItemNotFoundExeption("Item is not found");

            team.InstagramLink=postDto.InstagramLink;
           team.FacebookLink=postDto.FacebookLink;
           team.TwitterLink=postDto.TwitterLink;
           team.FullName=postDto.FullName;
           team.PositionId=postDto.PositionId;
            if (postDto.FormFile != null)
            {
                if (team.Image != null)
                {
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images/team", team.Image);
                }

                team.Image = postDto.FormFile.SaveImage(_env.WebRootPath, "assets/images/team");
            }
            await _unitOfWork.CommitAsync();
        }
    }
}
