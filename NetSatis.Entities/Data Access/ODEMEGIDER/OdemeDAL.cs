using BSDPROJE.Entities.Tables.ODEMEGIDER;
using BSDPROJE.Entities.Validations.ODEMEGIDER;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Data_Access.ODEMEGIDER
{
    public class OdemeDAL : EntityRepositoryBase<NetSatisContext, BSD_TBL_ODEME, GiderGirisBankaValidations>
    {

    }
}
