using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA.COMMON;
namespace DATA
{
    public class OrderDetailsInDetailEntry
    {
        public void Insert(OrderDetailsInDetail orderDetailsInDetail, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.DeliveryChargers, orderDetailsInDetail.DeliveryChargers);
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.Operation, operation);
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.ItemId, orderDetailsInDetail.ItemId);
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.OrderDetailId, orderDetailsInDetail.OrderDetailId);
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.OrderId, orderDetailsInDetail.OrderId);
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.Qty, orderDetailsInDetail.Qty);
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.UnitPrice, orderDetailsInDetail.UnitPrice);
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.UserId, orderDetailsInDetail.UserId);
            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_OrderDetailsInDetail, spParameters);
        }

        public DataTable Select(OrderDetailsInDetail orderDetailsInDetail)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();         
            spParameters.Add(WellKnownParameters.Inventory.OrderDetailsInDetail.OrderId, orderDetailsInDetail.OrderId);            
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_OrderDetailsInDetailForOrderHistoy, spParameters);
        }


    }
}