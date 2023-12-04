using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.Concrete;

public class Context : IdentityDbContext<AppUser, AppRole, int>
{
    public DbSet<AppRole> AppRoles { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Logs> Logs { get; set; }





    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<AppRole>()
            .HasData(
                new AppRole { Id = 1, Name = "Member", NormalizedName = "MEMBER" },
                new AppRole { Id = 2, Name = "Admin", NormalizedName = "ADMIN" }

            );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        //  optionsBuilder.UseSqlServer("Server=test.com\\MSSQLSERVER2019;Database=text;User ID=test;Password=test++;TrustServerCertificate=True;");
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=SampleProject; Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}