using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Clases
{
    public class Aulas
    {
        #region Variables y encapsulado
        protected int intIDAula;
        protected String strDescripcionAula;
        protected int intTipoAula;
        protected Boolean boolEsActivo;

        public string StrDescripcionAula { get => strDescripcionAula; set => strDescripcionAula = value; }
        public int IntTipoAula { get => intTipoAula; set => intTipoAula = value; }
        public bool BoolEsActivo { get => boolEsActivo; set => boolEsActivo = value; }
        public int IntIDAula { get => intIDAula; set => intIDAula = value; }
        #endregion

        public static DataSet AulasSelect(int IDAula = 0)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAula", SqlDbType = SqlDbType.Int, Value = IDAula });

            try
            {
                ds = Conexion.execute_sp("AulasSelect", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static DataSet AulasInsert(Aulas aulas)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pStrDescripcionAula", SqlDbType = SqlDbType.VarChar, Value = aulas.StrDescripcionAula });
            listParameters.Add(new SqlParameter { ParameterName = "@pIntTipoAula", SqlDbType = SqlDbType.VarChar, Value = aulas.IntTipoAula });

            try
            {
                ds = Conexion.execute_sp("AulasInsert", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet AulasTiposSelect(int TipoAula)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIntTipoAula", SqlDbType = SqlDbType.Int, Value = TipoAula });

            try
            {
                ds = Conexion.execute_sp("AulasTiposSelect", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }
}
