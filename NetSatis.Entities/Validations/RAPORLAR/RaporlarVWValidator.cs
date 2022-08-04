using BSDPROJE.Entities.Tables.RAPORLAR;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Validations.RAPORLAR
{
    public class RaporlarVWValidator : AbstractValidator<BSD_TBL_RAPORLAR_VW>
    {
        public RaporlarVWValidator()
        {
            RuleFor(p => p.Kategorid).GreaterThan(-1).WithMessage("Kategori Adı Boş Geçilemez");
            RuleFor(p => p.VwAdi).NotEmpty().WithMessage("Menü Adı Boş Geçilemez");
            RuleFor(p => p.VwYolu).NotEmpty().WithMessage("Menü Yolunu Seçiniz");
        }
    }
}
