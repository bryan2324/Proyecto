using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.DAL
{
   public class MantenimientoHistorico:IMantenimientoHistorico
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
            //Inicializamos
            List<RegistrosHistoricos> lista = new List<RegistrosHistoricos>();

            try
            {
                ProyectoEntities entities = new ProyectoEntities();
                lista = entities.RegistrosHistoricos.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
