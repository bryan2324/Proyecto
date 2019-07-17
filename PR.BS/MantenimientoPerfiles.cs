using PR.DO;
using PR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PR.BS
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
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.MantenimientoPerfiles._Instancia.Actualizar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Perfil persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.MantenimientoPerfiles._Instancia.Eliminar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Perfil persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.MantenimientoPerfiles._Instancia.Insertar(persona);
                    scope.Complete();
                   
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Perfil> Mostrar()
        {
            List<Perfil> lista = new List<Perfil>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.MantenimientoPerfiles._Instancia.Mostrar();
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
