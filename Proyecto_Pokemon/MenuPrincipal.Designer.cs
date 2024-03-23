namespace Proyecto_Pokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            BtnPartidaRapida = new Button();
            BtnTorneo = new Button();
            BtnSalir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 375);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // BtnPartidaRapida
            // 
            BtnPartidaRapida.BackColor = Color.Black;
            BtnPartidaRapida.Font = new Font("Bahnschrift SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPartidaRapida.ForeColor = Color.White;
            BtnPartidaRapida.Image = (Image)resources.GetObject("BtnPartidaRapida.Image");
            BtnPartidaRapida.Location = new Point(511, 208);
            BtnPartidaRapida.Name = "BtnPartidaRapida";
            BtnPartidaRapida.Size = new Size(282, 97);
            BtnPartidaRapida.TabIndex = 2;
            BtnPartidaRapida.UseVisualStyleBackColor = false;
            BtnPartidaRapida.UseWaitCursor = true;
            BtnPartidaRapida.Click += BtnPartidaRapida_Click;
            // 
            // BtnTorneo
            // 
            BtnTorneo.BackColor = Color.Black;
            BtnTorneo.Font = new Font("Bahnschrift SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTorneo.ForeColor = Color.White;
            BtnTorneo.Image = (Image)resources.GetObject("BtnTorneo.Image");
            BtnTorneo.Location = new Point(511, 341);
            BtnTorneo.Name = "BtnTorneo";
            BtnTorneo.Size = new Size(282, 97);
            BtnTorneo.TabIndex = 4;
            BtnTorneo.UseVisualStyleBackColor = false;
            BtnTorneo.UseWaitCursor = true;
            BtnTorneo.Click += BtnTorneo_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Black;
            BtnSalir.Font = new Font("Bahnschrift SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(511, 473);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(282, 97);
            BtnSalir.TabIndex = 5;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.UseWaitCursor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(419, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 72);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(419, 354);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 84);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(431, 486);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 84);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
           
            Controls.Add(pictureBox2);
            Controls.Add(BtnSalir);
            Controls.Add(BtnTorneo);
            
            Controls.Add(BtnPartidaRapida);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Pokemon";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnPartidaRapida;
        private Button BtnTorneo;
        private Button BtnSalir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
