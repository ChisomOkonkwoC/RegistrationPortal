namespace Application.Infrastructure.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IPreviewRepository PreviewRepository { get; }
        IProgramDetailsRepository ProgramDetailsRepository { get; }
    }
}