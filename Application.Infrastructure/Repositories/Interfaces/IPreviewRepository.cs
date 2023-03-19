using Application.Domain.Entities;

namespace Application.Infrastructure.Repositories.Interfaces
{
    public interface IPreviewRepository
    {
        Task<Preview> GetARecordAsync(Guid id);
    }
}