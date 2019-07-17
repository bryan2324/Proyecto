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
    public partial class FrAdminMenuRegistro : MetroFramework.Forms.MetroForm
    {
        public FrAdminMenuRegistro()
        {
            InitializeComponent();
        }

        private void FrAdminMenuRegistro_Load(object sender, EventArgs e)
        {
            gAdds.DataSource = BS.MantenimientoHistorico._Instancia.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrAdminMenu r = new FrAdminMenu();
            r.Visible = true;
            this.Hide();
        }
    }
}
