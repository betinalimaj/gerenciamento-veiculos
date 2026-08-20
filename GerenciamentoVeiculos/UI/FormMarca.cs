using GerenciamentoVeiculos.Main;
using GerenciamentoVeiculos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GerenciamentoVeiculos.UI
{
    public partial class FormMarca : Form
    {

        private readonly MarcaService service = new MarcaService();
        private int codigoSelecionado = 0;

        public FormMarca()
        {
            InitializeComponent();
            CarregarMarcas();
        }

        private void CarregarMarcas()
        {
            gridMarcas.Rows.Clear();

            List<Marca> marcas = service.Listar();

            foreach (Marca marca in marcas)
            {
                gridMarcas.Rows.Add(
                    marca.Codigo,
                    marca.Nome
                );
            }
        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();
                marca.Nome = textBox1.Text;

                service.Inserir(marca);

                MessageBox.Show("Marca cadastrada com sucesso!");

                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoSelecionado == 0)
                {
                    MessageBox.Show("Selecione uma marca.");
                    return;
                }

                Marca marca = new Marca();
                marca.Codigo = codigoSelecionado;
                marca.Nome = textBox1.Text;

                service.Alterar(marca);

                MessageBox.Show("Marca alterada com sucesso!");

                textBox1.Clear();
                codigoSelecionado = 0;

                CarregarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void excluir_Click(object sender, EventArgs e)
{
    try
    {
        if (codigoSelecionado == 0)
        {
            MessageBox.Show("Selecione uma marca.");
            return;
        }

        DialogResult resposta = MessageBox.Show(
            "Deseja realmente excluir esta marca?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (resposta == DialogResult.Yes)
        {
            service.Excluir(codigoSelecionado);

            MessageBox.Show("Marca excluída com sucesso!");

            textBox1.Clear();
            codigoSelecionado = 0;

            CarregarMarcas();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigoSelecionado = Convert.ToInt32(gridMarcas.Rows[e.RowIndex].Cells[0].Value);
                textBox1.Text = gridMarcas.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        }

        private void listar_Click(object sender, EventArgs e)
        {
            CarregarMarcas();

        }
    }
}
