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
    public partial class FrFAQ : MetroFramework.Forms.MetroForm
    {
        public FrFAQ()
        {
            InitializeComponent();
        }

        private void btnFP_Click(object sender, EventArgs e)
        {
            textArea.Text = "La funcion Principal del sistema es almacenar perfiles y concursos u oportunidades de empleo," +
                " con el fin de hacer un match entre ambos de forma rapida y sencilla";
        }

        private void btnQPer_Click(object sender, EventArgs e)
        {

            textArea.Text = "Algunas de sus funciones son:\r\n\r\n" +
                "1.Agregar Perfiles\r\n\r\n" +
                "2.Agregar Concursos\r\n\r\n" +
                "3.Hacer reportes de Tendencia\r\n\r\n" +
                "4.Hacer Relaciones entre perfiles y concursos";
        }

        private void btnTi_Click(object sender, EventArgs e)
        {
            textArea.Text = "El sistema posee 2 tipos de usuario uno administrativo para agregar" +
                "perfiles y concursos, y otro con permisos limitados a consultas";
        }

        private void btnEnfoq_Click(object sender, EventArgs e)
        {
            textArea.Text = "El sistema esta enfocado a cualquier sistema de Recursos Humanos" +
                " que busque almacenar y mantener de forma ordenada los perfiles profesionales externos e internos," +
                "y a su vez sus concursos y oportunidades de laborales";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrMenu r = new FrMenu();
            r.Visible = true;
        }
    }
}
