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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.jugador1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugador2 = new System.Windows.Forms.ToolStripMenuItem();
            this.esferaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FichaTicTacToe = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picGanador = new System.Windows.Forms.PictureBox();
            this.lblGanador = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoJuego
            // 
            this.nuevoJuego.Name = "nuevoJuego";
            this.nuevoJuego.Size = new System.Drawing.Size(88, 20);
            this.nuevoJuego.Text = "Nuevo Juego";
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
            // esferaToolStripMenuItem
            // 
            this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            this.esferaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.esferaToolStripMenuItem.Text = "Esfera";
            // 
            // exisToolStripMenuItem
            // 
            this.exisToolStripMenuItem.Name = "exisToolStripMenuItem";
            this.exisToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exisToolStripMenuItem.Text = "Exis";
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
            // esferaToolStripMenuItem1
            // 
            this.esferaToolStripMenuItem1.Name = "esferaToolStripMenuItem1";
            this.esferaToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.esferaToolStripMenuItem1.Text = "Esfera";
            // 
            // exisToolStripMenuItem1
            // 
            this.exisToolStripMenuItem1.Name = "exisToolStripMenuItem1";
            this.exisToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.exisToolStripMenuItem1.Text = "Exis";
            // 
            // FichaTicTacToe
            // 
            this.FichaTicTacToe.BackColor = System.Drawing.Color.Transparent;
            this.FichaTicTacToe.ColumnCount = 3;
            this.FichaTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichaTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichaTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.FichaTicTacToe.Location = new System.Drawing.Point(12, 48);
            this.FichaTicTacToe.Name = "FichaTicTacToe";
            this.FichaTicTacToe.RowCount = 3;
            this.FichaTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichaTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichaTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.FichaTicTacToe.Size = new System.Drawing.Size(315, 315);
            this.FichaTicTacToe.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.messi;
            this.pictureBox1.Location = new System.Drawing.Point(410, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ronado;
            this.pictureBox2.Location = new System.Drawing.Point(574, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(532, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vs";
            // 
            // picGanador
            // 
            this.picGanador.BackColor = System.Drawing.Color.Transparent;
            this.picGanador.Image = global::WindowsFormsApplication1.Properties.Resources.pelota;
            this.picGanador.Location = new System.Drawing.Point(724, 48);
            this.picGanador.Name = "picGanador";
            this.picGanador.Size = new System.Drawing.Size(221, 235);
            this.picGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGanador.TabIndex = 9;
            this.picGanador.TabStop = false;
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.ForeColor = System.Drawing.Color.White;
            this.lblGanador.Location = new System.Drawing.Point(789, 295);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(90, 24);
            this.lblGanador.TabIndex = 10;
            this.lblGanador.Text = "Ganador";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(617, 166);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(21, 24);
            this.lblPlayer2.TabIndex = 11;
            this.lblPlayer2.Text = "0";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(448, 166);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(21, 24);
            this.lblPlayer1.TabIndex = 12;
            this.lblPlayer1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.anonymous;
            this.ClientSize = new System.Drawing.Size(966, 389);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.picGanador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FichaTicTacToe);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tres en Rayas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuego;
        private System.Windows.Forms.ToolStripMenuItem jugador1;
        private System.Windows.Forms.ToolStripMenuItem jugador2;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exisToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel FichaTicTacToe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGanador;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;


    }
}

