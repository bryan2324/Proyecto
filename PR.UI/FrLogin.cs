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
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        #region Atributos
        String usuario;
        #endregion

        #region Events



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> TodaLaPeople = new List<Usuario>();
                TodaLaPeople = BS.MantenimientoLogin._Instancia.Login();

                int largo = Convert.ToInt32(TodaLaPeople.Count.ToString());

                for (int i = 0; i < largo; i++)
                {
                    String user = TodaLaPeople[i]._Username.ToString();
                    String pass = TodaLaPeople[i]._Pass.ToString();
                    String exUser = txtUsuario.Text;
                    String exPass = txtPass.Text;


                    if (exUser.Equals(user) && exPass.Equals(pass))
                    {
                        if (exUser.Equals("admin"))
                        {
                            FrAdminMenu AM = new FrAdminMenu();
                            AM.Visible = true;
                            this.Hide();

                        }
                        else {
                            FrMenu re = new FrMenu();



                            usuario = TodaLaPeople[i]._Nombre.ToString();
                            re._user = usuario;
                            this.Hide();
                            re.Show();
                        }
                    }
                    else {
                        lbIncorrecto.Visible = true;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }







        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrRegistro re = new FrRegistro();

            this.Hide();
            re.Show();
        }

        private void lbIncorrecto_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            txtPass.isPassword = false;
        }

        
      
        private void bunifuImageButton1_DoubleClick(object sender, EventArgs e)
        {
            txtPass.isPassword = true;
        }
    } }
