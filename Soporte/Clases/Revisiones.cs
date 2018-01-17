using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Clases
{
    class RevisionEquiposPrivados
    {
        #region Variables y encapsulado
        int intIDUsuario;
        int intIDHardware;
        DateTime dateFechaRegistro;
        String strObservaciones;
        int intIDAsistente1;
        int intIDAsistente2;
        int intIDAsistente3;
        DateTime dateFechaIngresoSistema;
        Boolean boolRevisionCPU;
        Boolean boolRevisionMonitor;
        Boolean boolRevisionMouse;
        Boolean boolRevisionTeclado;
        Boolean boolRevisionCablesVideo;
        Boolean boolRevisionCablesUSB;
        Boolean boolRevisionProyector;
        Boolean boolRevisionUpdates;
        Boolean boolRevisionOptimizacion;
        Boolean boolRevisionAntivirus;

        public int IntIDUsuario { get => intIDUsuario; set => intIDUsuario = value; }
        public DateTime DateFechaRegistro { get => dateFechaRegistro; set => dateFechaRegistro = value; }
        public string StrObservaciones { get => strObservaciones; set => strObservaciones = value; }
        public int IntIDAsistente1 { get => intIDAsistente1; set => intIDAsistente1 = value; }
        public int IntIDAsistente2 { get => intIDAsistente2; set => intIDAsistente2 = value; }
        public int IntIDAsistente3 { get => intIDAsistente3; set => intIDAsistente3 = value; }
        public DateTime DateFechaIngresoSistema { get => dateFechaIngresoSistema; set => dateFechaIngresoSistema = value; }
        public bool BoolRevisionCPU { get => boolRevisionCPU; set => boolRevisionCPU = value; }
        public bool BoolRevisionMonitor { get => boolRevisionMonitor; set => boolRevisionMonitor = value; }
        public bool BoolRevisionTeclado { get => boolRevisionTeclado; set => boolRevisionTeclado = value; }
        public bool BoolRevisionCablesVideo { get => boolRevisionCablesVideo; set => boolRevisionCablesVideo = value; }
        public bool BoolRevisionCablesUSB { get => boolRevisionCablesUSB; set => boolRevisionCablesUSB = value; }
        public bool BoolRevisionProyector { get => boolRevisionProyector; set => boolRevisionProyector = value; }
        public bool BoolRevisionUpdates { get => boolRevisionUpdates; set => boolRevisionUpdates = value; }
        public bool BoolRevisionOptimizacion { get => boolRevisionOptimizacion; set => boolRevisionOptimizacion = value; }
        public bool BoolRevisionAntivirus { get => boolRevisionAntivirus; set => boolRevisionAntivirus = value; }
        public int IntIDHardware { get => intIDHardware; set => intIDHardware = value; }
        public bool BoolRevisionMouse { get => boolRevisionMouse; set => boolRevisionMouse = value; }
        #endregion

        public static DataSet RevisionAulasInsertar(RevisionEquiposPrivados Equipo)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDUsuario", SqlDbType = SqlDbType.Int, Value = 1 });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDHardware", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDHardware });
            listParameters.Add(new SqlParameter { ParameterName = "@pDateFechaRegistro", SqlDbType = SqlDbType.DateTime2, Value = Equipo.DateFechaRegistro });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrObservaciones", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrObservaciones });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente1", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente1 });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente2", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente2 });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente3", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente3 });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionCPU", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionCPU });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionMonitor", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionMonitor });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionMouse", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionMouse });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionTeclado", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionTeclado });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionCablesVideo", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionTeclado });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionCablesUSB", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionCablesUSB });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionProyector", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionProyector });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionUpdates", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionUpdates });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRevisionAntivirus", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionAntivirus });
            listParameters.Add(new SqlParameter { ParameterName = "@pbitRevisionOptimizacion", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRevisionAntivirus });

            try
            {
                ds = Conexion.execute_sp("RevisionAulasInsertar", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static DataSet ListaReportesAulasPrivadas()
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            try
            {
                ds = Conexion.execute_sp("ListaReportesAulasPrivadas", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet ReportesAulasPrivadas(int IDReporte)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@IDReporte", SqlDbType = SqlDbType.Int, Value = IDReporte });

            try
            {
                ds = Conexion.execute_sp("ReportesAulasPrivadas", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }

    class RevisionEquiposMultiples
    {
        #region Variables y encapsulado
        int intIDUsuario;
        int intIDHardware;
        DateTime dateFechaRegistro;
        String strObservaciones;
        int intIDAsistente1;
        int intIDAsistente2;
        int intIDAsistente3;
        DateTime dateFechaIngresoSistema;
        Boolean boolRendimiento;
        Boolean boolPerifericos;
        Boolean boolLimpieza;

        public int IntIDUsuario { get => intIDUsuario; set => intIDUsuario = value; }
        public DateTime DateFechaRegistro { get => dateFechaRegistro; set => dateFechaRegistro = value; }
        public string StrObservaciones { get => strObservaciones; set => strObservaciones = value; }
        public int IntIDAsistente1 { get => intIDAsistente1; set => intIDAsistente1 = value; }
        public int IntIDAsistente2 { get => intIDAsistente2; set => intIDAsistente2 = value; }
        public int IntIDAsistente3 { get => intIDAsistente3; set => intIDAsistente3 = value; }
        public DateTime DateFechaIngresoSistema { get => dateFechaIngresoSistema; set => dateFechaIngresoSistema = value; }
        public bool BoolRendimiento { get => boolRendimiento; set => boolRendimiento = value; }
        public bool BoolPerifericos { get => boolPerifericos; set => boolPerifericos = value; }
        public bool BoolLimpieza { get => boolLimpieza; set => boolLimpieza = value; }
        public int IntIDHardware { get => intIDHardware; set => intIDHardware = value; }


        #endregion

        public static DataSet RevisionAulasInsertar(RevisionEquiposMultiples Equipo)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDUsuario", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDUsuario });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDHardware", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDHardware });
            listParameters.Add(new SqlParameter { ParameterName = "@pDateFechaRegistro", SqlDbType = SqlDbType.DateTime2, Value = Equipo.DateFechaRegistro });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrObservaciones", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrObservaciones });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente1", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente1 });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente2", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente2 });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente3", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente3 });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRendimiento", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRendimiento });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitPerifericos", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolPerifericos });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitLimpieza", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolLimpieza });

            try
            {
                ds = Conexion.execute_sp("RevisionAulasMultiplesInsertar", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static DataSet ListaReportesAulasMultiples(DateTime FechaInicio, DateTime FechaFinal)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@dateFechaInicio", SqlDbType = SqlDbType.DateTime2, Value = FechaInicio });
            listParameters.Add(new SqlParameter { ParameterName = "@dateFechaFinal", SqlDbType = SqlDbType.DateTime2, Value = FechaFinal });
            try
            {
                ds = Conexion.execute_sp("ListaReportesAulasMultiples", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet ReportesAulasMultiples(int IDAula, DateTime FechaInicio, DateTime FechaFinal)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@IDAula", SqlDbType = SqlDbType.Int, Value = IDAula });
            listParameters.Add(new SqlParameter { ParameterName = "@pDateFechaInicio", SqlDbType = SqlDbType.VarChar, Value = FechaInicio.ToString("yyyy-MM-dd") });
            listParameters.Add(new SqlParameter { ParameterName = "@pDateFechaFinal", SqlDbType = SqlDbType.VarChar, Value = FechaFinal });

            try
            {
                ds = Conexion.execute_sp("ReportesAulasMultiples", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }

    class RevisionEquiposAdmin
    {
        #region Variables y encapsulado
        int intIDUsuario;
        int intIDHardware;
        DateTime dateFechaRegistro;
        String strObservaciones;
        int intIDAsistente1;
        int intIDAsistente2;
        int intIDAsistente3;
        DateTime dateFechaIngresoSistema;
        Boolean boolRendimiento;
        Boolean boolPerifericos;
        Boolean boolLimpieza;

        public int IntIDUsuario { get => intIDUsuario; set => intIDUsuario = value; }
        public DateTime DateFechaRegistro { get => dateFechaRegistro; set => dateFechaRegistro = value; }
        public string StrObservaciones { get => strObservaciones; set => strObservaciones = value; }
        public int IntIDAsistente1 { get => intIDAsistente1; set => intIDAsistente1 = value; }
        public int IntIDAsistente2 { get => intIDAsistente2; set => intIDAsistente2 = value; }
        public int IntIDAsistente3 { get => intIDAsistente3; set => intIDAsistente3 = value; }
        public DateTime DateFechaIngresoSistema { get => dateFechaIngresoSistema; set => dateFechaIngresoSistema = value; }
        public bool BoolRendimiento { get => boolRendimiento; set => boolRendimiento = value; }
        public bool BoolPerifericos { get => boolPerifericos; set => boolPerifericos = value; }
        public bool BoolLimpieza { get => boolLimpieza; set => boolLimpieza = value; }
        public int IntIDHardware { get => intIDHardware; set => intIDHardware = value; }


        #endregion

        public static DataSet RevisionAulasInsertar(RevisionEquiposAdmin Equipo)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pIDUsuario", SqlDbType = SqlDbType.Int, Value = Conexion.IDUsuario });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDHardware", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDHardware });
            listParameters.Add(new SqlParameter { ParameterName = "@pDateFechaRegistro", SqlDbType = SqlDbType.DateTime2, Value = Equipo.DateFechaRegistro });
            listParameters.Add(new SqlParameter { ParameterName = "@pStrObservaciones", SqlDbType = SqlDbType.VarChar, Value = Equipo.StrObservaciones });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente1", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente1 });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente2", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente2 });
            listParameters.Add(new SqlParameter { ParameterName = "@pIDAsistente3", SqlDbType = SqlDbType.Int, Value = Equipo.IntIDAsistente3 });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitRendimiento", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolRendimiento });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitPerifericos", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolPerifericos });
            listParameters.Add(new SqlParameter { ParameterName = "@pBitLimpieza", SqlDbType = SqlDbType.Bit, Value = Equipo.BoolLimpieza });

            try
            {
                ds = Conexion.execute_sp("RevisionAdministrativoInsertar", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet ListaReportesAdmin()
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            try
            {
                ds = Conexion.execute_sp("ListaReportesAdmin", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet ReportesAulasAdmin(int IDReporte)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@IDReporte", SqlDbType = SqlDbType.Int, Value = IDReporte });

            try
            {
                ds = Conexion.execute_sp("ReportesAulasAdmin", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet ReportesAulasAdminGeneral(DateTime FechaInicio, DateTime FechaFinal)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(new SqlParameter { ParameterName = "@pDateFechaInicio", SqlDbType = SqlDbType.VarChar, Value = FechaInicio.ToString("yyyy-MM-dd") });
            listParameters.Add(new SqlParameter { ParameterName = "@pDateFechaFinal", SqlDbType = SqlDbType.VarChar, Value = FechaFinal.ToString("yyyy-MM-dd") });

            try
            {
                ds = Conexion.execute_sp("ReportesAulasAdminGeneral", listParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
