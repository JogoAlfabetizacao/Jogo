using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Joguinho_Alfabetização
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pb_cima_Click(object sender, EventArgs e)
        {
            pb_partida.Location = new Point(pb_partida.Location.X, pb_partida.Location.Y-10);
        }

        private void pb_esquerda_Click(object sender, EventArgs e)
        {
            pb_partida.Location = new Point(pb_partida.Location.X-10, pb_partida.Location.Y);
        }

        private void pb_baixo_Click(object sender, EventArgs e)
        {
            pb_partida.Location = new Point(pb_partida.Location.X, pb_partida.Location.Y-10);
        }

        private void pb_direita_Click(object sender, EventArgs e)
        {
            pb_partida.Location = new Point(pb_partida.Location.X-10, pb_partida.Location.Y);
        }

        private void bt_avançar_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.ShowDialog();
        }

        //private void pb_partida_Click(object sender, EventArgs e)
        //{
        //    if (pb_partida.Location.X-229 == pb_partida.Location.X && pb_partida.Location.Y-12)

        //}

        
    }
}
