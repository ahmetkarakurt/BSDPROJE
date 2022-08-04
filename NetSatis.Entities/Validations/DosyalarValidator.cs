using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSDPROJE.Entities.Tables;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class DosyalarValidator : AbstractValidator<BSD_TBL_Dosyalar>
    {
        public DosyalarValidator()
        {

        }
    }
}
