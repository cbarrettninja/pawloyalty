﻿using Paw.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paw.Services.Messages.Web.Skus
{
    public class GetRootSkuList : IProviderId
    {
        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private Guid _Id = Guid.Empty;

        public Guid ProviderId
        {
            get { return _ProviderId; }
            set { _ProviderId = value; }
        }
        private Guid _ProviderId = Guid.Empty;
        
        public List<Sku> ExecuteItem()
        {
            List<Sku> skuList = new GetSkuList() { ProviderId = this.ProviderId }.ExecuteList();
            return skuList.FindAll(x => x.ParentId == null).ToList();
        }

    }
}
