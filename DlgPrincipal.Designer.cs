namespace POO23A_ACCU
{
    partial class DlgPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlInferior = new System.Windows.Forms.Panel();
            this.LblSubTitulo = new System.Windows.Forms.Label();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.PbxPractica1 = new System.Windows.Forms.PictureBox();
            this.BtnPruebas1 = new System.Windows.Forms.Button();
            this.PbxPractica2 = new System.Windows.Forms.PictureBox();
            this.PbxPractica3 = new System.Windows.Forms.PictureBox();
            this.PbxBall8 = new System.Windows.Forms.PictureBox();
            this.PnlSuperior.SuspendLayout();
            this.PnlInferior.SuspendLayout();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPractica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPractica2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPractica3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBall8)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlSuperior.Controls.Add(this.LblCerrar);
            this.PnlSuperior.Controls.Add(this.BtnCerrar);
            this.PnlSuperior.Controls.Add(this.LblTitulo);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(445, 100);
            this.PnlSuperior.TabIndex = 1;
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.ForeColor = System.Drawing.Color.Red;
            this.LblCerrar.Location = new System.Drawing.Point(409, 34);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(27, 13);
            this.LblCerrar.TabIndex = 2;
            this.LblCerrar.Text = "Salir";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.BackgroundImage = global::POO23A_ACCU.Properties.Resources.pink_2490076_960_720;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.Location = new System.Drawing.Point(412, 10);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            this.BtnCerrar.MouseEnter += new System.EventHandler(this.BtnCerrar_MouseEnter);
            this.BtnCerrar.MouseLeave += new System.EventHandler(this.BtnCerrar_MouseLeave);
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Freestyle Script", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(445, 100);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Portafolio";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlInferior
            // 
            this.PnlInferior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlInferior.Controls.Add(this.LblSubTitulo);
            this.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlInferior.Location = new System.Drawing.Point(0, 652);
            this.PnlInferior.Name = "PnlInferior";
            this.PnlInferior.Size = new System.Drawing.Size(445, 58);
            this.PnlInferior.TabIndex = 7;
            // 
            // LblSubTitulo
            // 
            this.LblSubTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSubTitulo.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblSubTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblSubTitulo.Name = "LblSubTitulo";
            this.LblSubTitulo.Size = new System.Drawing.Size(445, 58);
            this.LblSubTitulo.TabIndex = 0;
            this.LblSubTitulo.Text = "¡Bienvenido!";
            this.LblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlCentral.BackgroundImage = global::POO23A_ACCU.Properties.Resources.Librero_2;
            this.PnlCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCentral.Controls.Add(this.PbxPractica1);
            this.PnlCentral.Controls.Add(this.BtnPruebas1);
            this.PnlCentral.Controls.Add(this.PbxPractica2);
            this.PnlCentral.Controls.Add(this.PbxPractica3);
            this.PnlCentral.Controls.Add(this.PbxBall8);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(0, 100);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(445, 552);
            this.PnlCentral.TabIndex = 8;
            // 
            // PbxPractica1
            // 
            this.PbxPractica1.BackColor = System.Drawing.Color.Transparent;
            this.PbxPractica1.BackgroundImage = global::POO23A_ACCU.Properties.Resources.Libro4_3;
            this.PbxPractica1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPractica1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxPractica1.Location = new System.Drawing.Point(113, 134);
            this.PbxPractica1.Name = "PbxPractica1";
            this.PbxPractica1.Size = new System.Drawing.Size(17, 52);
            this.PbxPractica1.TabIndex = 2;
            this.PbxPractica1.TabStop = false;
            this.PbxPractica1.Click += new System.EventHandler(this.PbxPractica1_Click);
            this.PbxPractica1.MouseEnter += new System.EventHandler(this.PbxPractica1_MouseEnter);
            this.PbxPractica1.MouseLeave += new System.EventHandler(this.PbxPractica1_MouseLeave);
            // 
            // BtnPruebas1
            // 
            this.BtnPruebas1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPruebas1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPruebas1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPruebas1.Location = new System.Drawing.Point(370, 521);
            this.BtnPruebas1.Name = "BtnPruebas1";
            this.BtnPruebas1.Size = new System.Drawing.Size(63, 25);
            this.BtnPruebas1.TabIndex = 1;
            this.BtnPruebas1.Text = "Maximizar";
            this.BtnPruebas1.UseVisualStyleBackColor = false;
            this.BtnPruebas1.Click += new System.EventHandler(this.BtnPruebas1_Click);
            this.BtnPruebas1.MouseEnter += new System.EventHandler(this.BtnPruebas1_MouseEnter);
            this.BtnPruebas1.MouseLeave += new System.EventHandler(this.BtnPruebas1_MouseLeave);
            // 
            // PbxPractica2
            // 
            this.PbxPractica2.BackColor = System.Drawing.Color.Transparent;
            this.PbxPractica2.BackgroundImage = global::POO23A_ACCU.Properties.Resources.Libro2_3;
            this.PbxPractica2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPractica2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxPractica2.Location = new System.Drawing.Point(258, 290);
            this.PbxPractica2.Name = "PbxPractica2";
            this.PbxPractica2.Size = new System.Drawing.Size(19, 52);
            this.PbxPractica2.TabIndex = 3;
            this.PbxPractica2.TabStop = false;
            this.PbxPractica2.Click += new System.EventHandler(this.PbxPractica2_Click);
            this.PbxPractica2.MouseEnter += new System.EventHandler(this.PbxPractica2_MouseEnter);
            this.PbxPractica2.MouseLeave += new System.EventHandler(this.PbxPractica2_MouseLeave);
            // 
            // PbxPractica3
            // 
            this.PbxPractica3.BackColor = System.Drawing.Color.Transparent;
            this.PbxPractica3.BackgroundImage = global::POO23A_ACCU.Properties.Resources.Libro1_2;
            this.PbxPractica3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxPractica3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxPractica3.Location = new System.Drawing.Point(218, 365);
            this.PbxPractica3.Name = "PbxPractica3";
            this.PbxPractica3.Size = new System.Drawing.Size(19, 52);
            this.PbxPractica3.TabIndex = 4;
            this.PbxPractica3.TabStop = false;
            this.PbxPractica3.MouseEnter += new System.EventHandler(this.PbxPractica3_MouseEnter);
            this.PbxPractica3.MouseLeave += new System.EventHandler(this.PbxPractica3_MouseLeave);
            // 
            // PbxBall8
            // 
            this.PbxBall8.BackColor = System.Drawing.Color.Transparent;
            this.PbxBall8.BackgroundImage = global::POO23A_ACCU.Properties.Resources.Ball8;
            this.PbxBall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxBall8.Location = new System.Drawing.Point(93, 225);
            this.PbxBall8.Name = "PbxBall8";
            this.PbxBall8.Size = new System.Drawing.Size(30, 30);
            this.PbxBall8.TabIndex = 5;
            this.PbxBall8.TabStop = false;
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 710);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlInferior);
            this.Controls.Add(this.PnlSuperior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DlgPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programación Orientada a Objetos";
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            this.PnlInferior.ResumeLayout(false);
            this.PnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPractica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPractica2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPractica3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBall8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblCerrar;
        private System.Windows.Forms.Panel PnlInferior;
        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.PictureBox PbxPractica1;
        private System.Windows.Forms.Button BtnPruebas1;
        private System.Windows.Forms.PictureBox PbxPractica2;
        private System.Windows.Forms.PictureBox PbxPractica3;
        private System.Windows.Forms.PictureBox PbxBall8;
        private System.Windows.Forms.Label LblSubTitulo;
    }
}

