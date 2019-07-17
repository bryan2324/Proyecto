using PR.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR.UI
{
    public partial class FrMenu : MetroFramework.Forms.MetroForm
    {



        private static String user;

        public  String _user
        {
            get { return user; }
            set { user = value; }
        }

        private String ProfBuscar;

        public String _ProfBuscar
        {
            get { return ProfBuscar; }
            set { ProfBuscar = value; }
        }

        public FrMenu()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrLogin li = new FrLogin();
            li.Visible = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            lbUser.Text = (_user);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            FrShowP r = new FrShowP();
            r.Visible = true;
            this.Hide();
        }

        private void bunifuSwitch1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            FrLogin li = new FrLogin();
            li.Visible = true;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrShowC r = new FrShowC();
            r.Visible = true;
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrRelaciones r = new FrRelaciones();
            r.Visible = true;
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            FrBusquedas r = new FrBusquedas();
            r.Visible = true;
            this.Hide();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            FrFAQ r = new FrFAQ();
            r.Visible = true;
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            List<Concurso> lista = new List<Concurso>();
            lista = BS.MantenimientoConcursos._Instancia.Mostrar();
            int IngrSistemas = 0, IngrCivil = 0, IngrElectrico = 0, IngrElectromecanico = 0, IngrElectronico = 0, IngrIndustrial = 0;
            int Largo = lista.Count();
            String busqueda;
            int mayor = 0;

            for (int i = 0; i < Largo; i++)
            {
                busqueda = lista[i]._IngRequerida.ToString();

                if (busqueda.Equals("Ing.Sistemas"))
                {
                    IngrSistemas++;
                    
                }
                else if (busqueda.Equals("Ing.Civil"))
                {
                    IngrCivil++;
                }
                else if (busqueda.Equals("Ing.Electrico"))
                {
                    IngrElectrico++;
                }
                else if (busqueda.Equals("Ing.Electromecanico"))
                {
                    IngrElectromecanico++;
                }
                else if (busqueda.Equals("Ing.Electronico"))
                {
                    IngrElectronico++;
                }
                else if (busqueda.Equals("Ing.Industrial"))
                {
                    IngrIndustrial++;
                }

                if (IngrCivil > mayor)
                {
                    mayor = IngrCivil;
                    _ProfBuscar = "Ing.Civil";

                }
                else if (IngrElectrico > mayor)
                {
                    mayor = IngrElectrico;
                    _ProfBuscar = "Ing.Electrico";

                }
                else if (IngrElectromecanico >mayor)
                {
                    mayor = IngrElectromecanico;
                    _ProfBuscar = "Ing.Electromecanico";
                }
                else if (IngrElectronico > mayor)
                {
                    mayor= IngrElectronico;
                    _ProfBuscar = "Ing.Electronico";

                }
                else if (IngrIndustrial > mayor)
                {
                    mayor = IngrIndustrial;
                    _ProfBuscar = "Ing.Industrial";
                }
                else if (IngrSistemas > mayor)
                {
                    mayor = IngrSistemas;
                    _ProfBuscar = "Ing.Sistemas";
                }
            }


            MessageBox.Show("La tendencia ha sido enviada al administrador");
            //////////////////////////////////////////////////////////////////////////////

            string yourId = "oqZaBZex5keG/pEIUHi0Y2JyeWFuZ2MyM19hdF9ob3RtYWlsX2RvdF9jb20=";
            string yourMobile= "+50683880575";
            string mensaje = "La Ing que tiene mas concursos actualmente es: " + _ProfBuscar;

            try
            {
                string url = "https://NiceApi.net/API";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Add("X-APIId", yourId);
                request.Headers.Add("X-APIMobile", yourMobile);

                using (StreamWriter streamOut = new StreamWriter(request.GetRequestStream()))
                {
                    streamOut.Write(mensaje);
                }
                using (StreamReader streamIn = new StreamReader(request.GetResponse().GetResponseStream()))
                {
                    Console.WriteLine(streamIn.ReadToEnd());
                }
            }
            catch (Exception se)
            {

                Console.WriteLine(se.Message);
            }
            Console.ReadLine();
        }
    }
}