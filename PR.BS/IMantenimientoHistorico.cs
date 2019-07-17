using PR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.BS
{
    interface IMantenimientoHistorico
    {
        List<RegistrosHistoricos> Show();
    }
}
