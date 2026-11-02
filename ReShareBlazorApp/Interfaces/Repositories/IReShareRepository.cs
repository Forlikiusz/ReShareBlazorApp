using ReShareBlazorApp.Data;

namespace ReShareBlazorApp.Interfaces.Repositories;

public interface IReShareRepository
{
    Task<List<ReShare>> GetAllAsync();
    Task<ReShare?> GetByIdAsync(int id);
    Task AddAsync(ReShare reShare);
    Task UpdateAsync(ReShare reShare);
    Task DeleteAsync(int id);
}