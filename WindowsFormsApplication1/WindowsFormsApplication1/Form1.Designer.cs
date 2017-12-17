namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.jugador1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jugador2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFilaIzq = new System.Windows.Forms.Label();
            this.lblFilaDerecha = new System.Windows.Forms.Label();
            this.lblColumnArriba = new System.Windows.Forms.Label();
            this.lblColumnaAbajo = new System.Windows.Forms.Label();
            this.Imagen0_0 = new System.Windows.Forms.PictureBox();
            this.Imagen0_2 = new System.Windows.Forms.PictureBox();
            this.Imagen1_2 = new System.Windows.Forms.PictureBox();
            this.Imagen2_2 = new System.Windows.Forms.PictureBox();
            this.Imagen1_0 = new System.Windows.Forms.PictureBox();
            this.Imagen2_0 = new System.Windows.Forms.PictureBox();
            this.Imagen1_1 = new System.Windows.Forms.PictureBox();
            this.Imagen0_1 = new System.Windows.Forms.PictureBox();
            this.Imagen2_1 = new System.Windows.Forms.PictureBox();
            this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esferaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen0_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen0_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen0_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuego,
            this.jugador1,
            this.jugador2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoJuego
            // 
            this.nuevoJuego.Name = "nuevoJuego";
            this.nuevoJuego.Size = new System.Drawing.Size(88, 20);
            this.nuevoJuego.Text = "Nuevo Juego";
            this.nuevoJuego.Click += new System.EventHandler(this.nuevoJuego_Click);
            // 
            // jugador1
            // 
            this.jugador1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esferaToolStripMenuItem,
            this.exisToolStripMenuItem});
            this.jugador1.Name = "jugador1";
            this.jugador1.Size = new System.Drawing.Size(70, 20);
            this.jugador1.Text = "Jugador 1";
            // 
            // jugador2
            // 
            this.jugador2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esferaToolStripMenuItem1,
            this.exisToolStripMenuItem1});
            this.jugador2.Name = "jugador2";
            this.jugador2.Size = new System.Drawing.Size(70, 20);
            this.jugador2.Text = "Jugador 2";
            // 
            // lblFilaIzq
            // 
            this.lblFilaIzq.BackColor = System.Drawing.Color.Red;
            this.lblFilaIzq.CausesValidation = false;
            this.lblFilaIzq.Location = new System.Drawing.Point(153, 53);
            this.lblFilaIzq.Name = "lblFilaIzq";
            this.lblFilaIzq.Size = new System.Drawing.Size(12, 258);
            this.lblFilaIzq.TabIndex = 0;
            // 
            // lblFilaDerecha
            // 
            this.lblFilaDerecha.BackColor = System.Drawing.Color.Red;
            this.lblFilaDerecha.CausesValidation = false;
            this.lblFilaDerecha.Location = new System.Drawing.Point(248, 53);
            this.lblFilaDerecha.Name = "lblFilaDerecha";
            this.lblFilaDerecha.Size = new System.Drawing.Size(13, 258);
            this.lblFilaDerecha.TabIndex = 1;
            // 
            // lblColumnArriba
            // 
            this.lblColumnArriba.BackColor = System.Drawing.Color.Red;
            this.lblColumnArriba.CausesValidation = false;
            this.lblColumnArriba.Location = new System.Drawing.Point(85, 116);
            this.lblColumnArriba.Name = "lblColumnArriba";
            this.lblColumnArriba.Size = new System.Drawing.Size(253, 10);
            this.lblColumnArriba.TabIndex = 2;
            // 
            // lblColumnaAbajo
            // 
            this.lblColumnaAbajo.BackColor = System.Drawing.Color.Red;
            this.lblColumnaAbajo.CausesValidation = false;
            this.lblColumnaAbajo.Location = new System.Drawing.Point(85, 221);
            this.lblColumnaAbajo.Name = "lblColumnaAbajo";
            this.lblColumnaAbajo.Size = new System.Drawing.Size(253, 10);
            this.lblColumnaAbajo.TabIndex = 3;
            // 
            // Imagen0_0
            // 
            this.Imagen0_0.Image = ((System.Drawing.Image)(resources.GetObject("Imagen0_0.Image")));
            this.Imagen0_0.Location = new System.Drawing.Point(56, 60);
            this.Imagen0_0.Name = "Imagen0_0";
            this.Imagen0_0.Size = new System.Drawing.Size(86, 50);
            this.Imagen0_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen0_0.TabIndex = 5;
            this.Imagen0_0.TabStop = false;
            this.Imagen0_0.Click += new System.EventHandler(this.Imagen0_0_Click);
            // 
            // Imagen0_2
            // 
            this.Imagen0_2.Image = ((System.Drawing.Image)(resources.GetObject("Imagen0_2.Image")));
            this.Imagen0_2.Location = new System.Drawing.Point(270, 58);
            this.Imagen0_2.Name = "Imagen0_2";
            this.Imagen0_2.Size = new System.Drawing.Size(86, 50);
            this.Imagen0_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen0_2.TabIndex = 6;
            this.Imagen0_2.TabStop = false;
            this.Imagen0_2.Click += new System.EventHandler(this.Imagen0_2_Click);
            // 
            // Imagen1_2
            // 
            this.Imagen1_2.Image = ((System.Drawing.Image)(resources.GetObject("Imagen1_2.Image")));
            this.Imagen1_2.Location = new System.Drawing.Point(270, 148);
            this.Imagen1_2.Name = "Imagen1_2";
            this.Imagen1_2.Size = new System.Drawing.Size(86, 50);
            this.Imagen1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen1_2.TabIndex = 7;
            this.Imagen1_2.TabStop = false;
            this.Imagen1_2.Click += new System.EventHandler(this.Imagen1_2_Click);
            // 
            // Imagen2_2
            // 
            this.Imagen2_2.Image = ((System.Drawing.Image)(resources.GetObject("Imagen2_2.Image")));
            this.Imagen2_2.Location = new System.Drawing.Point(270, 243);
            this.Imagen2_2.Name = "Imagen2_2";
            this.Imagen2_2.Size = new System.Drawing.Size(86, 50);
            this.Imagen2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen2_2.TabIndex = 8;
            this.Imagen2_2.TabStop = false;
            this.Imagen2_2.Click += new System.EventHandler(this.Imagen2_2_Click);
            // 
            // Imagen1_0
            // 
            this.Imagen1_0.Image = ((System.Drawing.Image)(resources.GetObject("Imagen1_0.Image")));
            this.Imagen1_0.Location = new System.Drawing.Point(56, 148);
            this.Imagen1_0.Name = "Imagen1_0";
            this.Imagen1_0.Size = new System.Drawing.Size(86, 50);
            this.Imagen1_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen1_0.TabIndex = 9;
            this.Imagen1_0.TabStop = false;
            this.Imagen1_0.Click += new System.EventHandler(this.Imagen1_0_Click);
            // 
            // Imagen2_0
            // 
            this.Imagen2_0.Image = ((System.Drawing.Image)(resources.GetObject("Imagen2_0.Image")));
            this.Imagen2_0.Location = new System.Drawing.Point(56, 243);
            this.Imagen2_0.Name = "Imagen2_0";
            this.Imagen2_0.Size = new System.Drawing.Size(86, 50);
            this.Imagen2_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen2_0.TabIndex = 10;
            this.Imagen2_0.TabStop = false;
            this.Imagen2_0.Click += new System.EventHandler(this.Imagen2_0_Click);
            // 
            // Imagen1_1
            // 
            this.Imagen1_1.Image = ((System.Drawing.Image)(resources.GetObject("Imagen1_1.Image")));
            this.Imagen1_1.Location = new System.Drawing.Point(176, 148);
            this.Imagen1_1.Name = "Imagen1_1";
            this.Imagen1_1.Size = new System.Drawing.Size(66, 50);
            this.Imagen1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen1_1.TabIndex = 11;
            this.Imagen1_1.TabStop = false;
            this.Imagen1_1.Click += new System.EventHandler(this.Imagen1_1_Click);
            // 
            // Imagen0_1
            // 
            this.Imagen0_1.Image = ((System.Drawing.Image)(resources.GetObject("Imagen0_1.Image")));
            this.Imagen0_1.Location = new System.Drawing.Point(176, 58);
            this.Imagen0_1.Name = "Imagen0_1";
            this.Imagen0_1.Size = new System.Drawing.Size(66, 48);
            this.Imagen0_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen0_1.TabIndex = 12;
            this.Imagen0_1.TabStop = false;
            this.Imagen0_1.Click += new System.EventHandler(this.Imagen0_1_Click);
            // 
            // Imagen2_1
            // 
            this.Imagen2_1.Image = ((System.Drawing.Image)(resources.GetObject("Imagen2_1.Image")));
            this.Imagen2_1.Location = new System.Drawing.Point(176, 243);
            this.Imagen2_1.Name = "Imagen2_1";
            this.Imagen2_1.Size = new System.Drawing.Size(66, 50);
            this.Imagen2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen2_1.TabIndex = 13;
            this.Imagen2_1.TabStop = false;
            this.Imagen2_1.Click += new System.EventHandler(this.Imagen2_1_Click);
            // 
            // esferaToolStripMenuItem
            // 
            this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            this.esferaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esferaToolStripMenuItem.Text = "Esfera";
            this.esferaToolStripMenuItem.Click += new System.EventHandler(this.esferaToolStripMenuItem_Click);
            // 
            // exisToolStripMenuItem
            // 
            this.exisToolStripMenuItem.Name = "exisToolStripMenuItem";
            this.exisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exisToolStripMenuItem.Text = "Exis";
            this.exisToolStripMenuItem.Click += new System.EventHandler(this.exisToolStripMenuItem_Click);
            // 
            // esferaToolStripMenuItem1
            // 
            this.esferaToolStripMenuItem1.Name = "esferaToolStripMenuItem1";
            this.esferaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.esferaToolStripMenuItem1.Text = "Esfera";
            this.esferaToolStripMenuItem1.Click += new System.EventHandler(this.esferaToolStripMenuItem1_Click);
            // 
            // exisToolStripMenuItem1
            // 
            this.exisToolStripMenuItem1.Name = "exisToolStripMenuItem1";
            this.exisToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exisToolStripMenuItem1.Text = "Exis";
            this.exisToolStripMenuItem1.Click += new System.EventHandler(this.exisToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(438, 364);
            this.Controls.Add(this.Imagen2_1);
            this.Controls.Add(this.Imagen0_1);
            this.Controls.Add(this.Imagen1_1);
            this.Controls.Add(this.Imagen2_0);
            this.Controls.Add(this.Imagen1_0);
            this.Controls.Add(this.Imagen2_2);
            this.Controls.Add(this.Imagen1_2);
            this.Controls.Add(this.Imagen0_2);
            this.Controls.Add(this.Imagen0_0);
            this.Controls.Add(this.lblColumnaAbajo);
            this.Controls.Add(this.lblColumnArriba);
            this.Controls.Add(this.lblFilaDerecha);
            this.Controls.Add(this.lblFilaIzq);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tres en Rayas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen0_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen0_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen0_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuego;
        private System.Windows.Forms.ToolStripMenuItem jugador1;
        private System.Windows.Forms.ToolStripMenuItem jugador2;
        public System.Windows.Forms.Label lblFilaIzq;
        public System.Windows.Forms.Label lblFilaDerecha;
        public System.Windows.Forms.Label lblColumnArriba;
        public System.Windows.Forms.Label lblColumnaAbajo;
        private System.Windows.Forms.PictureBox Imagen0_0;
        private System.Windows.Forms.PictureBox Imagen0_2;
        private System.Windows.Forms.PictureBox Imagen1_2;
        private System.Windows.Forms.PictureBox Imagen2_2;
        private System.Windows.Forms.PictureBox Imagen1_0;
        private System.Windows.Forms.PictureBox Imagen2_0;
        private System.Windows.Forms.PictureBox Imagen1_1;
        private System.Windows.Forms.PictureBox Imagen0_1;
        private System.Windows.Forms.PictureBox Imagen2_1;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exisToolStripMenuItem1;


    }
}

