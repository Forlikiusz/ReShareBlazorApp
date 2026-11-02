using ReShareBlazorApp.Data;
using ReShareBlazorApp.Interfaces.Repositories;
using ReShareBlazorApp.Interfaces.Services;

namespace ReShareBlazorApp.Services;

public class ReShareService : IReShareService
{
    private readonly IReShareRepository _repository;

    public ReShareService(IReShareRepository repository)
    {
        _repository = repository;
    }

    public Task<List<ReShare>> GetAllAsync() => _repository.GetAllAsync();
    public Task<ReShare?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
    public Task CreateAsync(ReShare reShare) => _repository.AddAsync(reShare);
    public Task UpdateAsync(ReShare reShare) => _repository.UpdateAsync(reShare);
    public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
}