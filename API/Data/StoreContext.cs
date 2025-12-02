using System;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions<StoreContext> options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Basket> Baskets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole
                    { Id = "d458dbca-f47e-43e6-9123-2f4813f1c570", Name = "Member", NormalizedName = "MEMBER" },
                new IdentityRole
                    { Id = "9a5e88d4-3033-422f-b4f9-491a8aebd60c", Name = "Admin", NormalizedName = "ADMIN" }
            );
    }
}