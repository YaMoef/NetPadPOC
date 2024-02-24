using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetpadPOC.Entities;

namespace NetpadPOC.EntityTypeConfiguration;

public class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> entity)
    {
        entity.HasKey(e => e.RandomPrimaryKey);
    }
}