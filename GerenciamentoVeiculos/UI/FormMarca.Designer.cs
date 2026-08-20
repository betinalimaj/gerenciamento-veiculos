namespace GerenciamentoVeiculos.UI
{
    partial class FormMarca
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            gridMarcas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Listar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridMarcas).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textnome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 38);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Marca: ";
            // 
            // button1
            // 
            button1.Location = new Point(142, 83);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += salvar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 83);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += alterar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(360, 83);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += excluir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 203);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // gridMarcas
            // 
            gridMarcas.AllowUserToAddRows = false;
            gridMarcas.AllowUserToDeleteRows = false;
            gridMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMarcas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome });
            gridMarcas.Location = new Point(118, 203);
            gridMarcas.MultiSelect = false;
            gridMarcas.Name = "gridMarcas";
            gridMarcas.ReadOnly = true;
            gridMarcas.RowHeadersWidth = 51;
            gridMarcas.Size = new Size(357, 188);
            gridMarcas.TabIndex = 6;
            gridMarcas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Marca";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // Listar
            // 
            Listar.Location = new Point(118, 158);
            Listar.Name = "Listar";
            Listar.Size = new Size(94, 29);
            Listar.TabIndex = 7;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += listar_Click;
            // 
            // FormMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 467);
            Controls.Add(Listar);
            Controls.Add(gridMarcas);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMarca";
            ((System.ComponentModel.ISupportInitialize)gridMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private DataGridView gridMarcas;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private Button Listar;
    }
}