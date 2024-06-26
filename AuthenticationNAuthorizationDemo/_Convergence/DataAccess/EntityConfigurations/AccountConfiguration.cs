using AuthenticationNAuthorizationDemo._Convergence.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthenticationNAuthorizationDemo._Convergence.DataAccess.EntityConfigurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<AccountDTO>
    {
        public void Configure(EntityTypeBuilder<AccountDTO> builder)
        {
            builder.ToTable("Table_Account");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
        }
    }
}
