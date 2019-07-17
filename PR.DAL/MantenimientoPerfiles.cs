using PR.DO;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR.DAL
{
    public class MantenimientoPerfiles:IMantenimientoPerfiles
    {
     
        private static MantenimientoPerfiles Instancia;

        public static MantenimientoPerfiles _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new MantenimientoPerfiles();
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

        public void Actualizar(Perfil persona)
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
                DbParameter param10 = factory.CreateParameter();
                DbParameter param11 = factory.CreateParameter();
                DbParameter param12 = factory.CreateParameter();
                DbParameter param13 = factory.CreateParameter();
                DbParameter param14 = factory.CreateParameter();
                DbParameter param15 = factory.CreateParameter();
                DbParameter param16 = factory.CreateParameter();
     

                param0.ParameterName = "@ID";
                param0.DbType = DbType.Int32;
                param0.Value = persona._ID;

                param1.ParameterName = "@Nombre";
                param1.DbType = DbType.String;
                param1.Value = persona._Nombre;

                param2.ParameterName = "@Cedula";
                param2.DbType = DbType.Int32;
                param2.Value = persona._Cedula;

                param3.ParameterName = "@ProfesionPrinc";
                param3.DbType = DbType.String;
                param3.Value = persona._ProfesionPrinc;

                param4.ParameterName = "@CantidadTitulos";
                param4.DbType = DbType.Int32;
                param4.Value = persona._CantidadTitulos;

                param5.ParameterName = "@ConocimientoAdic";
                param5.DbType = DbType.String;
                param5.Value = persona._ConocimientosAdic;

                param6.ParameterName = "@Telefono";
                param6.DbType = DbType.Int32;
                param6.Value = persona._Telefono;

                param7.ParameterName = "@Mail";
                param7.DbType = DbType.String;
                param7.Value = persona._Mail;

                param8.ParameterName = "@Fecha_Nacimiento";
                param8.DbType = DbType.Date;
                param8.Value = persona._Fecha_Nacimiento;

                param9.ParameterName = "@Residencia";
                param9.DbType = DbType.String;
                param9.Value = persona._Residencia;

                param10.ParameterName = "@Universidad";
                param10.DbType = DbType.String;
                param10.Value = persona._Universidad;

                param11.ParameterName = "@AnoGraduacion";
                param11.DbType = DbType.Date;
                param11.Value = persona._AnoGraduacion;

                param12.ParameterName = "@AnoExperiencia";
                param12.DbType = DbType.Int32;
                param12.Value = persona._AnoExperiencia;

                param13.ParameterName = "@CantidadEmpleos";
                param13.DbType = DbType.Int32;
                param13.Value = persona._CantidadEmpleos;

                param14.ParameterName = "@CantidadDespidos";
                param14.DbType = DbType.Int32;
                param14.Value = persona._CantidadDespidos;

                param15.ParameterName = "@Idiomas";
                param15.DbType = DbType.String;
                param15.Value = persona._Idiomas;

                param16.ParameterName = "@Pasaporte";
                param16.DbType = DbType.String;
                param16.Value = persona._Pasaporte;


                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "ActualizarPerfil";
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
                comm.Parameters.Add(param10);
                comm.Parameters.Add(param11);
                comm.Parameters.Add(param12);
                comm.Parameters.Add(param13);
                comm.Parameters.Add(param14);
                comm.Parameters.Add(param15);
                comm.Parameters.Add(param16);




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

        public void Eliminar(Perfil persona)
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

                param0.ParameterName = "@ID";
                param0.DbType = DbType.Int32;
                param0.Value = persona._ID;

                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "disablePerfil";
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

        public void Insertar(Perfil persona)
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
                DbParameter param10 = factory.CreateParameter();
                DbParameter param11 = factory.CreateParameter();
                DbParameter param12 = factory.CreateParameter();
                DbParameter param13 = factory.CreateParameter();
                DbParameter param14 = factory.CreateParameter();
                DbParameter param15 = factory.CreateParameter();
                DbParameter param16 = factory.CreateParameter();


                param1.ParameterName = "@Nombre";
                param1.DbType = DbType.String;
                param1.Value = persona._Nombre;

                param2.ParameterName = "@Cedula";
                param2.DbType = DbType.Int32;
                param2.Value = persona._Cedula;

                param3.ParameterName = "@ProfesionPrinc";
                param3.DbType = DbType.String;
                param3.Value = persona._ProfesionPrinc;

                param4.ParameterName = "@CantidadTitulos";
                param4.DbType = DbType.Int32;
                param4.Value = persona._CantidadTitulos;

                param5.ParameterName = "@ConocimientoAdic";
                param5.DbType = DbType.String;
                param5.Value = persona._ConocimientosAdic;

                param6.ParameterName = "@Telefono";
                param6.DbType = DbType.Int32;
                param6.Value = persona._Telefono;

                param7.ParameterName = "@Mail";
                param7.DbType = DbType.String;
                param7.Value = persona._Mail;

                param8.ParameterName = "@Fecha_Nacimiento";
                param8.DbType = DbType.Date;
                param8.Value = persona._Fecha_Nacimiento;

                param9.ParameterName = "@Residencia";
                param9.DbType = DbType.String;
                param9.Value = persona._Residencia;

                param10.ParameterName = "@Universidad";
                param10.DbType = DbType.String;
                param10.Value = persona._Universidad;

                param11.ParameterName = "@AnoGraduacion";
                param11.DbType = DbType.Date;
                param11.Value = persona._AnoGraduacion;

                param12.ParameterName = "@AnoExperiencia";
                param12.DbType = DbType.Int32;
                param12.Value = persona._AnoExperiencia;

                param13.ParameterName = "@CantidadEmpleos";
                param13.DbType = DbType.Int32;
                param13.Value = persona._CantidadEmpleos;

                param14.ParameterName = "@CantidadDespidos";
                param14.DbType = DbType.Int32;
                param14.Value = persona._CantidadDespidos;

                param15.ParameterName = "@Idiomas";
                param15.DbType = DbType.String;
                param15.Value = persona._Idiomas;

                param16.ParameterName = "@Pasaporte";
                param16.DbType = DbType.String;
                param16.Value = persona._Pasaporte;




                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insertarPerfil";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.Parameters.Add(param8);
                comm.Parameters.Add(param9);
                comm.Parameters.Add(param10);
                comm.Parameters.Add(param11);
                comm.Parameters.Add(param12);
                comm.Parameters.Add(param13);
                comm.Parameters.Add(param14);
                comm.Parameters.Add(param15);
                comm.Parameters.Add(param16);

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
        
        public List<Perfil> Mostrar()
        {
            //Inicializamos
            List<Perfil> lista = new List<Perfil>();

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
                comm.CommandText = "MostrarPerfiles";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    Perfil persona;
                    while (dataReader.Read())
                    {
                        persona = new Perfil
                        {
                            _ID = Convert.ToInt32(dataReader["ID"].ToString()),
                            _Nombre = dataReader["Nombre"].ToString(),
                            _Cedula = Convert.ToInt32(dataReader["Cedula"].ToString()),
                            _ProfesionPrinc = dataReader["ProfesionPrinc"].ToString(),
                            _CantidadTitulos = Convert.ToInt32(dataReader["CantidadTitulos"].ToString()),
                            _ConocimientosAdic = dataReader["ConocimientoAdic"].ToString(),
                            _Telefono = Convert.ToInt32(dataReader["Telefono"].ToString()),
                            _Mail = dataReader["Mail"].ToString(),
                            _Fecha_Nacimiento = Convert.ToDateTime(dataReader["Fecha_Nacimiento"].ToString()),
                            _Residencia = dataReader["Residencia"].ToString(),
                            _Universidad = dataReader["Universidad"].ToString(),
                            _AnoGraduacion = Convert.ToDateTime(dataReader["AnoGraduacion"].ToString()),
                            _AnoExperiencia = Convert.ToInt32(dataReader["AnoExperiencia"].ToString()),
                            _CantidadEmpleos = Convert.ToInt32(dataReader["CantidadEmpleos"].ToString()),
                            _CantidadDespidos = Convert.ToInt32(dataReader["CantidadDespidos"].ToString()),
                            _Idiomas= dataReader["Idiomas"].ToString(),
                            _Pasaporte= dataReader["Pasaporte"].ToString(),
                            _IngresoSis = Convert.ToDateTime(dataReader["IngresoSis"].ToString()),
                            
                           
                        };
                        lista.Add(persona);
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
