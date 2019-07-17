using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR.DO;
namespace PR.BS
{
    interface IMantenimientoPerfiles
    {
        void Insertar(Perfil persona);
        List<Perfil> Mostrar();
        void Actualizar(Perfil persona);
        void Eliminar(Perfil persona);

    }
}
