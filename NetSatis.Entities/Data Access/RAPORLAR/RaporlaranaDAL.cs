using BSDPROJE.Entities.Tables.RAPORLAR;
using BSDPROJE.Entities.Validations.RAPORLAR;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Data_Access.RAPORLAR
{
   public class RaporlaranaDAL:EntityRepositoryBase<NetSatisContext, BSD_TBL_RAPORLAR_ANA, RaporlarANAValidator>
    {
    }
}
