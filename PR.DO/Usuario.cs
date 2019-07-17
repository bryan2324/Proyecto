using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.DO
{
    public class Usuario
    {
        private String Nombre;

        public String _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }


        private String Username;
            
        public String _Username
        {
            get { return Username; }
            set { Username = value; }
        }

        private String Pass;

        public String _Pass
        {
            get { return Pass; }
            set { Pass = value; }
        }


    }
}
