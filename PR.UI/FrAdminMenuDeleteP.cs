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
    public partial class FrAdminMenuDeleteP : MetroFramework.Forms.MetroForm
    {
        public FrAdminMenuDeleteP()
        {
            InitializeComponent();
        }
        Perfil persona;

        #region Eventos
        private void AdminMenuDeleteP_Load(object sender, EventArgs e)
        {
            gAdds.DataSource = BS.MantenimientoPerfiles._Instancia.Mostrar();
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
                   
                    txtCedula.Text = selectedRow.Cells[2].Value.ToString();
                   





                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("El Perfil no fue encontrado");
            }
        }



        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
            if (e.KeyChar == (char)127) e.Handled = false;

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                List<Perfil> TodaLaPeople = new List<Perfil>();
                TodaLaPeople = BS.MantenimientoPerfiles._Instancia.Mostrar();

                int largo = Convert.ToInt32(TodaLaPeople.Count.ToString());
                String exUser = txtId.Text;
                for (int i = 0; i < largo; i++)
                {

                    String user = TodaLaPeople[i]._ID.ToString();





                    if (exUser.Equals(user))
                    {
                        getValues(false);
                        BS.MantenimientoPerfiles._Instancia.Eliminar(persona);
                        gAdds.DataSource = BS.MantenimientoPerfiles._Instancia.Mostrar();
                        lbW.Visible = false;
                        i = largo + 1;
                    }
                    else
                    {
                        lbW.Visible = true;
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hubo un Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrAdminMenu r = new FrAdminMenu();
            r.Visible = true;
            this.Hide();
        }

        #endregion


        #region Metodos

        private void getValues(bool update)
        {
           DateTime f = DateTime.Now; 

            persona = new Perfil();
            persona._ID = Convert.ToInt32(txtId.Text);
            persona._Nombre ="";
            persona._Cedula = Convert.ToInt32(txtCedula.Text);
            persona._ProfesionPrinc = "";
            persona._CantidadTitulos = 0;
            persona._ConocimientosAdic = "";
            persona._Telefono = 0;
            persona._Mail = "";
            persona._Fecha_Nacimiento =f;
            persona._Residencia = "";
            persona._Universidad = "";
            persona._AnoGraduacion = f;
            persona._AnoExperiencia =1;
            persona._CantidadEmpleos = 1;
            persona._CantidadDespidos = 1;


        }

        #endregion

        
    }
}
