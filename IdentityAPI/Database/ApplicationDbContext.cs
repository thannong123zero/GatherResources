using IdentityAPI.Database.DTOs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityAPI.Database
{
    public class ApplicationDbContext : IdentityDbContext<MyUser,MyRole,int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
