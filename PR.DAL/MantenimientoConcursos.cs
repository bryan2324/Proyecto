using PR.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.DAL
{
    public class MantenimientoConcursos:IMantenimientoConcursos
    {
        private static MantenimientoConcursos Instancia;

        public static MantenimientoConcursos _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new MantenimientoConcursos();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        public void Actualizar(Concurso concurso)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param0 = factory.CreateParameter();
                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();
                DbParameter param5 = factory.CreateParameter();
                DbParameter param6 = factory.CreateParameter();
                DbParameter param7 = factory.CreateParameter();
                DbParameter param8 = factory.CreateParameter();
                DbParameter param9 = factory.CreateParameter();
         


                param0.ParameterName = "@IdConcurso";
                param0.DbType = DbType.Int32;
                param0.Value = concurso._IdConcurso;


                param1.ParameterName = "@Empresa";
                param1.DbType = DbType.String;
                param1.Value = concurso._Empresa;

                param2.ParameterName = "@Idiomas";
                param2.DbType = DbType.String;
                param2.Value = concurso._Idiomas;

                param3.ParameterName = "@Pasaporte";
                param3.DbType = DbType.String;
                param3.Value = concurso._Pasaporte;

                param4.ParameterName = "@PuestoReq";
                param4.DbType = DbType.String;
                param4.Value = concurso._PuestoReq;

                param5.ParameterName = "@AnoExperienciaReq";
                param5.DbType = DbType.Int32;
                param5.Value = concurso._AnoExperienciaReq;

                param6.ParameterName = "@UniversidadProc";
                param6.DbType = DbType.String;
                param6.Value = concurso._UniversidadProc;

                param7.ParameterName = "@Edad";
                param7.DbType = DbType.Int32;
                param7.Value = concurso._Edad;

                param8.ParameterName = "@IngRequerida";
                param8.DbType = DbType.String;
                param8.Value = concurso._IngRequerida;

           

                param9.ParameterName = "@FechaFinalizacion";
                param9.DbType = DbType.DateTime;
                param9.Value = concurso._FechaFinalizacion;







                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "ActualizarConcurso";
                comm.Parameters.Add(param0);
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.Parameters.Add(param8);
                comm.Parameters.Add(param9);
          



                comm.ExecuteNonQuery();

            }
            catch (Exception ee)
            {

                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

        public void Eliminar(Concurso concurso)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param0 = factory.CreateParameter();

                param0.ParameterName = "@IdConcurso";
                param0.DbType = DbType.Int32;
                param0.Value = concurso._IdConcurso;

                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "disableConcurso";
                comm.Parameters.Add(param0);
                comm.ExecuteNonQuery();

            }
            catch (Exception ee)
            {

                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

        public void Insertar(Concurso concurso)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();
                DbParameter param5 = factory.CreateParameter();
                DbParameter param6 = factory.CreateParameter();
                DbParameter param7 = factory.CreateParameter();
                DbParameter param8 = factory.CreateParameter();
                DbParameter param9 = factory.CreateParameter();
              


                param1.ParameterName = "@Empresa";
                param1.DbType = DbType.String;
                param1.Value = concurso._Empresa;

                param2.ParameterName = "@Idiomas";
                param2.DbType = DbType.String;
                param2.Value = concurso._Idiomas;

                param3.ParameterName = "@Pasaporte";
                param3.DbType = DbType.String;
                param3.Value = concurso._Pasaporte;

                param4.ParameterName = "@PuestoReq";
                param4.DbType = DbType.String;
                param4.Value = concurso._PuestoReq;

                param5.ParameterName = "@AnoExperienciaReq";
                param5.DbType = DbType.Int32;
                param5.Value = concurso._AnoExperienciaReq;

                param6.ParameterName = "@UniversidadProc";
                param6.DbType = DbType.String;
                param6.Value = concurso._UniversidadProc;

                param7.ParameterName = "@Edad";
                param7.DbType = DbType.Int32;
                param7.Value = concurso._Edad;

                param8.ParameterName = "@IngRequerida";
                param8.DbType = DbType.String;
                param8.Value = concurso._IngRequerida;

            

                param9.ParameterName = "@FechaFinalizacion";
                param9.DbType = DbType.DateTime;
                param9.Value = concurso._FechaFinalizacion;

              


                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insertarConcurso";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.Parameters.Add(param8);
                comm.Parameters.Add(param9);
          


                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {



                throw;
            }
            finally
            {

            }
        }

        public List<Concurso> Mostrar()
        {
            //Inicializamos
            List<Concurso> lista = new List<Concurso>();

            DbConnection conn = null;
            DbCommand comm = null;

            try
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);

                conn = factory.CreateConnection();
                conn.ConnectionString = Settings.Default.connection;
                comm = factory.CreateCommand();

                comm.Connection = conn;
                conn.Open();

                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "MostrarConcurso";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    Concurso concurso;
                    while (dataReader.Read())
                    {
                        concurso = new Concurso
                        {
                            _IdConcurso = Convert.ToInt32(dataReader["IdConcurso"].ToString()),
                            _Empresa = dataReader["Empresa"].ToString(),
                            _Idiomas = dataReader["Idiomas"].ToString(),
                            _Pasaporte = dataReader["Pasaporte"].ToString(),
                            _PuestoReq = dataReader["PuestoReq"].ToString(),
                            _AnoExperienciaReq = Convert.ToInt32(dataReader["AnoExperienciaReq"].ToString()),
                            _UniversidadProc = dataReader["UniversidadProc"].ToString(),
                            _Edad = Convert.ToInt32(dataReader["Edad"].ToString()),
                            _IngRequerida = dataReader["IngRequerida"].ToString(),
                            _FechaInicio = Convert.ToDateTime(dataReader["FechaInicio"].ToString()),
                            _FechaFinalizacion = Convert.ToDateTime(dataReader["FechaFinalizacion"].ToString()),

                        };
                        lista.Add(concurso);
                    }
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }



        }
    }
}
