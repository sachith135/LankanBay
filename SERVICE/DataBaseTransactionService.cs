using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA; 

namespace SERVICE
{
    public static class DataBaseTransactionService
    {
        public static void CommitTransactions()
        {
            try
            {
                DataBaseTransactionEntry.CommitTranactions();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static void RollbackTransactions()
        {
            try
            {
                DataBaseTransactionEntry.RollbackTranactions();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
