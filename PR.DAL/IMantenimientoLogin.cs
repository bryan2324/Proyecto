using PR.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.DAL
{
    interface IMantenimientoLogin
    {
        void Insertar(Usuario persona);

        List<Usuario> Login();
    }
}
