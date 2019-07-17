using PR.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR.UI
{
    public partial class FrBusUniversidad : MetroFramework.Forms.MetroForm
    {
        public FrBusUniversidad()
        {
            InitializeComponent();
        }

        #region Atributos
        List<Perfil> showClean = new List<Perfil>();

        #endregion

        #region Eventos


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrBusquedas r = new FrBusquedas();
            r.Visible = true;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Perfil> BD = new List<Perfil>();
            List<Perfil> show = new List<Perfil>();


            BD = BS.MantenimientoPerfiles._Instancia.Mostrar();
            int largo = BD.Count();
            String cedula = cbValorBuscar.Text;

            for (int i = 0; i < largo; i++)
            {
                String cedulaBD = BD[i]._Universidad;
                if (cedula.Equals(cedulaBD))
                {
                    show.Add(BD[i]);


                }
                else
                {

                    grRest.DataSource = showClean;
                }

            }
            grRest.DataSource = show;
        }



        #endregion

    }
}
