﻿using BSDPROJE.Entities.Tables;
using BSDPROJE.Entities.Validations;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Data_Access
{
    public class IS_BelgeHareket : EntityRepositoryBase<NetSatisContext, BSD_TBL_BELGEHAREKET, Is_BelgeHareketValidator>
    {
    }
}