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
    public partial class FrBusquedas : MetroFramework.Forms.MetroForm
    {
        public FrBusquedas()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrMenu r = new FrMenu();
            r.Visible = true;
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrBusCedula r = new FrBusCedula();
            r.Visible = true;
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrBusUbicacion r = new FrBusUbicacion();
            r.Visible = true;
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrBusNombre r = new FrBusNombre();
            r.Visible = true;
        }

        private void btnProfesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrBusProfesion r = new FrBusProfesion();
            r.Visible = true;
        }

        private void btnUniversidad_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrBusUniversidad r = new FrBusUniversidad();
            r.Visible = true;
        }
    }
}
