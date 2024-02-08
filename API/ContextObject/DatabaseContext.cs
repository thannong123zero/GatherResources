using API.DTO;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace API.ContextObject
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
