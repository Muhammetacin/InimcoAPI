using Inimco.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Inimco.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<SocialSkill> SocialSkills { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }
    }
}
