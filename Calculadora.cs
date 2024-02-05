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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        
        private void textBox_numeros_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_sair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        
        

        private void button6_limpar_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text = "";
            textBox_resultado.Text = "";
        }

        private void bt_n1_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "1";


        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "2";

        }

        private void btn_n3_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "3";

        }

        private void btn_n6_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "6";

        }

        private void btn_n5_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "5";

        }

        private void btn_n4_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "4";

        }

        private void btn_n9_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "9";

        }

        private void btn_n8_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "8";

        }

        private void btn_n7_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "7";

        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += ",";

        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += ".";

        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "*";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "-";
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "+";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(textBox_numeros.Text, "");
                textBox_resultado.Text = result.ToString();
            }
            catch (Exception)
            {
                textBox_resultado.Text = "Erro";
            }
            textBox_numeros.Text = "";

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (textBox_numeros.Text.Length > 0)
            {
                textBox_numeros.Text = textBox_numeros.Text.Substring(0, textBox_numeros.Text.Length - 1);
            }


        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text = "";
            textBox_resultado.Text = "";


        }

        private void btn_restart2_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text = "";
            textBox_resultado.Text = "";

        }

        private void btn_percentagem_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "%";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_numeros.Text += "0";

        }
    }
}
