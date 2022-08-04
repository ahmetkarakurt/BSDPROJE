using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Mapping.IsTakip.Ozellikler
{
  public  class AltTeknikOzelliklSecenekMap: EntityTypeConfiguration<BSD_TBL_TOZELLIKSECENEK>
    {
        public AltTeknikOzelliklSecenekMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.TeknikOzellikAdi).HasMaxLength(100);
            this.Property(p => p.Durum).HasMaxLength(300);

             this.ToTable("BSD_TBL_TOZELLIKSECENEK");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.TeknikOzellikAdi).HasColumnName("TeknikOzellikAdi");
            this.Property(p => p.Durum).HasColumnName("Durum");
            this.Property(p => p.TeknikOzellikleriGrurubId).HasColumnName("TeknikOzellikleriGrurubId");
            this.Property(p => p.IsTakibiId).HasColumnName("IsTakibiId");


        }
    }
}
