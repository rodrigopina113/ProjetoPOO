namespace Projeto_POO
{
    partial class Comprar_bilhete
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            comboBox_rotas = new ComboBox();
            button_comprar = new Button();
            button_limpar = new Button();
            button_Sair = new Button();
            dataGridView1 = new DataGridView();
            idrota = new DataGridViewTextBoxColumn();
            datavoo = new DataGridViewTextBoxColumn();
            horavoo = new DataGridViewTextBoxColumn();
            lugaresvoo = new DataGridViewTextBoxColumn();
            bilhetesuplente = new DataGridViewTextBoxColumn();
            precobilhete = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Destino:";
            // 
            // comboBox_rotas
            // 
            comboBox_rotas.FormattingEnabled = true;
            comboBox_rotas.Location = new Point(77, 36);
            comboBox_rotas.Margin = new Padding(2);
            comboBox_rotas.Name = "comboBox_rotas";
            comboBox_rotas.Size = new Size(150, 28);
            comboBox_rotas.TabIndex = 1;
            comboBox_rotas.SelectedIndexChanged += comboBox_rotas_SelectedIndexChanged;
            // 
            // button_comprar
            // 
            button_comprar.Location = new Point(536, 385);
            button_comprar.Margin = new Padding(2);
            button_comprar.Name = "button_comprar";
            button_comprar.Size = new Size(92, 29);
            button_comprar.TabIndex = 5;
            button_comprar.Text = "Comprar";
            button_comprar.UseVisualStyleBackColor = true;
            button_comprar.Click += button_comprar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(632, 385);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(92, 29);
            button_limpar.TabIndex = 5;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(728, 385);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 5;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idrota, datavoo, horavoo, lugaresvoo, bilhetesuplente, precobilhete });
            dataGridView1.Location = new Point(274, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(665, 283);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idrota
            // 
            idrota.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idrota.HeaderText = "Nº VOO";
            idrota.MinimumWidth = 6;
            idrota.Name = "idrota";
            idrota.ReadOnly = true;
            idrota.Resizable = DataGridViewTriState.False;
            // 
            // datavoo
            // 
            datavoo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datavoo.HeaderText = "Data";
            datavoo.MinimumWidth = 6;
            datavoo.Name = "datavoo";
            datavoo.ReadOnly = true;
            datavoo.Resizable = DataGridViewTriState.False;
            datavoo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // horavoo
            // 
            horavoo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            horavoo.HeaderText = "Hora";
            horavoo.MinimumWidth = 6;
            horavoo.Name = "horavoo";
            horavoo.ReadOnly = true;
            horavoo.Resizable = DataGridViewTriState.False;
            // 
            // lugaresvoo
            // 
            lugaresvoo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lugaresvoo.HeaderText = "Lugares";
            lugaresvoo.MinimumWidth = 6;
            lugaresvoo.Name = "lugaresvoo";
            lugaresvoo.ReadOnly = true;
            lugaresvoo.Resizable = DataGridViewTriState.False;
            // 
            // bilhetesuplente
            // 
            bilhetesuplente.HeaderText = "Suplente";
            bilhetesuplente.MinimumWidth = 6;
            bilhetesuplente.Name = "bilhetesuplente";
            bilhetesuplente.ReadOnly = true;
            bilhetesuplente.Width = 96;
            // 
            // precobilhete
            // 
            precobilhete.HeaderText = "Preço";
            precobilhete.MinimumWidth = 6;
            precobilhete.Name = "precobilhete";
            precobilhete.ReadOnly = true;
            precobilhete.Width = 75;
            // 
            // Comprar_bilhete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 454);
            Controls.Add(dataGridView1);
            Controls.Add(button_Sair);
            Controls.Add(button_limpar);
            Controls.Add(button_comprar);
            Controls.Add(comboBox_rotas);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Comprar_bilhete";
            Text = " ";
            Load += Comprar_bilhete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox_rotas;
        private Button button_comprar;
        private Button button_limpar;
        private Button button_Sair;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idrota;
        private DataGridViewTextBoxColumn datavoo;
        private DataGridViewTextBoxColumn horavoo;
        private DataGridViewTextBoxColumn lugaresvoo;
        private DataGridViewTextBoxColumn bilhetesuplente;
        private DataGridViewTextBoxColumn precobilhete;
    }
}