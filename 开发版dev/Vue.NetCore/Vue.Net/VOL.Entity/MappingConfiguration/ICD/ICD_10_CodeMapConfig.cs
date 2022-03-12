using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class ICD_10_CodeMapConfig : EntityMappingConfiguration<ICD_10_Code>
    {
        public override void Map(EntityTypeBuilder<ICD_10_Code>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

