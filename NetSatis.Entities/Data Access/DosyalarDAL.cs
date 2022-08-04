using BSDPROJE.Entities.Tables;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.Data_Access
{
    public class DosyalarDAL : EntityRepositoryBase<NetSatisContext, BSD_TBL_Dosyalar, DosyalarValidator>
    {
    }
}
