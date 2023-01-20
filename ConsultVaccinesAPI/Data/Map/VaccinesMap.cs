using ConsultVaccinesAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsultVaccinesAPI.Data.Map
{
    public class VaccinesMap : IEntityTypeConfiguration<VaccinesModel>
    {
        public void Configure(EntityTypeBuilder<VaccinesModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.DateApplied).IsRequired();
        }
    }
}
