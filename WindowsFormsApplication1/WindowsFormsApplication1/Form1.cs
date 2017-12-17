using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string jugador_1;
        public string jugador_2;
        //Fila 0
        private void Imagen0_0_Click(object sender, EventArgs e)
        {
            this.Imagen0_0.Image = global::WindowsFormsApplication1.Properties.Resources.x;
            funcion_Ocupado();
        }

        private void Imagen0_1_Click(object sender, EventArgs e)
        {
            this.Imagen0_0.Image = global::WindowsFormsApplication1.Properties.Resources.x;
            
        }

        private void Imagen0_2_Click(object sender, EventArgs e)
        {
            this.Imagen0_0.Image = global::WindowsFormsApplication1.Properties.Resources.x;
        }

        //Fila 1_0
        private void Imagen1_0_Click(object sender, EventArgs e)
        {
            this.Imagen1_0.Image = global::WindowsFormsApplication1.Properties.Resources.x;
        }

        private void Imagen1_1_Click(object sender, EventArgs e)
        {

        }

        private void Imagen1_2_Click(object sender, EventArgs e)
        {

        }
        
        //Fila 2_0
        private void Imagen2_0_Click(object sender, EventArgs e)
        {

        }

        private void Imagen2_1_Click(object sender, EventArgs e)
        {

        }

        private void Imagen2_2_Click(object sender, EventArgs e)
        {

        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esferaToolStripMenuItem.ForeColor = Color.Blue;
            esferaToolStripMenuItem1.Enabled = false;
            exisToolStripMenuItem1.ForeColor = Color.Red;
            //esferaToolStripMenuItem1.Font = new Font(esferaToolStripMenuItem1.Font, FontStyle.Bold);
            //esferaToolStripMenuItem1.Text = BackColor.Blue;
            
            
            exisToolStripMenuItem.Enabled = false;
        }

        private void exisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exisToolStripMenuItem.ForeColor = Color.Red;
            esferaToolStripMenuItem.Enabled = false;
            esferaToolStripMenuItem1.ForeColor = Color.Blue;
            exisToolStripMenuItem1.Enabled = false;                
        }

        private void esferaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exisToolStripMenuItem1.Enabled = false;
            esferaToolStripMenuItem.Enabled = false;
            esferaToolStripMenuItem1.ForeColor = Color.Blue;
            exisToolStripMenuItem.ForeColor = Color.Red;
        }

        private void exisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exisToolStripMenuItem1.ForeColor = Color.Red;
            esferaToolStripMenuItem1.Enabled = false;
            esferaToolStripMenuItem.ForeColor = Color.Blue;
            exisToolStripMenuItem.Enabled = false;
        }

        private void nuevoJuego_Click(object sender, EventArgs e)
        {
            esferaToolStripMenuItem.Enabled = true;
            exisToolStripMenuItem.Enabled = true;
            esferaToolStripMenuItem1.Enabled = true;
            exisToolStripMenuItem1.Enabled = true;

            esferaToolStripMenuItem.ForeColor = Color.Black;
            esferaToolStripMenuItem1.ForeColor = Color.Black;
            exisToolStripMenuItem.ForeColor = Color.Black;
            exisToolStripMenuItem1.ForeColor = Color.Black;


        }

        public void funcion_Ocupado()
        {
            if (this.Imagen0_0.Image != null)
            {
                MessageBox.Show("si");
            }
            else { MessageBox.Show("no"); }

            if (this.Imagen0_1.Image != null)
            {
                MessageBox.Show("si");
            }
            else { MessageBox.Show("no"); }
        }
        
        //hola
    }
}
