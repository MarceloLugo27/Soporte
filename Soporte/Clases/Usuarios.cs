using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Clases
{
    public class Usuarios
    {
        #region Variables y encapsulado
        String strNombres;
        String strApellidoPaterno;
        String strApellidoMaterno;
        String strUsername;
        String strPassword;
        DateTime dateFechaRegistro;

        public string StrNombres { get => strNombres; set => strNombres = value; }
        public string StrApellidoPaterno { get => strApellidoPaterno; set => strApellidoPaterno = value; }
        public string StrApellidoMaterno { get => strApellidoMaterno; set => strApellidoMaterno = value; }
        public string StrUsername { get => strUsername; set => strUsername = value; }
        public string StrPassword { get => strPassword; set => strPassword = value; }
        public DateTime DateFechaRegistro { get => dateFechaRegistro; set => dateFechaRegistro = value; }
        #endregion

        public static DataSet UsuarioSelect(int IDUsuario = 0)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDUsuario", SqlDbType = SqlDbType.Int, Value = IDUsuario });

            try
            {
                ds = Conexion.execute_sp("UsuarioSelect", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }
}
