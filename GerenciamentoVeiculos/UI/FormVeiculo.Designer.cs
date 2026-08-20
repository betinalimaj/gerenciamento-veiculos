namespace GerenciamentoVeiculos.UI
{
    partial class FormVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MotoButton = new RadioButton();
            CarroButton = new RadioButton();
            labeltipoveiculo = new Label();
            comboBox1 = new ComboBox();
            labelMarca = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelModelo = new Label();
            PlacaLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            salvar2 = new Button();
            alterar2 = new Button();
            excluir2 = new Button();
            listar2 = new Button();
            dataGridView2 = new DataGridView();
            Código_veiculo = new DataGridViewTextBoxColumn();
            Marca_veiculo = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            Modelo_veiculo = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            Tipo2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // MotoButton
            // 
            MotoButton.AutoSize = true;
            MotoButton.Location = new Point(29, 48);
            MotoButton.Name = "MotoButton";
            MotoButton.Size = new Size(66, 24);
            MotoButton.TabIndex = 0;
            MotoButton.TabStop = true;
            MotoButton.Text = "Moto";
            MotoButton.UseVisualStyleBackColor = true;
            MotoButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // CarroButton
            // 
            CarroButton.AutoSize = true;
            CarroButton.Location = new Point(29, 78);
            CarroButton.Name = "CarroButton";
            CarroButton.Size = new Size(66, 24);
            CarroButton.TabIndex = 1;
            CarroButton.TabStop = true;
            CarroButton.Text = "Carro";
            CarroButton.UseVisualStyleBackColor = true;
            CarroButton.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // labeltipoveiculo
            // 
            labeltipoveiculo.AutoSize = true;
            labeltipoveiculo.Location = new Point(29, 25);
            labeltipoveiculo.Name = "labeltipoveiculo";
            labeltipoveiculo.Size = new Size(199, 20);
            labeltipoveiculo.TabIndex = 2;
            labeltipoveiculo.Text = "Selecione o Tipo de veículo: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(29, 118);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(137, 20);
            labelMarca.TabIndex = 4;
            labelMarca.Text = "Selecione a Marca: ";
            labelMarca.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 297);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 6;
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(31, 193);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(64, 20);
            labelModelo.TabIndex = 7;
            labelModelo.Text = "Modelo:";
            // 
            // PlacaLabel
            // 
            PlacaLabel.AutoSize = true;
            PlacaLabel.Location = new Point(31, 274);
            PlacaLabel.Name = "PlacaLabel";
            PlacaLabel.Size = new Size(47, 20);
            PlacaLabel.TabIndex = 8;
            PlacaLabel.Text = "Placa:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(31, 377);
            numericUpDown1.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 354);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 10;
            label2.Text = "Ano:";
            // 
            // salvar2
            // 
            salvar2.Location = new Point(224, 140);
            salvar2.Name = "salvar2";
            salvar2.Size = new Size(95, 28);
            salvar2.TabIndex = 11;
            salvar2.Text = "Salvar";
            salvar2.UseVisualStyleBackColor = true;
            salvar2.Click += button1_Click;
            // 
            // alterar2
            // 
            alterar2.Location = new Point(324, 140);
            alterar2.Name = "alterar2";
            alterar2.Size = new Size(95, 28);
            alterar2.TabIndex = 12;
            alterar2.Text = "Alterar";
            alterar2.UseVisualStyleBackColor = true;
            alterar2.Click += button2_Click;
            // 
            // excluir2
            // 
            excluir2.Location = new Point(425, 140);
            excluir2.Name = "excluir2";
            excluir2.Size = new Size(95, 28);
            excluir2.TabIndex = 13;
            excluir2.Text = "Excluir";
            excluir2.UseVisualStyleBackColor = true;
            excluir2.Click += excluir_Click;
            // 
            // listar2
            // 
            listar2.Location = new Point(526, 140);
            listar2.Name = "listar2";
            listar2.Size = new Size(95, 28);
            listar2.TabIndex = 14;
            listar2.Text = "Listar";
            listar2.UseVisualStyleBackColor = true;
            listar2.Click += listar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Código_veiculo, Marca_veiculo, Placa, Modelo_veiculo, Ano, Tipo2 });
            dataGridView2.Location = new Point(224, 186);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(803, 218);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // Código_veiculo
            // 
            Código_veiculo.HeaderText = "Código";
            Código_veiculo.MinimumWidth = 6;
            Código_veiculo.Name = "Código_veiculo";
            Código_veiculo.ReadOnly = true;
            Código_veiculo.Width = 125;
            // 
            // Marca_veiculo
            // 
            Marca_veiculo.HeaderText = "Marca";
            Marca_veiculo.MinimumWidth = 6;
            Marca_veiculo.Name = "Marca_veiculo";
            Marca_veiculo.ReadOnly = true;
            Marca_veiculo.Width = 125;
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.MinimumWidth = 6;
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            Placa.Width = 125;
            // 
            // Modelo_veiculo
            // 
            Modelo_veiculo.HeaderText = "Modelo";
            Modelo_veiculo.MinimumWidth = 6;
            Modelo_veiculo.Name = "Modelo_veiculo";
            Modelo_veiculo.ReadOnly = true;
            Modelo_veiculo.Width = 125;
            // 
            // Ano
            // 
            Ano.HeaderText = "Ano";
            Ano.MinimumWidth = 6;
            Ano.Name = "Ano";
            Ano.ReadOnly = true;
            Ano.Width = 125;
            // 
            // Tipo2
            // 
            Tipo2.HeaderText = "Tipo";
            Tipo2.MinimumWidth = 6;
            Tipo2.Name = "Tipo2";
            Tipo2.ReadOnly = true;
            Tipo2.Width = 125;
            // 
            // FormVeiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 487);
            Controls.Add(dataGridView2);
            Controls.Add(listar2);
            Controls.Add(excluir2);
            Controls.Add(alterar2);
            Controls.Add(salvar2);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(PlacaLabel);
            Controls.Add(labelModelo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelMarca);
            Controls.Add(comboBox1);
            Controls.Add(labeltipoveiculo);
            Controls.Add(CarroButton);
            Controls.Add(MotoButton);
            Name = "FormVeiculo";
            Text = "FormVeiculo";
            Load += FormVeiculo_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton MotoButton;
        private RadioButton CarroButton;
        private Label labeltipoveiculo;
        private ComboBox comboBox1;
        private Label labelMarca;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelModelo;
        private Label PlacaLabel;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button salvar2;
        private Button alterar2;
        private Button excluir2;
        private Button listar2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Código_veiculo;
        private DataGridViewTextBoxColumn Marca_veiculo;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn Modelo_veiculo;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn Tipo2;
    }
}