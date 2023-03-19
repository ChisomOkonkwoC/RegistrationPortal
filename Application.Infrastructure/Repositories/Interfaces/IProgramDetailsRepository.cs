using Application.Domain.Entities;

namespace Application.Infrastructure.Repositories.Interfaces
{
    public interface IProgramDetailsRepository
    {
        Task<bool> CreateProgramDetail(ProgramDetail programDetail);
    }
}