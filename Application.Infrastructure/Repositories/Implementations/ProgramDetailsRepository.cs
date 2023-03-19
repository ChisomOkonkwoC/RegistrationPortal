using Application.Domain.Entities;
using Application.Infastructure.Data;
using Application.Infrastructure.Repositories.Interfaces;

namespace Application.Infrastructure.Repositories.Implementations
{
    public class ProgramDetailsRepository : GenericRepository<ProgramDetail>, IProgramDetailsRepository
    {
        public ProgramDetailsRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<bool> CreateProgramDetail(ProgramDetail programDetail)
        {
            var result = await _dbContext.ProgramDetails.AddAsync(programDetail);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}