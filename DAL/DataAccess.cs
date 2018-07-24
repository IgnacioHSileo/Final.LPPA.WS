using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{

        public class DataAccess
        {
            private SqlConnection cnn;  //Objeto Conexión
            private SqlTransaction tx;  //Objeto Transacción

            //Singleton
            private static DataAccess instance;
            public static DataAccess Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DataAccess();
                    return instance;
                }
            }

            private DataAccess() { }

            private void OpenCn()
            {
                try
                {
                    
                    cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LPPA.TURNOS.FINAL.2018.v1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    cnn.Open();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            private void CloseCn()
            {
                try
                {
                    cnn.Close();
                    cnn = null;
                    GC.Collect();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            public DataTable Read(string store, CommandType type, SqlParameter[] param = null)
            {
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                OpenCn();
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.CommandText = store;
                adapter.SelectCommand.CommandType = type;
                if (param != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(param);
                }
                adapter.SelectCommand.Connection = cnn;
                adapter.Fill(tabla);
                CloseCn();
                return tabla;
            }
 
            public int Write(string store, CommandType type, SqlParameter[] param)
            {
                int retorno;
                SqlCommand command = new SqlCommand();
                OpenCn();
                command.CommandText = store;
                command.CommandType = type;
                command.Connection = cnn;
                command.Parameters.AddRange(param);
                tx = cnn.BeginTransaction();
                command.Transaction = tx;
                try
                {
                    retorno = command.ExecuteNonQuery();
                    tx.Commit();
                    return retorno;
                }
                catch (Exception ex)
                {
                    retorno = -1;
                    tx.Rollback();
                    return retorno;
                }
                finally
                {
                    CloseCn();
                }
            }

            #region Create Parameter
            public static SqlParameter CreateParameter(string name, string value)
            {
                SqlParameter param = new SqlParameter(name, value);
                param.SqlDbType = SqlDbType.NVarChar;
                return param;
            }

            public static SqlParameter CreateParameter(string name, int value)
            {
                SqlParameter param = new SqlParameter(name, value);
                param.SqlDbType = SqlDbType.Int;
                return param;
            }

            public static SqlParameter CreateParameter(string name, long value)
            {
                SqlParameter param = new SqlParameter(name, value);
                param.SqlDbType = SqlDbType.Int;
                return param;
            }

            public static SqlParameter CreateParameter(string name, bool value)
            {
                SqlParameter param = new SqlParameter(name, value);
                param.SqlDbType = SqlDbType.Bit;
                return param;
            }

            public static SqlParameter CreateParameter(string name, DateTime value)
            {
                SqlParameter param = new SqlParameter(name, value);
                param.SqlDbType = SqlDbType.Date;
                return param;
            }

            public static SqlParameter CreateParameter(string name, Double value)
            {
                SqlParameter param = new SqlParameter(name, value);
                param.SqlDbType = SqlDbType.Decimal;
                return param;
            }

            public static SqlParameter CreateParameter(string name, Decimal value)
            {
                SqlParameter param = new SqlParameter(name, value);
                param.SqlDbType = SqlDbType.Decimal;
                return param;
            }

            public static SqlParameter CreateParameter(string name)
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = name;
                param.SqlDbType = SqlDbType.BigInt;
                param.SqlValue = DBNull.Value;
                return param;
            }
            #endregion

        }
    }



