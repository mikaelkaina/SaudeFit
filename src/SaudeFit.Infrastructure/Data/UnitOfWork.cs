using SaudeFit.Domain.Interfaces;

namespace SaudeFit.Infrastructure.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context) 
        => _context = context;
    public async Task SaveChangesAsync(CancellationToken cancellationToken) 
        => await _context.SaveChangesAsync(cancellationToken);
}