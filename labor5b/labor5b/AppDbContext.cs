using Microsoft.EntityFrameworkCore;


namespace labor5b
{
    internal class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        DbSet<Algorithms> Algorithms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses_Authors>()
                .HasOne(c => c.Courses)
                .WithMany(a => a.Courses_Authors)
                .HasForeignKey(ci => ci.CourseId);

            modelBuilder.Entity<Courses_Authors>()
                .HasOne(c => c.Authors)
                .WithMany(a => a.Courses_Authors)
                .HasForeignKey(ai => ai.AuthorId);

            modelBuilder.Entity<Courses>()
                .HasOne(a => a.Algorithms)
                .WithMany(c => c.Courses);
        }
    }
}
