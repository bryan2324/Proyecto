using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.DO
{
    public class Concurso
    {

        private int IdConcurso;

        public int _IdConcurso
        {
            get { return IdConcurso; }
            set { IdConcurso = value; }
        }

        private String Empresa;

        public String _Empresa
        {
            get { return Empresa; }
            set { Empresa = value; }
        }

        private String Idiomas;

        public String _Idiomas
        {
            get { return Idiomas; }
            set { Idiomas = value; }
        }

        private String Pasaporte;

        public String _Pasaporte
        {
            get { return Pasaporte; }
            set { Pasaporte = value; }
        }

        private String PuestoReq;

        public String _PuestoReq
        {
            get { return PuestoReq; }
            set { PuestoReq = value; }
        }

        private int AnoExperienciaReq;

        public int _AnoExperienciaReq
        {
            get { return AnoExperienciaReq; }
            set { AnoExperienciaReq = value; }
        }


        private String UniversidadProc;

        public String _UniversidadProc
        {
            get { return UniversidadProc; }
            set { UniversidadProc = value; }
        }

        private int Edad;

        public int _Edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        private String IngRequerida;

        public String _IngRequerida
        {
            get { return IngRequerida; }
            set { IngRequerida = value; }
        }

        private DateTime FechaInicio;

        public DateTime _FechaInicio
        {
            get { return FechaInicio; }
            set { FechaInicio = value; }
        }

        private DateTime FechaFinalizacion;

        public DateTime _FechaFinalizacion
        {
            get { return FechaFinalizacion; }
            set { FechaFinalizacion = value; }
        }


    }
}
            