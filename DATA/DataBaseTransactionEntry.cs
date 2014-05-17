using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA
{
    public static class DataBaseTransactionEntry
    {
        public static void CommitTranactions()
        {
            try
            {
                DataBaseUtilities.DataBaseUtilities.CommitTransactions();
            }
            catch (Exception)
            {                
                throw;
            } 
        }

        public static void RollbackTranactions()
        {
            try
            {
                DataBaseUtilities.DataBaseUtilities.RollbackTransactions();
            }
            catch (Exception)
            {                
                throw;
            }
        }

    }
}
