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
  public  class AltBirimMap: EntityTypeConfiguration<BSD_TBL_ALTBIRIM>
    {
        public AltBirimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AltBirim).HasMaxLength(50);
            this.Property(p => p.AltBirimAciklama).HasMaxLength(100);
          

            this.ToTable("BSD_TBL_BIRIM");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.AltBirim).HasColumnName("AltBirim");
            this.Property(p => p.AltBirimAciklama).HasColumnName("AltBirimAciklama");

            // this.HasRequired(c => c.OdemeTuru).WithMany(c => c.KasaHareket).HasForeignKey(c => c.OdemeTuruId);

            //public virtual BSD_TBL_BIRIM Birim ** tabllosunun içindeki  **public virtual ICollection<BSD_TBL_ALTBIRIM> AltBirim ile
            //BSD_TBL_BIRIM tablosu içindeki birimID tablosunu eşledi çoklu
          //  this.HasRequired(c => c.Birim).WithMany(c => c.AltBirim).HasForeignKey(c => c.BirimId);

        }
    }
}
