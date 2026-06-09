using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaudeFit.Domain.Entities;
using SaudeFit.Infrastructure.Identity;

namespace SaudeFit.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

    public DbSet<UserProfile> UserProfiles { get; set; } = null!;

    public DbSet<Exercicio> Exercicios { get; set; } = default!;

    public DbSet<Alimento> Alimentos { get; set; }
}

