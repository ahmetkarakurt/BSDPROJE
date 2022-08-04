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
 public   class AltTeknikOzelliklerMap : EntityTypeConfiguration<BSD_TBL_ALTTEKNIKOZELLIKLER>
    {
        public AltTeknikOzelliklerMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AltOzellikAdi).HasMaxLength(100);
            this.Property(p => p.AltOzellikAciklamasi).HasMaxLength(300);

            this.ToTable("BSD_TBL_ALTTEKNIKOZELLIKLER");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.AltOzellikAdi).HasColumnName("AltOzellikAdi");
            this.Property(p => p.AltOzellikAciklamasi).HasColumnName("AltOzellikAciklamasi");
            this.Property(p => p.OzellikId).HasColumnName("OzellikId");



        }
    }
}
