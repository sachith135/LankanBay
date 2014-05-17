using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA.COMMON;

namespace DATA
{
    public class OrderDetailsEntry
    {
        public DataTable Insert(OrderDetails orderDetails, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.BuyerBSPId, orderDetails.BuyerBSPId);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.Operation, operation);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.OrderId, orderDetails.OrderId);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.OrderStatus, orderDetails.OrderStatus);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.PaymentOptionId, orderDetails.PaymentOptionId);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.UserId, orderDetails.UserId);
            return DataBaseUtilities.DataBaseUtilities.InsertWithSelect(WellKnownStoredProcedures.Insert.Insert_OrderDetails, spParameters);
        }

        public DataTable Select(OrderDetails orderDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.BuyerBSPId, orderDetails.BuyerBSPId);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.OrderStatus, orderDetails.OrderStatus);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.PaymentOptionId, orderDetails.PaymentOptionId);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_OrderDetails, spParameters);
        }

        public void DeleteOrderDetailsWithItsAllDetails(OrderDetails orderDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.UserId, orderDetails.UserId);
            spParameters.Add(WellKnownParameters.Inventory.OrdersDetails.OrderId, orderDetails.OrderId);            
            DataBaseUtilities.DataBaseUtilities.Delete(WellKnownStoredProcedures.Delete.Delete_OrderDetailsWithItsAllDetails, spParameters);
        }
    }
}