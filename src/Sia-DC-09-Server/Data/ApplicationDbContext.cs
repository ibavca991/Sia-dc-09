// src/Sia-DC-09-Server/Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;

namespace Sia_DC_09_Server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    // Позже добавишь: DbSet<User>, DbSet<RefreshToken> и т.д.
}