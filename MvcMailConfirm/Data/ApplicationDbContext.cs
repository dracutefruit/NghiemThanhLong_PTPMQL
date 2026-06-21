using System.Data.Common;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcAjax.Models.Entities;

namespace MvcAjax.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     base.OnModelCreating(builder);
    //     builder.Entity<ApplicationUser>().ToTable("User");
    //     builder.Entity<ApplicationRoles>().ToTable("Roles");
    //     builder.Entity<ApplicationUserRoles>().ToTable("UserRoles");
    //     builder.Entity<ApplicationUserClaims>().ToTable("UserClaims");
    //     builder.Entity<ApplicationUserTokens>().ToTable("UserTokens");
    //     builder.Entity<ApplicationUserClaims>().ToTable("UserClaims");
    //     builder.Entity<ApplicationRolesUser>().ToTable("RolesUser");
    // }
}
