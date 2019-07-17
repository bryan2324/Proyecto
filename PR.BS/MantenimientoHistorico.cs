using PR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PR.BS
{
   public class MantenimientoHistorico
    {
        private static MantenimientoHistorico Instancia;

        public static MantenimientoHistorico _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new MantenimientoHistorico();
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

        public List<RegistrosHistoricos> Show()
        {
            List<RegistrosHistoricos> lista = new List<RegistrosHistoricos>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.MantenimientoHistorico._Instancia.Show();
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
