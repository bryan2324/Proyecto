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
    public partial class FrAdminMenuDeleteC : MetroFramework.Forms.MetroForm
    {
        public FrAdminMenuDeleteC()
        {
            InitializeComponent();
        }

        #region Atributos
        Concurso concurso;
        #endregion

        #region Eventos

        private void FrAdminMenuDeleteC_Load(object sender, EventArgs e)
        {
            gAdds.DataSource = BS.MantenimientoConcursos._Instancia.Mostrar();
        }

        private void gAdds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gAdds.DataSource = BS.MantenimientoConcursos._Instancia.Mostrar();
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

                 

                }
            }
            catch (Exception ee)
            {

                throw;
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
                {
                    List<Concurso> TodaLaPeople = new List<Concurso>();
                    TodaLaPeople = BS.MantenimientoConcursos._Instancia.Mostrar();
                
                    int largo = Convert.ToInt32(TodaLaPeople.Count.ToString());
                    
                   
                    String IdConcursoFR = txtId.Text;
                    

                    for (int i = 0; i < largo; i++)
                    {
                        
                        String idConcursoBD = TodaLaPeople[i]._IdConcurso.ToString();

                        if (idConcursoBD.Equals(IdConcursoFR))
                        {

                            getValues(false);
                            BS.MantenimientoConcursos._Instancia.Eliminar(concurso);
                            gAdds.DataSource = BS.MantenimientoConcursos._Instancia.Mostrar();
                            lbW.Visible = false;
                          
                            i = largo + 1;
                        }
                        else {
                            lbW.Visible = true;
                        }
                        


                    }
                
                    

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Concurso no encontrado");
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

            concurso = new Concurso ();
            concurso._IdConcurso = Convert.ToInt32(txtId.Text);

            concurso._Empresa ="";
            concurso._Idiomas = "";
            concurso._Pasaporte = "";
            concurso._PuestoReq = "";
            concurso._AnoExperienciaReq = 0;
            concurso._UniversidadProc = "";
            concurso._Edad = 0;
            concurso._IngRequerida = "";
            concurso._FechaFinalizacion = f;
            


        }




        #endregion

   
    }
}
