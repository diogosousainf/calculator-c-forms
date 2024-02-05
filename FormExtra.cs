using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Forms
{
    public partial class FormExtra : Form
    {
        public FormExtra()
        {
            InitializeComponent();
        }

        private void btn_Qual_Click_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Sim");
            }
            else
            {
                MessageBox.Show("Não");
            }
        }

        private void btn_Inserir_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.ForeColor = Color.Red;
                label2.Visible = true;
            }
            else
            {
                box_valores.Items.Add(textBox1.Text);
                textBox1.Clear();
                label2.Visible = false;
            }
            
        }

        private void btn_Mostrar_Click_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (string s in box_valores.Items)
            {
                txt += s + "|";
            }
            MessageBox.Show(txt);
        }

        private void btn_Limpar_Click_Click(object sender, EventArgs e)
        {
            box_valores.Items.Clear();
        }
    }
}
