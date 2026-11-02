using ReShareBlazorApp.Data;

namespace ReShareBlazorApp.Interfaces.Services;

public interface IReShareService
{
    Task<List<ReShare>> GetAllAsync();
    Task<ReShare?> GetByIdAsync(int id);
    Task CreateAsync(ReShare reShare);
    Task UpdateAsync(ReShare reShare);
    Task DeleteAsync(int id);
}