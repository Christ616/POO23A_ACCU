namespace POO23A_ACCU
{
    partial class DlgPractica2
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
                ProcesoCoalicion.Abort();
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
            this.PnlIzq = new System.Windows.Forms.Panel();
            this.BtnZombieDog = new System.Windows.Forms.Button();
            this.BtnZombieRomero = new System.Windows.Forms.Button();
            this.BtnZombie = new System.Windows.Forms.Button();
            this.PnlSupSup = new System.Windows.Forms.Panel();
            this.BtnCoalicion = new System.Windows.Forms.Button();
            this.PnlSupSub = new System.Windows.Forms.Panel();
            this.PbxFondo = new System.Windows.Forms.PictureBox();
            this.PnlIzq.SuspendLayout();
            this.PnlSupSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIzq
            // 
            this.PnlIzq.BackColor = System.Drawing.Color.DarkRed;
            this.PnlIzq.Controls.Add(this.BtnZombieDog);
            this.PnlIzq.Controls.Add(this.BtnZombieRomero);
            this.PnlIzq.Controls.Add(this.BtnZombie);
            this.PnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzq.Location = new System.Drawing.Point(0, 0);
            this.PnlIzq.Name = "PnlIzq";
            this.PnlIzq.Size = new System.Drawing.Size(58, 450);
            this.PnlIzq.TabIndex = 0;
            // 
            // BtnZombieDog
            // 
            this.BtnZombieDog.Location = new System.Drawing.Point(12, 100);
            this.BtnZombieDog.Name = "BtnZombieDog";
            this.BtnZombieDog.Size = new System.Drawing.Size(35, 23);
            this.BtnZombieDog.TabIndex = 2;
            this.BtnZombieDog.Text = "ZD";
            this.BtnZombieDog.UseVisualStyleBackColor = true;
            this.BtnZombieDog.Click += new System.EventHandler(this.BtnZombieDog_Click);
            // 
            // BtnZombieRomero
            // 
            this.BtnZombieRomero.Location = new System.Drawing.Point(12, 55);
            this.BtnZombieRomero.Name = "BtnZombieRomero";
            this.BtnZombieRomero.Size = new System.Drawing.Size(35, 23);
            this.BtnZombieRomero.TabIndex = 1;
            this.BtnZombieRomero.Text = "ZR";
            this.BtnZombieRomero.UseVisualStyleBackColor = true;
            this.BtnZombieRomero.Click += new System.EventHandler(this.BtnZombieRomero_Click);
            // 
            // BtnZombie
            // 
            this.BtnZombie.Location = new System.Drawing.Point(12, 12);
            this.BtnZombie.Name = "BtnZombie";
            this.BtnZombie.Size = new System.Drawing.Size(35, 23);
            this.BtnZombie.TabIndex = 0;
            this.BtnZombie.Text = "ZP";
            this.BtnZombie.UseVisualStyleBackColor = true;
            this.BtnZombie.Click += new System.EventHandler(this.BtnZombie_Click);
            // 
            // PnlSupSup
            // 
            this.PnlSupSup.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.PnlSupSup.Controls.Add(this.BtnCoalicion);
            this.PnlSupSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSupSup.Location = new System.Drawing.Point(58, 0);
            this.PnlSupSup.Name = "PnlSupSup";
            this.PnlSupSup.Size = new System.Drawing.Size(742, 38);
            this.PnlSupSup.TabIndex = 1;
            // 
            // BtnCoalicion
            // 
            this.BtnCoalicion.Location = new System.Drawing.Point(6, 9);
            this.BtnCoalicion.Name = "BtnCoalicion";
            this.BtnCoalicion.Size = new System.Drawing.Size(111, 23);
            this.BtnCoalicion.TabIndex = 0;
            this.BtnCoalicion.Text = "Iniciar Apocalipsis";
            this.BtnCoalicion.UseVisualStyleBackColor = true;
            this.BtnCoalicion.Click += new System.EventHandler(this.BtnCoalicion_Click);
            // 
            // PnlSupSub
            // 
            this.PnlSupSub.BackColor = System.Drawing.Color.DimGray;
            this.PnlSupSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSupSub.Location = new System.Drawing.Point(58, 38);
            this.PnlSupSub.Name = "PnlSupSub";
            this.PnlSupSub.Size = new System.Drawing.Size(742, 40);
            this.PnlSupSub.TabIndex = 2;
            // 
            // PbxFondo
            // 
            this.PbxFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxFondo.Image = global::POO23A_ACCU.Properties.Resources.Ciudad_Z;
            this.PbxFondo.Location = new System.Drawing.Point(58, 78);
            this.PbxFondo.Name = "PbxFondo";
            this.PbxFondo.Size = new System.Drawing.Size(742, 372);
            this.PbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFondo.TabIndex = 3;
            this.PbxFondo.TabStop = false;
            // 
            // DlgPractica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbxFondo);
            this.Controls.Add(this.PnlSupSub);
            this.Controls.Add(this.PnlSupSup);
            this.Controls.Add(this.PnlIzq);
            this.Name = "DlgPractica2";
            this.ShowInTaskbar = false;
            this.Text = "DlgPractica2";
            this.PnlIzq.ResumeLayout(false);
            this.PnlSupSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlIzq;
        private System.Windows.Forms.Panel PnlSupSup;
        private System.Windows.Forms.Panel PnlSupSub;
        private System.Windows.Forms.Button BtnZombie;
        private System.Windows.Forms.PictureBox PbxFondo;
        private System.Windows.Forms.Button BtnZombieRomero;
        private System.Windows.Forms.Button BtnCoalicion;
        private System.Windows.Forms.Button BtnZombieDog;
    }
}