using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
using BSDPROJE.Entities.Validations.IsTakip.Ozellikler;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Data_Access.IsTakip.Ozellikler
{
   public class OzelliklerDAL: EntityRepositoryBase<NetSatisContext, BSD_TBL_OZELLIKLER, OzelliklerValidator>
    {
    }
}
