namespace PR.UI
{
    partial class FrAddConcu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrAddConcu));
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtAnosExpR = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.gAdds = new MetroFramework.Controls.MetroGrid();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dtpFinalizacion = new MetroFramework.Controls.MetroDateTime();
            this.cbUniversidadR = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cbIdiomasR = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cbProfesionR = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtEdad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtPuestoReq = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.cbPasaporte = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gAdds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-12, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 104;
            this.label1.Text = "Agregar Perfiles";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(519, 91);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(197, 19);
            this.metroLabel15.TabIndex = 103;
            this.metroLabel15.Text = "Años de Experiencia Requeridos";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAnosExpR
            // 
            // 
            // 
            // 
            this.txtAnosExpR.CustomButton.Image = null;
            this.txtAnosExpR.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtAnosExpR.CustomButton.Name = "";
            this.txtAnosExpR.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAnosExpR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnosExpR.CustomButton.TabIndex = 1;
            this.txtAnosExpR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnosExpR.CustomButton.UseSelectable = true;
            this.txtAnosExpR.CustomButton.Visible = false;
            this.txtAnosExpR.Lines = new string[0];
            this.txtAnosExpR.Location = new System.Drawing.Point(520, 113);
            this.txtAnosExpR.MaxLength = 32767;
            this.txtAnosExpR.Name = "txtAnosExpR";
            this.txtAnosExpR.PasswordChar = '\0';
            this.txtAnosExpR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnosExpR.SelectedText = "";
            this.txtAnosExpR.SelectionLength = 0;
            this.txtAnosExpR.SelectionStart = 0;
            this.txtAnosExpR.ShortcutsEnabled = true;
            this.txtAnosExpR.Size = new System.Drawing.Size(251, 23);
            this.txtAnosExpR.TabIndex = 102;
            this.txtAnosExpR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAnosExpR.UseSelectable = true;
            this.txtAnosExpR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnosExpR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnosExpR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(599, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAdd.TabIndex = 101;
            this.btnAdd.Text = "Agregar Concurso";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gAdds
            // 
            this.gAdds.AllowUserToOrderColumns = true;
            this.gAdds.AllowUserToResizeRows = false;
            this.gAdds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gAdds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gAdds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gAdds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gAdds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gAdds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gAdds.DefaultCellStyle = dataGridViewCellStyle2;
            this.gAdds.EnableHeadersVisualStyles = false;
            this.gAdds.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gAdds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gAdds.Location = new System.Drawing.Point(457, 178);
            this.gAdds.Name = "gAdds";
            this.gAdds.ReadOnly = true;
            this.gAdds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gAdds.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gAdds.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gAdds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gAdds.Size = new System.Drawing.Size(419, 206);
            this.gAdds.TabIndex = 100;
            this.gAdds.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(520, 26);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(214, 19);
            this.metroLabel13.TabIndex = 97;
            this.metroLabel13.Text = "Fecha de Finalizacion del Concurso";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpFinalizacion
            // 
            this.dtpFinalizacion.Location = new System.Drawing.Point(520, 48);
            this.dtpFinalizacion.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFinalizacion.Name = "dtpFinalizacion";
            this.dtpFinalizacion.Size = new System.Drawing.Size(251, 29);
            this.dtpFinalizacion.TabIndex = 96;
            this.dtpFinalizacion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbUniversidadR
            // 
            this.cbUniversidadR.FormattingEnabled = true;
            this.cbUniversidadR.ItemHeight = 23;
            this.cbUniversidadR.Items.AddRange(new object[] {
            "UNED",
            "TEC",
            "UCR",
            "Fidélitas",
            "Latina",
            "Hispanoamericana",
            "Ulacit",
            "UAM",
            "Otra Privada"});
            this.cbUniversidadR.Location = new System.Drawing.Point(41, 305);
            this.cbUniversidadR.Name = "cbUniversidadR";
            this.cbUniversidadR.Size = new System.Drawing.Size(134, 29);
            this.cbUniversidadR.Style = MetroFramework.MetroColorStyle.Black;
            this.cbUniversidadR.TabIndex = 95;
            this.cbUniversidadR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbUniversidadR.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(41, 283);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(131, 19);
            this.metroLabel12.TabIndex = 94;
            this.metroLabel12.Text = "Universidad Deseada";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbIdiomasR
            // 
            this.cbIdiomasR.FormattingEnabled = true;
            this.cbIdiomasR.ItemHeight = 23;
            this.cbIdiomasR.Items.AddRange(new object[] {
            "Ingles",
            "Frances",
            "Aleman",
            "Mandarin",
            "Ruso",
            "Japones",
            "No Requerido"});
            this.cbIdiomasR.Location = new System.Drawing.Point(215, 178);
            this.cbIdiomasR.Name = "cbIdiomasR";
            this.cbIdiomasR.Size = new System.Drawing.Size(134, 29);
            this.cbIdiomasR.Style = MetroFramework.MetroColorStyle.Black;
            this.cbIdiomasR.TabIndex = 93;
            this.cbIdiomasR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbIdiomasR.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(215, 156);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(106, 19);
            this.metroLabel11.TabIndex = 92;
            this.metroLabel11.Text = "Segundo Idioma";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbProfesionR
            // 
            this.cbProfesionR.FormattingEnabled = true;
            this.cbProfesionR.ItemHeight = 23;
            this.cbProfesionR.Items.AddRange(new object[] {
            "Ing.Sistemas",
            "Ing.Civil",
            "Ing.Electrico",
            "Ing.Electromecanico",
            "Ing.Electronico",
            "Ing.Industrial"});
            this.cbProfesionR.Location = new System.Drawing.Point(215, 236);
            this.cbProfesionR.Name = "cbProfesionR";
            this.cbProfesionR.Size = new System.Drawing.Size(134, 29);
            this.cbProfesionR.Style = MetroFramework.MetroColorStyle.Black;
            this.cbProfesionR.TabIndex = 91;
            this.cbProfesionR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbProfesionR.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(39, 208);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(39, 19);
            this.metroLabel8.TabIndex = 88;
            this.metroLabel8.Text = "Edad";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEdad
            // 
            // 
            // 
            // 
            this.txtEdad.CustomButton.Image = null;
            this.txtEdad.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtEdad.CustomButton.Name = "";
            this.txtEdad.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtEdad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdad.CustomButton.TabIndex = 1;
            this.txtEdad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdad.CustomButton.UseSelectable = true;
            this.txtEdad.CustomButton.Visible = false;
            this.txtEdad.Lines = new string[0];
            this.txtEdad.Location = new System.Drawing.Point(40, 236);
            this.txtEdad.MaxLength = 32767;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.ShortcutsEnabled = true;
            this.txtEdad.Size = new System.Drawing.Size(134, 29);
            this.txtEdad.TabIndex = 87;
            this.txtEdad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtEdad.UseSelectable = true;
            this.txtEdad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(40, 150);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(113, 19);
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Puesto Requerido";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPuestoReq
            // 
            // 
            // 
            // 
            this.txtPuestoReq.CustomButton.Image = null;
            this.txtPuestoReq.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtPuestoReq.CustomButton.Name = "";
            this.txtPuestoReq.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPuestoReq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPuestoReq.CustomButton.TabIndex = 1;
            this.txtPuestoReq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPuestoReq.CustomButton.UseSelectable = true;
            this.txtPuestoReq.CustomButton.Visible = false;
            this.txtPuestoReq.Lines = new string[0];
            this.txtPuestoReq.Location = new System.Drawing.Point(40, 178);
            this.txtPuestoReq.MaxLength = 32767;
            this.txtPuestoReq.Name = "txtPuestoReq";
            this.txtPuestoReq.PasswordChar = '\0';
            this.txtPuestoReq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPuestoReq.SelectedText = "";
            this.txtPuestoReq.SelectionLength = 0;
            this.txtPuestoReq.SelectionStart = 0;
            this.txtPuestoReq.ShortcutsEnabled = true;
            this.txtPuestoReq.Size = new System.Drawing.Size(134, 29);
            this.txtPuestoReq.TabIndex = 85;
            this.txtPuestoReq.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPuestoReq.UseSelectable = true;
            this.txtPuestoReq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPuestoReq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(215, 214);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 19);
            this.metroLabel4.TabIndex = 80;
            this.metroLabel4.Text = "Profesion Requerida";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 79;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 77;
            this.metroLabel2.Text = "Empresa";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmpresa
            // 
            // 
            // 
            // 
            this.txtEmpresa.CustomButton.Image = null;
            this.txtEmpresa.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtEmpresa.CustomButton.Name = "";
            this.txtEmpresa.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpresa.CustomButton.TabIndex = 1;
            this.txtEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpresa.CustomButton.UseSelectable = true;
            this.txtEmpresa.CustomButton.Visible = false;
            this.txtEmpresa.Lines = new string[0];
            this.txtEmpresa.Location = new System.Drawing.Point(40, 113);
            this.txtEmpresa.MaxLength = 32767;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.PasswordChar = '\0';
            this.txtEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpresa.SelectedText = "";
            this.txtEmpresa.SelectionLength = 0;
            this.txtEmpresa.SelectionStart = 0;
            this.txtEmpresa.ShortcutsEnabled = true;
            this.txtEmpresa.Size = new System.Drawing.Size(134, 29);
            this.txtEmpresa.TabIndex = 76;
            this.txtEmpresa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtEmpresa.UseSelectable = true;
            this.txtEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPasaporte
            // 
            this.cbPasaporte.FormattingEnabled = true;
            this.cbPasaporte.ItemHeight = 23;
            this.cbPasaporte.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbPasaporte.Location = new System.Drawing.Point(215, 113);
            this.cbPasaporte.Name = "cbPasaporte";
            this.cbPasaporte.Size = new System.Drawing.Size(134, 29);
            this.cbPasaporte.Style = MetroFramework.MetroColorStyle.Black;
            this.cbPasaporte.TabIndex = 110;
            this.cbPasaporte.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbPasaporte.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(215, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 109;
            this.metroLabel1.Text = "Pasaporte al Día";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(40, 446);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 43);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 108;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrAddConcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 542);
            this.Controls.Add(this.cbPasaporte);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.txtAnosExpR);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gAdds);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.dtpFinalizacion);
            this.Controls.Add(this.cbUniversidadR);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.cbIdiomasR);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.cbProfesionR);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtPuestoReq);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtEmpresa);
            this.MaximizeBox = false;
            this.Name = "FrAddConcu";
            this.Resizable = false;
            this.Text = "Agregar Concursos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrAddConcu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gAdds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Label lbW;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtAnosExpR;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroGrid gAdds;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroDateTime dtpFinalizacion;
        private MetroFramework.Controls.MetroComboBox cbUniversidadR;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox cbIdiomasR;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cbProfesionR;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtEdad;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtPuestoReq;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtEmpresa;
        private MetroFramework.Controls.MetroComboBox cbPasaporte;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}