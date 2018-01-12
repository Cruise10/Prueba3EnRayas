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
        int turno = 1;
        int Puntos_Player1 = 0;
        int Puntos_Player2 = 0;
        int[,] Gato;
        bool ExisteGanador;

        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            //Inicia valores en Juego
            turno = 1;
            Gato = new int [3, 3];
            ExisteGanador = false;


            picGanador.Image = Properties.Resources.pelota;
            FichaTicTacToe.Controls.Clear();

            //Arreglos para mostrar Fichas y meter valores en una matriz

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                }
            }
        }
    }
}
