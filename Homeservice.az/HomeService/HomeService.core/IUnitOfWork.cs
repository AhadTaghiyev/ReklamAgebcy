using HomeService.core.Models;
using HomeService.core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.core
{
   public interface IUnitOfWork
    {
        ISettingRepository SettingRepository { get; }
        ILanguageRepository LanguageRepository { get; }
        IAdvantageRepository AdvantageRepository { get; }
        IServiceRepository ServiceRepository { get; }
        ICommentRepository CommentRepository { get; }
        ICostRespository CostRespository { get; }
        IQuestionRepository QuestionRepository { get; }
        IPositionRepository PositionRepository { get; }
        ITeamRepository TeamRepository { get; }
        IMessageRepository MessageRepository { get; }
        IBlogRepository BlogRepository { get; }
        ISeoDescriptionRepository SeoDescriptionRepository { get; }
        ISeoTagRepository SeoTagRepository { get; }
        ISeoKeyWordRepository SeoKeyWordRepository { get; }

        int Commit();

        Task<int> CommitAsync();
    }
}
