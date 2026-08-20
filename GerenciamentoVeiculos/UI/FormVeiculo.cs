using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GerenciamentoVeiculos.Main;
using GerenciamentoVeiculos.Service;

namespace GerenciamentoVeiculos.UI
{
    public partial class FormVeiculo : Form
    {

        private readonly MarcaService marcaService = new MarcaService();
        private readonly VeiculoService veiculoService = new VeiculoService();

        private int codigoSelecionado = 0;

        private void CarregarMarcas()
        {
            comboBox1.DataSource = marcaService.Listar();

            comboBox1.DisplayMember = "Nome";

            comboBox1.ValueMember = "Codigo";

            comboBox1.SelectedIndex = -1;
        }

        private void CarregarVeiculos()
        {
            dataGridView2.Rows.Clear();

            List<Veiculo> veiculos = veiculoService.Listar();

            foreach (Veiculo veiculo in veiculos)
            {
                dataGridView2.Rows.Add(
                    veiculo.Codigo,
                    veiculo.Marca.Nome,
                    veiculo.Placa,
                    veiculo.Modelo,
                    veiculo.Ano,
                    veiculo.Tipo
                );
            }
        }
        public FormVeiculo()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo;

                if (CarroButton.Checked)
                {
                    veiculo = new Carro();
                }
                else if (MotoButton.Checked)
                {
                    veiculo = new Moto();
                }
                else
                {
                    MessageBox.Show("Selecione o tipo do veículo.");
                    return;
                }

                veiculo.Modelo = textBox1.Text;
                veiculo.Placa = textBox2.Text;
                veiculo.Ano = Convert.ToInt32(numericUpDown1.Value);

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma marca.");
                    return;
                }

                veiculo.Marca = (Marca)comboBox1.SelectedItem;

                veiculoService.Inserir(veiculo);

                MessageBox.Show("Veículo cadastrado com sucesso!");

                CarregarVeiculos();

                textBox1.Clear();
                textBox2.Clear();
                numericUpDown1.Value = numericUpDown1.Minimum;
                comboBox1.SelectedIndex = -1;
                CarroButton.Checked = false;
                MotoButton.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            CarregarMarcas();
            CarregarVeiculos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoSelecionado == 0)
                {
                    MessageBox.Show("Selecione um veículo.");
                    return;
                }

                Veiculo veiculo;

                if (CarroButton.Checked)
                {
                    veiculo = new Carro();
                }
                else if (MotoButton.Checked)
                {
                    veiculo = new Moto();
                }
                else
                {
                    MessageBox.Show("Selecione o tipo do veículo.");
                    return;
                }

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma marca.");
                    return;
                }

                veiculo.Codigo = codigoSelecionado;
                veiculo.Modelo = textBox1.Text;
                veiculo.Placa = textBox2.Text;
                veiculo.Ano = Convert.ToInt32(numericUpDown1.Value);
                veiculo.Marca = (Marca)comboBox1.SelectedItem;

                veiculoService.Alterar(veiculo);

                MessageBox.Show("Veículo alterado com sucesso!");

                CarregarVeiculos();

                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
                CarroButton.Checked = false;
                MotoButton.Checked = false;
                numericUpDown1.Value = numericUpDown1.Minimum;
                codigoSelecionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listar_Click(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }
        private void excluir_Click(object sender, EventArgs e)
        {
            if (codigoSelecionado == 0)
            {
                MessageBox.Show("Selecione um veículo.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este veículo?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                veiculoService.Excluir(codigoSelecionado);

                MessageBox.Show("Veículo excluído com sucesso!");

                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
                CarroButton.Checked = false;
                MotoButton.Checked = false;
                numericUpDown1.Value = numericUpDown1.Minimum;
                codigoSelecionado = 0;

                CarregarVeiculos();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                codigoSelecionado = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);

                comboBox1.SelectedIndex =
                comboBox1.FindStringExact(
                    dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());

                textBox2.Text =
                    dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

                textBox1.Text =
                    dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

                numericUpDown1.Value =
                    Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells[4].Value);

                string tipo = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();

                CarroButton.Checked = tipo == "Carro";
                MotoButton.Checked = tipo == "Moto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
