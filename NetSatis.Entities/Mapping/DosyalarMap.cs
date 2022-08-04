using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BSDPROJE.Entities.Tables;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class DosyalarMap : EntityTypeConfiguration<BSD_TBL_Dosyalar>
    {
        public DosyalarMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.DosyaAdi).HasMaxLength(200);
            this.Property(p => p.DosyaTipi).HasMaxLength(200);
            this.Property(p => p.Kod_1s).HasMaxLength(20);
            this.Property(p => p.Kod_1s).HasMaxLength(20);
          

            this.ToTable("BSD_TBL_Dosyalar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.DosyaAdi).HasColumnName("DosyaAdi");
            this.Property(p => p.DosyaTipi).HasColumnName("DosyaTipi");
            this.Property(p => p.Kod_1s).HasColumnName("Kod_1s");
            this.Property(p => p.Kod_2s).HasColumnName("Kod_2s");
            this.Property(p => p.Kod_3i).HasColumnName("Kod_3i");
            this.Property(p => p.Kod_4i).HasColumnName("Kod_4i");
            this.Property(p => p.DostaIcerik).HasColumnName("DostaIcerik");
          
        }
    }
}
