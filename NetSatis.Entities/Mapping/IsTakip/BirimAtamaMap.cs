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
   public class BirimAtamaMap: EntityTypeConfiguration<BSD_TBL_BIRIMATAMA>
    {
        public BirimAtamaMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         
  

            this.ToTable("BSD_TBL_BIRIMATAMA");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.AltBirimId).HasColumnName("AltBirimId");
            this.Property(p => p.KullaniciId).HasColumnName("KullaniciId");
            this.Property(p => p.BirimId).HasColumnName("BirimId");


            // Birim ** tabllosunun içindeki  **public virtual ICollection<BSD_TBL_ALTBIRIM> AltBirim ile
            //BSD_TBL_BIRIM tablosu içindeki birimID tablosunu eşledi çoklu

           //this.HasRequired(c => c.Birim).WithMany(c => c.BirimAtama).HasForeignKey(c => c.BirimId);
           //this.HasRequired(c => c.AltBirim).WithMany(c => c.BirimAtama).HasForeignKey(c => c.AltBirimId);



        }
    }
}
