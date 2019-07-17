using PR.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.DAL
{
    interface IMantenimientoPerfiles
    {
        void Insertar(Perfil persona);
        List<Perfil> Mostrar();
        void Actualizar(Perfil persona);
        void Eliminar(Perfil persona);
    }
}
