using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class OrderDetailsService
    {
        OrderDetailsEntry orderDetailsEntry = new OrderDetailsEntry();

        public DataTable Insert(OrderDetails orderDetails)
        {
            return orderDetailsEntry.Insert(orderDetails, CommonParameterNames.Operations.Insert);
        }

        public void  UpdatePaymentOption(OrderDetails orderDetails)
        {
            orderDetailsEntry.Insert(orderDetails,"P");
        }

        public DataTable Select(OrderDetails orderDetails)
        {
            return orderDetailsEntry.Select(orderDetails);
        }

        public void DeleteOrderDetailsWithItsAllDetails(OrderDetails orderDetails)
        {
            orderDetailsEntry.DeleteOrderDetailsWithItsAllDetails(orderDetails);
        }


    }
}