using Lipstick._Convergence.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lipstick._Convergence.DataAccess.EntityConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<ArticleDTO>
    {
        public void Configure(EntityTypeBuilder<ArticleDTO> builder)
        {
            builder.ToTable("Table_Articles");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.SubjectEN).IsRequired();
            builder.Property(s => s.SubjectVN).IsRequired();
            builder.Property(s => s.DescriptionEN).IsRequired(false);
            builder.Property(s => s.DescriptionVN).IsRequired(false);
            builder.Property(s => s.ContentEN).IsRequired();
            builder.Property(s => s.ContentVN).IsRequired();
            builder.Property(s => s.Avatar).IsRequired();
            //builder.HasOne(s => s.Topic).WithMany(g => g.Articles).HasForeignKey(s => s.TopicId).IsRequired();
        }
    }
}
