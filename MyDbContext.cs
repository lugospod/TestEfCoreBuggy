using Microsoft.EntityFrameworkCore;
using TestEfCoreBuggy.Model;

namespace TestEfCoreBuggy
{
    //public class MyDbContext : IDesignTimeDbContextFactory<MyDbContext>
    //{
    //    public NmContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<NmContext>();
    //        optionsBuilder.UseSqlite("Data Source=C:\\source\\NotificationManagement\\src\\NM.API.Client\\Resources\\nm.db");

    //        return new NmContext(optionsBuilder.Options);
    //    }
    //}

    public class MyDbContext : DbContext
    {
        public DbSet<MyEntity> MyEntitites { get; set; }
      
        public MyDbContext() {
            Database.EnsureCreated();
        }
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            // Database.Migrate();
            Database.EnsureCreated();
        }

        public static string ConnectionString= "Data Source=test.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
            base.OnConfiguring(optionsBuilder);
        }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var entity in builder.Model.GetEntityTypes())
            {
                RemoveCascadeDelete(entity);
            }

            builder.ApplyConfiguration(new MyTypeConfiguration());
        }

        /// <summary>
        /// Remove cascade delete.
        /// </summary>
        /// <param name="entity">Entity.</param>
        private static void RemoveCascadeDelete(Microsoft.EntityFrameworkCore.Metadata.IMutableEntityType entity)
        {
            // Remove cascade deletes
            foreach (var relationship in entity.GetForeignKeys())
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
