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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
    
         
        private void bt_verificar_Click(object sender, EventArgs e)
        {
            if (tb_resposta_o.Text == "O" && tb_resposta_a.Text == "A")
            {
                tb_resposta_o.Text = "O";
                tb_resposta_a.Text = "A";
                MessageBox.Show("PARABÉNS");
                
            }

            else if(tb_resposta_o.Text != "O" && tb_resposta_a.Text != "A")
            {
                MessageBox.Show("TENTE NOVAMENTE");
            }
        
        }

        private void bt_avançar_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.ShowDialog();

        }

      /*  private void bt_avançar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.elefante;

        } */

    

     

        
    }
}
