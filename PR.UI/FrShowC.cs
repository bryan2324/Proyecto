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
    public partial class FrShowC : MetroFramework.Forms.MetroForm
    {
        public FrShowC()
        {
            InitializeComponent();
        }

        private void FrMenuShowC_Load(object sender, EventArgs e)
        {
            gAdds.DataSource=BS.MantenimientoConcursos._Instancia.Mostrar();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FrMenu r = new FrMenu ();
            r.Visible = true;
            this.Hide();
        }
    }
}
