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
    public partial class FrAdminMenuUpdateP : MetroFramework.Forms.MetroForm
    {
        public FrAdminMenuUpdateP()
        {
            InitializeComponent();
        }




        #region Atributos
        Perfil persona;
        #endregion

        #region Events

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrAdminMenu r = new FrAdminMenu();
            r.Visible = true;
            this.Hide();
        }

        public void init()
        {
            txtNombre.Text = "";
            (txtCedula.Text) = "";
            cbProfesion.Text = "";
            (txtCantidadTit.Text) = "";
            txtConocimientos.Text = "";
            (txtTelefono.Text) = "";
            txtCorreo.Text = "";
            cbResidencia.Text = "";
            cbUniversidad.Text = "";
            txtAnosExp.Text = "";
            txtCantidadEmpleos.Text = "";
            txtCanDespi.Text = "";
            cbIdiomas.Text = "";
            cbPasaporte.Text = "";
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
            if (e.KeyChar == (char)127) e.Handled = false;

        }


        private void AdminMenuUpdateP_Load(object sender, EventArgs e)
        {
            gAdds.DataSource = BS.MantenimientoPerfiles._Instancia.Mostrar();
            init();
        }

        private void gAdds_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gAdds.SelectedRows.Count > 0)
                {
                    int index = gAdds.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gAdds.Rows[index];
                    txtId.Text = selectedRow.Cells[0].Value.ToString();
                    txtNombre.Text = selectedRow.Cells[1].Value.ToString();
                    txtCedula.Text = selectedRow.Cells[2].Value.ToString();
                    cbProfesion.Text = selectedRow.Cells[3].Value.ToString();
                    txtCantidadTit.Text = selectedRow.Cells[4].Value.ToString();
                    txtConocimientos.Text = selectedRow.Cells[5].Value.ToString();
                    txtTelefono.Text = selectedRow.Cells[6].Value.ToString();
                    txtCorreo.Text = selectedRow.Cells[7].Value.ToString();
                    dtpFecha_Nacimiento.Value = Convert.ToDateTime(selectedRow.Cells[8].Value);
                    cbResidencia.Text = selectedRow.Cells[9].Value.ToString();
                    cbUniversidad.Text = selectedRow.Cells[10].Value.ToString();
                    dtpAnoGraduacion.Value = Convert.ToDateTime(selectedRow.Cells[11].Value);
                    txtAnosExp.Text = selectedRow.Cells[12].Value.ToString();
                    txtCantidadEmpleos.Text = selectedRow.Cells[13].Value.ToString();
                    txtCanDespi.Text = selectedRow.Cells[14].Value.ToString();
                    cbIdiomas.Text= selectedRow.Cells[15].Value.ToString();
                    cbPasaporte.Text = selectedRow.Cells[16].Value.ToString();




                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                getValues(true);
                BS.MantenimientoPerfiles._Instancia.Actualizar(persona);
                gAdds.DataSource = BS.MantenimientoPerfiles._Instancia.Mostrar();
                init();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un Error");
            }
        }

        private void gAdds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }


    



    #endregion

        #region Metodos

    //Carga datos del usuario para insertar
    private void getValues(bool update)
    {
        persona = new Perfil();
        if (update)
        {
            persona._ID = Convert.ToInt32(txtId.Text);
        }
        persona._Nombre = txtNombre.Text;
        persona._Cedula = Convert.ToInt32(txtCedula.Text);
        persona._ProfesionPrinc = cbProfesion.Text;
        persona._CantidadTitulos = Convert.ToInt32(txtCantidadTit.Text);
        persona._ConocimientosAdic = txtConocimientos.Text;
        persona._Telefono = Convert.ToInt32(txtTelefono.Text);
        persona._Mail = txtCorreo.Text;
        persona._Fecha_Nacimiento = Convert.ToDateTime(dtpFecha_Nacimiento.Text);
        persona._Residencia = cbResidencia.Text;
        persona._Universidad = cbUniversidad.Text;
        persona._AnoGraduacion = Convert.ToDateTime(dtpAnoGraduacion.Text);
        persona._AnoExperiencia = Convert.ToInt32(txtAnosExp.Text);
        persona._CantidadEmpleos = Convert.ToInt32(txtCantidadEmpleos.Text);
        persona._CantidadDespidos = Convert.ToInt32(txtCanDespi.Text);
            persona._Idiomas = cbIdiomas.Text;
            persona._Pasaporte = cbPasaporte.Text;


    }


        #endregion

       
    }
}

