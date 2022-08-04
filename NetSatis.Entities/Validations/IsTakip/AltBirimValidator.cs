using BSDPROJE.Entities.Tables.isTakip;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Validations.IsTakip
{
  public  class AltBirimValidator: AbstractValidator<BSD_TBL_ALTBIRIM>
    {
        public AltBirimValidator()
        {
            RuleFor(p => p.BirimId).NotEmpty().WithMessage(" Birim Adı Boş Geçilemez");
            RuleFor(p => p.AltBirim).NotEmpty().WithMessage("Alt Birim Adı Boş Geçilemez");

        }
    }
}
