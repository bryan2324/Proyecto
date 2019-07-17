using PR.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.DAL
{
    interface IMantenimientoConcursos
    {
        void Insertar(Concurso concurso);
        List<Concurso> Mostrar();
        void Actualizar(Concurso concurso);
        void Eliminar(Concurso concurso);
    }
}
