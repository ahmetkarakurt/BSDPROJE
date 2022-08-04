using BSDPROJE.Entities.Tables.isTakip;
using BSDPROJE.Entities.Validations.IsTakip;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Data_Access.IsTakip
{
    public class AltBirimDAL :  EntityRepositoryBase<NetSatisContext, BSD_TBL_ALTBIRIM, AltBirimValidator>
    {
    }
}
