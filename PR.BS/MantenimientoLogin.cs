using PR.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PR.BS
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
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.MantenimientoLogin._Instancia.Insertar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
              

           
            }
        }


        public List<Usuario> Login()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.MantenimientoLogin._Instancia.Login();
                    scope.Complete();
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
