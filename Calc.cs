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
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void btn_Somar_Click_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt_N1.Text);
            int n2 = int.Parse(txt_N2.Text);

            int soma = n1 + n2;

            resultado.Text = soma.ToString();
        }

        private void btn_formExtra_click_Click(object sender, EventArgs e)
        {
            int x = 3;
            this.Hide();
            FormExtra formExtra = new FormExtra();
            formExtra.Show();
        }

        private void btn_sair_click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
