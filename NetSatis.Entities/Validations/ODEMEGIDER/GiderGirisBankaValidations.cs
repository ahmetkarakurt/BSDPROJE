using BSDPROJE.Entities.Tables.ODEMEGIDER;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Validations.ODEMEGIDER
{
    public class GiderGirisBankaValidations : AbstractValidator<BSD_TBL_ODEME>
    {
        public GiderGirisBankaValidations()
        {
            RuleFor(p => p.Tarih).NotEmpty().WithMessage("Tarih Boş Geçilemez.");
            RuleFor(p => p.Tutar).GreaterThanOrEqualTo(0).WithMessage("Tutar 0 Olamaz ");
            RuleFor(p => p.Tutar).NotEmpty().WithMessage("Tutar Boş Geçilemez ");
            RuleFor(p => p.OdemeTuru).NotEmpty().WithMessage("Ödeme Türü Boş Geçilemez ");



        }

    }
}
