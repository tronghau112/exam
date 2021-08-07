using System.Threading.Tasks;
using Examination.Domain.AggregateModels.ExamResultAggregate;
using Examination.Infrastructure.SeedWork;
using MediatR;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Examination.Infrastructure.Repositories
{
    public class ExamResultRepository : BaseRepository<ExamResult>, IExamResultRepository
    {
        public ExamResultRepository(
            IMongoClient mongoClient,
            IClientSessionHandle clientSessionHandle,
            IOptions<ExamSettings> settings,
            IMediator mediator) : base(mongoClient, clientSessionHandle, Constants.Collections.ExamResult, settings, mediator)
        {
        }

        public async Task<ExamResult> GetDetails(string userId, string examId)
        {
            var filter = Builders<ExamResult>.Filter.Where(x => x.ExamId.Equals(examId) && x.UserId.Equals(userId));
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }
    }
}