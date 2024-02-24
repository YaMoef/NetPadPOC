using Microsoft.EntityFrameworkCore;
using NetpadPOC.Entities;
using NetpadPOC.EntityTypeConfiguration;

namespace NetpadPOC.Contexts;

public class BookDbContext: DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options): base(options)
    {
        
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BookEntitytypeConfiguration());
    }
}