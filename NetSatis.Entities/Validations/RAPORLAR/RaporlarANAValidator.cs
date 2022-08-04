using BSDPROJE.Entities.Tables.RAPORLAR;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Validations.RAPORLAR
{
    public class RaporlarANAValidator : AbstractValidator<BSD_TBL_RAPORLAR_ANA>
    {
        public RaporlarANAValidator()
        {
            RuleFor(p => p.KategoriAdi).NotEmpty().WithMessage("Meni Adı Boş Geçilemez");
            RuleFor(p => p.Aciklama).NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez");
          
        }
    }
}
