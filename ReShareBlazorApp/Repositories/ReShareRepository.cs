using Microsoft.EntityFrameworkCore;
using ReShareBlazorApp.Data;
using ReShareBlazorApp.Interfaces.Repositories;

namespace ReShareBlazorApp.Repositories;

public class ReShareRepository : IReShareRepository
{
    private readonly IDbContextFactory<AppDbContext> _factory;

    public ReShareRepository(IDbContextFactory<AppDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<ReShare>> GetAllAsync()
    {
        await using var db = await _factory.CreateDbContextAsync();
        return await db.ReShares.AsNoTracking().ToListAsync();
    }

    public async Task<ReShare?> GetByIdAsync(int id)
    {
        await using var db = await _factory.CreateDbContextAsync();
        return await db.ReShares.AsNoTracking().FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task AddAsync(ReShare reShare)
    {
        await using var db = await _factory.CreateDbContextAsync();
        db.ReShares.Add(reShare);
        await db.SaveChangesAsync();
    }

    public async Task UpdateAsync(ReShare reShare)
    {
        await using var db = await _factory.CreateDbContextAsync();
        db.ReShares.Update(reShare);
        await db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await using var db = await _factory.CreateDbContextAsync();
        var reShare = await db.ReShares.FindAsync(id);
        if (reShare is not null)
        {
            db.ReShares.Remove(reShare);
            await db.SaveChangesAsync();
        }
    }
}