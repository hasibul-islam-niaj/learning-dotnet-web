using learning_dotnet_web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace learning_dotnet_web.Data;

public class LearningContext:DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<User>? Users { get; set; }

    public LearningContext(DbContextOptions options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DatabaseConfigs"));
    }
}