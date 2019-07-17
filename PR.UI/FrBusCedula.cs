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
    public partial class FrBusCedula : MetroFramework.Forms.MetroForm
    {
        public FrBusCedula()
        {
            InitializeComponent();
        }

        private void FrBusCedula_Load(object sender, EventArgs e)
        {

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

            try
            {
                List<Perfil> BD = new List<Perfil>();
                List<Perfil> show = new List<Perfil>();


                BD = BS.MantenimientoPerfiles._Instancia.Mostrar();
                int largo = BD.Count();
                int cedula = Convert.ToInt32(txtValorBusq.Text);

                for (int i = 0; i < largo; i++)
                {
                    int cedulaBD = BD[i]._Cedula;
                    if (cedula == cedulaBD)
                    {
                        show.Add(BD[i]);
                        grRest.DataSource = show;
                        i = largo + 1;
                    }
                    else
                    {

                        grRest.DataSource = showClean;
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Revise el ID e intentelo de nuevo");
            }


            }



        #endregion

   
    }
}
