using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GerenciamentoVeiculos.UI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            FormMarca tela = new FormMarca();
            tela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVeiculo tela = new FormVeiculo();
            tela.ShowDialog();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
