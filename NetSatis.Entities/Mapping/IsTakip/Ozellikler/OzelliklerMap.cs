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
    public class OzelliklerMap : EntityTypeConfiguration<BSD_TBL_OZELLIKLER>
    {
        public OzelliklerMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.TeknikOzellikAdi).HasMaxLength(100);
            this.Property(p => p.TeknikOzellikAciklama).HasMaxLength(300);

            this.ToTable("BSD_TBL_OZELLIKLER");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.TeknikOzellikAdi).HasColumnName("TeknikOzellikAdi");
            this.Property(p => p.TeknikOzellikAciklama).HasColumnName("TeknikOzellikAciklama");



        }
    }
}
