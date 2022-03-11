using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class T_don_free_recordMapConfig : EntityMappingConfiguration<T_don_free_record>
    {
        public override void Map(EntityTypeBuilder<T_don_free_record>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

