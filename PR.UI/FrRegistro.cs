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
    public partial class FrRegistro : Form
    {

        Usuario usuario;
        String user;
        public FrRegistro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {

                getValues(true);
                user = txtNombre.Text;
                BS.MantenimientoLogin._Instancia.Insertar(usuario);

                FrMenu m = new FrMenu();
                m._user = user;
                m.Visible = true;



                this.Close();

            }
            catch (Exception)
            {



                lbExiste.Visible = true;
            }
        }

        private void getValues(bool update)
        {
            usuario = new Usuario();
            if (update)
            {
                usuario._Username = txtUsuario.Text;
            }
            usuario._Nombre = (txtNombre.Text);
            usuario._Pass = txtPass.Text;



        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            txtPass.isPassword = false;
        }



        private void bunifuImageButton1_DoubleClick(object sender, EventArgs e)
        {
            txtPass.isPassword = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrLogin r = new FrLogin();
            r.Visible = true;
            this.Hide();
        }
    }
}
