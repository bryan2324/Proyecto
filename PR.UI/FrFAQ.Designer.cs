namespace PR.UI
{
    partial class FrFAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrFAQ));
            this.textArea = new MetroFramework.Controls.MetroTextBox();
            this.btnFP = new MetroFramework.Controls.MetroButton();
            this.btnQPer = new MetroFramework.Controls.MetroButton();
            this.btnTi = new MetroFramework.Controls.MetroButton();
            this.btnEnfoq = new MetroFramework.Controls.MetroButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // textArea
            // 
            // 
            // 
            // 
            this.textArea.CustomButton.Image = null;
            this.textArea.CustomButton.Location = new System.Drawing.Point(143, 2);
            this.textArea.CustomButton.Name = "";
            this.textArea.CustomButton.Size = new System.Drawing.Size(253, 253);
            this.textArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textArea.CustomButton.TabIndex = 1;
            this.textArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textArea.CustomButton.UseSelectable = true;
            this.textArea.CustomButton.Visible = false;
            this.textArea.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textArea.Lines = new string[0];
            this.textArea.Location = new System.Drawing.Point(367, 78);
            this.textArea.MaxLength = 32767;
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.PasswordChar = '\0';
            this.textArea.ReadOnly = true;
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textArea.SelectedText = "";
            this.textArea.SelectionLength = 0;
            this.textArea.SelectionStart = 0;
            this.textArea.ShortcutsEnabled = true;
            this.textArea.Size = new System.Drawing.Size(399, 258);
            this.textArea.Style = MetroFramework.MetroColorStyle.Blue;
            this.textArea.TabIndex = 0;
            this.textArea.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textArea.UseSelectable = true;
            this.textArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textArea.WaterMarkFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnFP
            // 
            this.btnFP.Location = new System.Drawing.Point(24, 108);
            this.btnFP.Name = "btnFP";
            this.btnFP.Size = new System.Drawing.Size(270, 23);
            this.btnFP.TabIndex = 1;
            this.btnFP.Text = "¿Cual es la Funcion principal del Sistema?";
            this.btnFP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFP.UseSelectable = true;
            this.btnFP.Click += new System.EventHandler(this.btnFP_Click);
            // 
            // btnQPer
            // 
            this.btnQPer.Location = new System.Drawing.Point(23, 154);
            this.btnQPer.Name = "btnQPer";
            this.btnQPer.Size = new System.Drawing.Size(270, 23);
            this.btnQPer.TabIndex = 2;
            this.btnQPer.Text = "¿Que permite hacer?";
            this.btnQPer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnQPer.UseSelectable = true;
            this.btnQPer.Click += new System.EventHandler(this.btnQPer_Click);
            // 
            // btnTi
            // 
            this.btnTi.Location = new System.Drawing.Point(24, 215);
            this.btnTi.Name = "btnTi";
            this.btnTi.Size = new System.Drawing.Size(270, 23);
            this.btnTi.TabIndex = 3;
            this.btnTi.Text = "¿Cuantos tipos de usuario tiene?";
            this.btnTi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTi.UseSelectable = true;
            this.btnTi.Click += new System.EventHandler(this.btnTi_Click);
            // 
            // btnEnfoq
            // 
            this.btnEnfoq.Location = new System.Drawing.Point(24, 275);
            this.btnEnfoq.Name = "btnEnfoq";
            this.btnEnfoq.Size = new System.Drawing.Size(270, 23);
            this.btnEnfoq.TabIndex = 5;
            this.btnEnfoq.Text = "¿Hacia quien esta enfocado el sistema?";
            this.btnEnfoq.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEnfoq.UseSelectable = true;
            this.btnEnfoq.Click += new System.EventHandler(this.btnEnfoq_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(24, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 43);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 93;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEnfoq);
            this.Controls.Add(this.btnTi);
            this.Controls.Add(this.btnQPer);
            this.Controls.Add(this.btnFP);
            this.Controls.Add(this.textArea);
            this.MaximizeBox = false;
            this.Name = "FrFAQ";
            this.Resizable = false;
            this.Text = "FAQ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textArea;
        private MetroFramework.Controls.MetroButton btnFP;
        private MetroFramework.Controls.MetroButton btnQPer;
        private MetroFramework.Controls.MetroButton btnTi;
        private MetroFramework.Controls.MetroButton btnEnfoq;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
    }
}