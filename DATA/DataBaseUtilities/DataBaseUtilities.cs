using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DATA.DataBaseUtilities
{
    public class DataBaseUtilities
    {

        #region constants
        private const string DBConnection = "DBConnection";
        #endregion

        #region global
        private static SqlTransaction CommonTransaction = null;
        private static SqlConnection sqlConnection = null;
        #endregion

        #region Methods

        private static SqlConnection openConnection()
        {
            try
            {
                if (sqlConnection == null)
                {
                    string sqlConnectionString = ConfigurationManager.ConnectionStrings[DBConnection].ToString();
                    sqlConnection = new SqlConnection();
                    sqlConnection.ConnectionString = sqlConnectionString;
                    sqlConnection.Open();
                }
                return sqlConnection;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #region public Methods

        public static DataTable Select(string spName)
        {
            try
            {
                return DataBaseUtilities.Select(spName, null);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable Select(string spName, Dictionary<string, Object> spParameters)
        {
            try
            {
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = CreateSqlCommand(spName, spParameters);

                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Insert(string spName, Dictionary<string, Object> spParameters)
        {
            try
            {
                SqlCommand command = CreateSqlCommand(spName, spParameters);

                if (CommonTransaction == null)
                    CommonTransaction = command.Connection.BeginTransaction();
                command.Transaction = CommonTransaction;
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                if (CommonTransaction != null)
                {

                    CommonTransaction.Rollback();
                    CommonTransaction = null;
                }

                throw e;
            }
        }

        public static string Insert(string spName, Dictionary<string, Object> spParameters, string outPutParameter, int OutputSize)
        {
            string resault = string.Empty;

            try
            {
                SqlCommand command = CreateSqlCommand(spName, spParameters);

                if (CommonTransaction == null)
                    CommonTransaction = command.Connection.BeginTransaction();

                command.Transaction = CommonTransaction;
                command.Parameters[outPutParameter].Direction = ParameterDirection.Output;
                command.Parameters[outPutParameter].DbType = DbType.Int32;
                command.Parameters[outPutParameter].Size = OutputSize;
                command.ExecuteNonQuery();

                resault = command.Parameters[outPutParameter].Value.ToString();

            }
            catch (Exception e)
            {
                if (CommonTransaction != null)
                {
                    CommonTransaction.Rollback();
                    CommonTransaction = null;
                }

                throw e;
            }
            return resault;
        }

        public static DataTable InsertWithSelect(string spName, Dictionary<string, Object> spParameters)
        {
            try
            {
                SqlCommand command = CreateSqlCommand(spName, spParameters);
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();

                if (CommonTransaction == null)
                    CommonTransaction = command.Connection.BeginTransaction();

                command.Transaction = CommonTransaction;

                adapter.SelectCommand = command;

                //command.ExecuteNonQuery();
                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }

            catch (Exception e)
            {
                if (CommonTransaction != null)
                {

                    CommonTransaction.Rollback();
                    CommonTransaction = null;
                }

                throw e;
            }
        }

        public static void Delete(string spName, Dictionary<string, Object> spParameters)
        {
            try
            {
                SqlCommand command = CreateSqlCommand(spName, spParameters);

                if (CommonTransaction == null)
                    CommonTransaction = command.Connection.BeginTransaction();

                command.Transaction = CommonTransaction;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (CommonTransaction != null)
                {
                    CommonTransaction.Rollback();
                    CommonTransaction = null;

                }

                throw ex;
            }
        }

        private static SqlCommand CreateSqlCommand(string spName, Dictionary<string, Object> spParameters)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DataBaseUtilities.openConnection();


                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;

                if (CommonTransaction != null)
                    command.Transaction = CommonTransaction;


                if (spParameters != null)
                {
                    foreach (KeyValuePair<string, Object> item in spParameters)
                    {
                        SqlParameter parameter = new SqlParameter(item.Key, item.Value);
                        command.Parameters.Add(parameter);
                    }
                }
                return command;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Fill(DataTable table, string spName, Dictionary<string, object> para)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = CreateSqlCommand(spName, null);
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Check(string spName, Dictionary<string, Object> spParameters)
        {
            try
            {
                bool returnValue;
                SqlCommand command = CreateSqlCommand(spName, spParameters);
                DataTable dt = DataBaseUtilities.Select(spName, spParameters);
                int x = dt.Rows.Count;
                if (x > 0)
                {
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                }
                return returnValue;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool CheckStatus(string spName, Dictionary<string, Object> spParameters)
        {
            try
            {
                bool returnValue;
                int i = 0;
                SqlCommand command = CreateSqlCommand(spName, spParameters);
                i = int.Parse(command.ExecuteScalar().ToString());

                if (i > 0)
                {
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                }
                return returnValue;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void CommitTransactions()
        {
            if (CommonTransaction != null)
            {
                CommonTransaction.Commit();
                CommonTransaction = null;
            }
            sqlConnection = null;
        }

        public static void RollbackTransactions()
        {
            if (CommonTransaction != null)
            {
                CommonTransaction.Rollback();
                CommonTransaction = null;
            }

            sqlConnection = null;

        }

        # endregion

        #endregion
    }
}
