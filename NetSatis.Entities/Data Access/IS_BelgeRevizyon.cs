using BSDPROJE.Entities.Tables;
using BSDPROJE.Entities.Validations;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Validations;


namespace BSDPROJE.Entities.Data_Access
{
   public class IS_BelgeRevizyon :EntityRepositoryBase<NetSatisContext, BSD_TBL_BELGEREVIZYON, Is_BelgeRevizyonValidator>
    {
    }
}
