using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Infra.Mappings;

namespace Infra.Context
{
    public class ApiContext:DbContext
    {
        public ApiContext()
        {}

        public ApiContext(DbContextOptions<ApiContext>options) : base(options)
        {}

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Localization> Localization { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new LocalizationMap());
        }

    }
}