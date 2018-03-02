using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Clases
{
    class HardwarePC
    {
        #region Variables y Encapsulado

        int intIDHardware;
        int intIDAula;
        String intTAG;
        String strUsuarioPC;
        String strSistemaOperativo;
        int intRAM;
        String strDominio;
        String strVersionSO;
        String strServicePack;
        String strNombreProcesador;
        String strCompany;
        String strFabricante;
        String strNumeroSerie;
        Boolean bitActivo;

        public int IntIDHardware { get => intIDHardware; set => intIDHardware = value; }
        public int IntIDAula { get => intIDAula; set => intIDAula = value; }
        public string IntTAG { get => intTAG; set => intTAG = value; }
        public string StrUsuarioPC { get => strUsuarioPC; set => strUsuarioPC = value; }
        public string StrSistemaOperativo { get => strSistemaOperativo; set => strSistemaOperativo = value; }
        public int IntRAM { get => intRAM; set => intRAM = value; }
        public string StrDominio { get => strDominio; set => strDominio = value; }
        public string StrVersionSO { get => strVersionSO; set => strVersionSO = value; }
        public string StrServicePack { get => strServicePack; set => strServicePack = value; }
        public string StrNombreProcesador { get => strNombreProcesador; set => strNombreProcesador = value; }
        public string StrCompany { get => strCompany; set => strCompany = value; }
        public string StrFabricante { get => strFabricante; set => strFabricante = value; }
        public string StrNumeroSerie { get => strNumeroSerie; set => strNumeroSerie = value; }
        public bool BitActivo { get => bitActivo; set => bitActivo = value; }
        #endregion

        public static DataSet EquiposSelectDatos(int TipoAula)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIntTipoAula", SqlDbType = SqlDbType.Int, Value = TipoAula });

            try
            {
                ds = Conexion.execute_sp("EquiposSelectDatos", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet EquiposPorAulaSelect(int IDAula)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAula", SqlDbType = SqlDbType.Int, Value = IDAula });

            try
            {
                ds = Conexion.execute_sp("EquiposPorAulaSelect", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static DataSet EquipoInsertar(HardwarePC Equipo)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAula", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAula });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrTAG", SqlDbType = SqlDbType.VarChar, Value = Equipo.IntTAG });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrUsuarioPC", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrUsuarioPC });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrSistemaOperativo", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrSistemaOperativo });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrDominio", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrDominio });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrVersionSO", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrVersionSO });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrServicePack", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrServicePack });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrNombreProcesador", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrNombreProcesador });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrFabricante", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrFabricante });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrNumeroSerie", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrNumeroSerie });


            try
            {
                ds = Conexion.execute_sp("PCInsertar", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static DataSet EquipoUpdate(HardwarePC Equipo)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDHardware", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDHardware });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAula", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAula });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrTAG", SqlDbType = SqlDbType.VarChar, Value = Equipo.IntTAG });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrUsuarioPC", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrUsuarioPC });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrSistemaOperativo", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrSistemaOperativo });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrDominio", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrDominio });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrVersionSO", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrVersionSO });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrServicePack", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrServicePack });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrNombreProcesador", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrNombreProcesador });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrFabricante", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrFabricante });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrNumeroSerie", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrNumeroSerie });

            try
            {
                ds = Conexion.execute_sp("PCUpdate", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static DataSet EquipoSelectID(int IDHardware)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDHardware", SqlDbType = SqlDbType.Int, Value = IDHardware });

            try
            {
                ds = Conexion.execute_sp("PCSelectID", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
