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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_verificar_Click(object sender, EventArgs e)
        {
            if (tb_e.Text == "E" && tb_2e.Text == "E" && tb_3e.Text == "E" && tb_a.Text == "A")
            {
                tb_e.Text = "E";
                tb_a.Text = "A";
                tb_2e.Text = "E";
                tb_3e.Text = "E";
                MessageBox.Show("PARABÉNS");
                
            }

            else if(tb_e.Text == "E" || tb_2e.Text == "E" || tb_3e.Text == "E" || tb_a.Text == "A")
            {
                MessageBox.Show("TENTE NOVAMENTE");
            }
        
        }

        private void bt_avançar_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.ShowDialog();
        }
        }
    }

