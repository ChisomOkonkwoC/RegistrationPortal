using Application.Domain.Entities;
using Application.Infastructure.Data;
using Application.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Infrastructure.Repositories.Implementations
{
    public class PreviewRepository : GenericRepository<Preview>, IPreviewRepository
    {
        public PreviewRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Preview> GetARecordAsync(Guid id)
        {
            var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
    }
}