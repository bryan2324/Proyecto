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
    public partial class FrRelaciones : MetroFramework.Forms.MetroForm
    {
        public FrRelaciones()
        {
            InitializeComponent();
        }

        static String txtIdiomas, txtPasaporte,txtUniversidadProc, txtIngRequerida;
        static int intAnoExperienciaReq;
        

        #region Eventos
        private void FrRelaciones_Load(object sender, EventArgs e)
        {
            grCC.DataSource = BS.MantenimientoConcursos._Instancia.Mostrar();
           

        }

    
        public void cargarDatos() {

         

            

        }

        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrMenu r = new FrMenu();
            r.Visible = true;
        }

        private void cbConcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void grCC_SelectionChanged(object sender, EventArgs e)
        {
            
            try
            {

                if (grCC.SelectedRows.Count > 0)
                {
                    
                    int index = grCC.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = grCC.Rows[index];

                    txtIdiomas = selectedRow.Cells[2].Value.ToString();
                    txtPasaporte= selectedRow.Cells[3].Value.ToString();
                    txtUniversidadProc= selectedRow.Cells[6].Value.ToString();
                    txtIngRequerida= selectedRow.Cells[8].Value.ToString();
                    intAnoExperienciaReq = Convert.ToInt32(selectedRow.Cells[5].Value.ToString());
                    
                    
                  
                    muestraOpciones();

                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }


        public void muestraOpciones() {
            try
            {

                List<Perfil> opciones = new List<Perfil>();
                List<Perfil> opcionesVacio = new List<Perfil>();
                String RtxtIdiomas, RtxtPasaporte, RtxtUniversidadProc, RtxtIngRequerida;
                int RintAnoExperienciaReq;

                List<Perfil> BD = new List<Perfil>();


                BD = BS.MantenimientoPerfiles._Instancia.Mostrar();
                int largo = BD.Count();
                for (int i = 0; i < largo; i++)
                {

                    RtxtIdiomas = BD[i]._Idiomas;
                    RtxtPasaporte = BD[i]._Pasaporte;
                    RtxtUniversidadProc = BD[i]._Universidad;
                    RtxtIngRequerida = BD[i]._ProfesionPrinc;
                    RintAnoExperienciaReq = BD[i]._AnoExperiencia;

                    if (RtxtIdiomas.Equals(txtIdiomas) && RtxtPasaporte.Equals(txtPasaporte)
                        && RtxtUniversidadProc.Equals(txtUniversidadProc) && RtxtIngRequerida.Equals(txtIngRequerida)
                        && RintAnoExperienciaReq >= intAnoExperienciaReq)
                    {

                        opciones.Add(BD[i]);
                        grPP.DataSource = opciones;
                        i = largo + 1;
                    }
                    else
                    {
                        grPP.DataSource = opcionesVacio;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Algo salio mal");
            }

        }

    }
}
