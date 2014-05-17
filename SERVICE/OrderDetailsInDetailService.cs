using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class OrderDetailsInDetailService
    {
        OrderDetailsInDetailEntry orderDetailsInDetailEntry = new OrderDetailsInDetailEntry();

        public void Insert(OrderDetailsInDetail orderDetailsInDetail)
        {
            orderDetailsInDetailEntry.Insert(orderDetailsInDetail,CommonParameterNames.Operations.Insert);
        }

        public DataTable Select(OrderDetailsInDetail orderDetailsInDetail)
        {
            return orderDetailsInDetailEntry.Select(orderDetailsInDetail);
        }

    }
}