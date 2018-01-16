using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Clases
{
    class Conexion
    {
        public static int IDReporte;
        public static DateTime FechaInicio;
        public static DateTime FechaFinal;

        public static String Username;
        public static String UserPassword;
        public static String NombreUsuario;
        public static int IDUsuario;
        
        //static String ConnectionString = @"Data Source=DESKTOP-N571H5G\MSL2014;Initial Catalog=dbSoporte;User ID=sa;Password=marcelo123";
        static String ConnectionString = @"Data Source=148.234.36.232\MSL;Initial Catalog=dbSoporte;User ID=sa;Password=marcelo123";
        public static DataSet execute_sp(string query, List<SqlParameter> ListParameters)
        {
            SqlCommand command;
            SqlDataAdapter adapter;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    String cadena = ConnectionString;
                    connection.ConnectionString = cadena;
                    connection.Open();
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //command.CommandTimeout = 120000;
                    foreach (SqlParameter item in ListParameters)
                    {
                        command.Parameters.AddWithValue(item.ParameterName, item.SqlDbType).Value = item.Value;
                    }
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                adapter = null;
            }
            return ds;
        }

        public static DataSet FechaRevisionesSelect(int TipoPeriodo, int IDFecha = 0)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@pIDFecha", SqlDbType = SqlDbType.Int, Value = IDFecha },
                new SqlParameter { ParameterName = "@pIntTipoPeriodo", SqlDbType = SqlDbType.Int, Value = TipoPeriodo }
            };

            try
            {
                ds = Conexion.execute_sp("FechaRevisionesSelect", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet FechasRevisionesInsert(String DescripcionPeriodo, DateTime FechaInicial, DateTime FechaIntermedia, DateTime FechaFinal, int TipoPeriodo)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@pStrDescripcionFecha", SqlDbType = SqlDbType.VarChar, Value = DescripcionPeriodo },
                new SqlParameter { ParameterName = "@pDateFechaInicio", SqlDbType = SqlDbType.DateTime2, Value = FechaInicial},
                new SqlParameter { ParameterName = "@pDateFechaIntermedia", SqlDbType = SqlDbType.DateTime2, Value = FechaIntermedia},
                new SqlParameter { ParameterName = "@pDateFechaFinal", SqlDbType = SqlDbType.DateTime2, Value = FechaIntermedia},
                new SqlParameter { ParameterName = "@pIntTipoPeriodo", SqlDbType = SqlDbType.Int, Value = TipoPeriodo }
            };

            try
            {
                ds = Conexion.execute_sp("FechaRevisionesInsert", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet Login()
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@pStrUsername", SqlDbType = SqlDbType.Int, Value = Username },
                new SqlParameter { ParameterName = "@pStrPassword", SqlDbType = SqlDbType.Int, Value = UserPassword }
            };

            try
            {
                ds = Conexion.execute_sp("Login", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;

        }


    }
}
