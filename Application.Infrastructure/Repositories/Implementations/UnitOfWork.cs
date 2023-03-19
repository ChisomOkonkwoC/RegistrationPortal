using Application.Infastructure.Data;
using Application.Infrastructure.Repositories.Interfaces;

namespace Application.Infrastructure.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        IProgramDetailsRepository _detailsRepository;
        IPreviewRepository _previewRepository;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IProgramDetailsRepository ProgramDetailsRepository => _detailsRepository ?? new ProgramDetailsRepository(_dbContext);
        public IPreviewRepository PreviewRepository => _previewRepository ?? new PreviewRepository(_dbContext);
    }
}