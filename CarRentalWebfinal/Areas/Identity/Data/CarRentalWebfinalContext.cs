using CarRentalWebfinal.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalWebfinal.Models;
using CarRentalWebfinal.Models;

namespace CarRentalWebfinal.Areas.Identity.Data;

public class CarRentalWebfinalContext : IdentityDbContext<CarRentalWebfinalUser>
{
    public CarRentalWebfinalContext(DbContextOptions<CarRentalWebfinalContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<CarRentalWebfinal.Models.Customer>? Customer { get; set; }

    public DbSet<CarRentalWebfinal.Models.Reservation>? Reservation { get; set; }

    public DbSet<CarRentalWebfinal.Models.Location>? Location { get; set; }

    public DbSet<CarRentalWebfinal.Models.Vehicle>? Vehicle { get; set; }  
}
