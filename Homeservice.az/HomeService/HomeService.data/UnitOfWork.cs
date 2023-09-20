using HomeService.core;
using HomeService.core.Repositories;
using HomeService.data.Repositories;
using HomeService.data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.data
{
    public class UnitOfWork:IUnitOfWork
    {
        ISettingRepository _settingRepository;
        ILanguageRepository _languageRepository;
        IAdvantageRepository _advantageRepository;
        IServiceRepository _serviceRepository;
        ICommentRepository _commentRepository;
        ICostRespository _costRepository;
        IQuestionRepository _questionRepository;
        IPositionRepository _positionRepository;
        ITeamRepository _teamRepository;
        IMessageRepository _messageRepository;
        IBlogRepository _blogRepository;
        ISeoDescriptionRepository _seoDescriptionRepository;
        ISeoKeyWordRepository _seoKeyWordRepostory;
        ISeoTagRepository _seoTagRepository;

        private readonly HomeServiceDbContext _context;

        public ISettingRepository SettingRepository => _settingRepository ?? new SettingRepository(_context);
        public ILanguageRepository LanguageRepository => _languageRepository ?? new LanguageRepository(_context);

        public IAdvantageRepository AdvantageRepository => _advantageRepository ?? new AdvanTageRepository(_context);

        public IServiceRepository ServiceRepository => _serviceRepository ?? new ServiceRepository(_context);

        public ICommentRepository CommentRepository => _commentRepository ?? new CommentRepository(_context);

        public ICostRespository CostRespository => _costRepository ?? new CostRepository(_context);

        public IQuestionRepository QuestionRepository => _questionRepository??new QuestionRepository(_context);

        public IPositionRepository PositionRepository => _positionRepository??new PositionRepository(_context);

        public ITeamRepository TeamRepository => _teamRepository ?? new TeamRepository(_context);

        public IMessageRepository MessageRepository => _messageRepository ?? new MessageRepository(_context);

        public IBlogRepository BlogRepository => _blogRepository ?? new BlogRepository(_context);

        public ISeoDescriptionRepository SeoDescriptionRepository => _seoDescriptionRepository?? new SeoDescriptionRepository(_context);

        public ISeoTagRepository SeoTagRepository => _seoTagRepository?? new SeoTagRepository(_context);

        public ISeoKeyWordRepository SeoKeyWordRepository => _seoKeyWordRepostory??new SeoKeyWordRepository(_context);

        public UnitOfWork(HomeServiceDbContext context)
        {
            _context = context;
        }

        public int Commit()
        {
          return  _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
