using PR.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PR.BS
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
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.MantenimientoConcursos._Instancia.Actualizar(concurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Concurso concurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.MantenimientoConcursos._Instancia.Eliminar(concurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Concurso concurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.MantenimientoConcursos._Instancia.Insertar(concurso);
                    scope.Complete();

                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Concurso> Mostrar()
        {
            List<Concurso> lista = new List<Concurso>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.MantenimientoConcursos._Instancia.Mostrar();
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
