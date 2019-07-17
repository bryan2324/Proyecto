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
    public partial class FrAddConcu : MetroFramework.Forms.MetroForm
    {
        public FrAddConcu()
        {
            InitializeComponent();
        }



        #region Atributos
        Concurso concurso;
        #endregion

        #region Events


        private void FrAddConcu_Load(object sender, EventArgs e)
        {
            gAdds.DataSource = BS.MantenimientoConcursos._Instancia.Mostrar();
            init();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
            if (e.KeyChar == (char)127) e.Handled = false;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
            
                    getValues(true);
                    BS.MantenimientoConcursos._Instancia.Insertar(concurso);
                    gAdds.DataSource = BS.MantenimientoConcursos._Instancia.Mostrar();
                init();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa los datos Insertados");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrAdminMenu r = new FrAdminMenu();
            r.Visible = true;
            this.Hide();
        }

        public void init() {
            txtEmpresa.Text="";
           cbIdiomasR.Text = "";
            cbPasaporte.Text = "";
            txtPuestoReq.Text = "";
            txtAnosExpR.Text = "";
           cbUniversidadR.Text = "";
            txtEdad.Text = "";
           cbProfesionR.Text = "";

        

        }

        #endregion

        #region Metodos

        //Carga datos del usuario para insertar
        private void getValues(bool update)
        {
            concurso = new Concurso();

            concurso._Empresa = txtEmpresa.Text;
            concurso._Idiomas = cbIdiomasR.Text;
            concurso._Pasaporte = cbPasaporte.Text;
            concurso._PuestoReq = txtPuestoReq.Text;
            concurso._AnoExperienciaReq= Convert.ToInt32(txtAnosExpR.Text);
            concurso._UniversidadProc = cbUniversidadR.Text;
            concurso._Edad = Convert.ToInt32(txtEdad.Text);
            concurso._IngRequerida = cbProfesionR.Text;
            concurso._FechaFinalizacion = Convert.ToDateTime(dtpFinalizacion.Text);
        }



        #endregion

     


    }
}
