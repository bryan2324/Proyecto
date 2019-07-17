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
    public partial class FrAdminMenu : MetroFramework.Forms.MetroForm
    {
        public FrAdminMenu()
        {
            InitializeComponent();
        }

       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrLogin li = new FrLogin();
            li.Visible = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            FrAddProf d = new FrAddProf();
            d.Visible = true;
            this.Hide();
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            FrAddProf r = new FrAddProf();
            r.Visible = true;
            this.Hide();
        }

        private void bunifuTileButton1_Click_2(object sender, EventArgs e)
        {
            FrAddProf r = new FrAddProf();
            r.Visible = true;
            this.Hide();
        }

        private void btnUpdP_Click(object sender, EventArgs e)
        {
            FrAdminMenuUpdateP r = new FrAdminMenuUpdateP();
            r.Visible = true;
            this.Hide();
        }

        private void bunifuSwitch1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            FrLogin li = new FrLogin();
            li.Visible = true;
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            FrAdminMenuDeleteP r = new FrAdminMenuDeleteP();
            r.Visible = true;
            this.Hide();
        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            FrAddConcu r = new FrAddConcu();
            this.Hide();
            r.Show();
        }

        private void btnDelC_Click(object sender, EventArgs e)
        {
            FrAdminMenuDeleteC r = new FrAdminMenuDeleteC();
            r.Visible = true;
            this.Hide();
        }

        private void btnShowH_Click(object sender, EventArgs e)
        {
            FrAdminMenuRegistro r = new FrAdminMenuRegistro();
            r.Visible = true;
            this.Hide();
        }
    }
}
