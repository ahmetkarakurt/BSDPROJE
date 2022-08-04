using BSDPROJE.Entities.Tables.isTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Mapping.IsTakip
{
    public class BirimMap : EntityTypeConfiguration<BSD_TBL_BIRIM>
    {
        public BirimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Birim).HasMaxLength(50);
            this.Property(p => p.BirimAciklama).HasMaxLength(100);

            this.ToTable("BSD_TBL_BIRIM");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Birim).HasColumnName("Birim");
            this.Property(p => p.BirimAciklama).HasColumnName("BirimAciklama");
          
        }
    }
}
