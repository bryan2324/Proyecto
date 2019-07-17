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
    public class MantenimientoLogin:IMantenimientoLogin
    {
        private static MantenimientoLogin Instancia;

        public static MantenimientoLogin _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new MantenimientoLogin();
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

       
        public void Insertar(Usuario persona)
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


                param1.ParameterName = "@nombre";
                param1.DbType = DbType.String;
                param1.Value = persona._Nombre;

                param2.ParameterName = "@username";
                param2.DbType = DbType.String;
                param2.Value = persona._Username;

                param3.ParameterName = "@pass";
                param3.DbType = DbType.String;
                param3.Value = persona._Pass;


                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insertarUsuario";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
 
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

        public List<Usuario> Login()
        {
            //Inicializamos
            List<Usuario> lista = new List<Usuario>();

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
                comm.CommandText = "LoginInfo";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    Usuario persona;
                    while (dataReader.Read())
                    {
                        persona = new Usuario
                        {
                            _Nombre = dataReader["nombre"].ToString(),
                            _Username = dataReader["username"].ToString(),
                            _Pass = dataReader["pass"].ToString()
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
