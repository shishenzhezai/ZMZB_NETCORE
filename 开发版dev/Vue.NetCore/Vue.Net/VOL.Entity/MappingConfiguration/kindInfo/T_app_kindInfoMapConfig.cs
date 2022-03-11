using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class T_app_kindInfoMapConfig : EntityMappingConfiguration<T_app_kindInfo>
    {
        public override void Map(EntityTypeBuilder<T_app_kindInfo>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

