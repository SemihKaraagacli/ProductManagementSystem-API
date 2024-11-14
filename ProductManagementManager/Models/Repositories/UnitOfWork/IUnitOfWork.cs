namespace ProductManagementManager.Models.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}
