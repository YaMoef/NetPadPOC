using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetpadPOC.Entities;

namespace NetpadPOC.EntityTypeConfiguration;

public class BookEntitytypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> entity)
    {
        entity.HasKey(e => e.Id);

        entity.HasOne(d => d.Author)
            .WithMany(p => p.Books)
            .HasForeignKey(d => d.RandomPrimaryKey)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TargetDetail_Concession");
    }
}