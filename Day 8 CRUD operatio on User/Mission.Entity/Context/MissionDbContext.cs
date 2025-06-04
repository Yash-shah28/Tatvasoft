using Microsoft.EntityFrameworkCore;
using Mission.Entity.Entities;


namespace Mission.Entity.Context

{
    public class MissionDbContext(DbContextOptions<MissionDbContext> options) : DbContext(options)
    {
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "Yash",
                LastName = "Shah",
                EmailAddress = "yash@gmail.com",
                UserType = "admin",
                Password = "yash",
                PhoneNumber = "9876543210",
                CreatedDate = new DateTime(2019, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false
            });

            base.OnModelCreating(builder);
        }
    }
}
