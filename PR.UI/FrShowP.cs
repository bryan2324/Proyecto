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
    public partial class FrShowP : MetroFramework.Forms.MetroForm
    {
        public FrShowP()
        {
            InitializeComponent();
        }

        private void MenuShow_Load(object sender, EventArgs e)
        {
            gAdds.DataSource = BS.MantenimientoPerfiles._Instancia.Mostrar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrMenu r = new FrMenu();
            r.Visible = true;
            this.Hide();
        }
    }
}
