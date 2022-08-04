﻿using BSDPROJE.Entities.Tables.isTakip;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Validations.IsTakip
{
   public class BirimValidator : AbstractValidator<BSD_TBL_BIRIM>
    {
        public BirimValidator()
        {
            RuleFor(p => p.Birim).NotEmpty().WithMessage(" Birim Adı Boş Geçilemez");
        }
    }
}
