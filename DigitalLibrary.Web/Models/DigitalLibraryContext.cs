using Microsoft.EntityFrameworkCore;

namespace DigitalLibrary.Web.Models
{
    public class DigitalLibraryContext : DbContext
    {
        public DigitalLibraryContext() : base()
        {

        }

        public DigitalLibraryContext(DbContextOptions<DigitalLibraryContext> options) : base(options)
        {

        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<AudioBook> AudioBooks { get; set; }
        public virtual DbSet<DigitalBook> DigitalBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<AudioBook>().ToTable("AudioBook");
            
        }
    }
}
