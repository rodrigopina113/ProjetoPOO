namespace Projeto_POO
{
    partial class List_Voos
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            button_listar = new Button();
            button_limpar = new Button();
            button_Sair = new Button();
            dataGridView1 = new DataGridView();
            idrota = new DataGridViewTextBoxColumn();
            datavoo = new DataGridViewTextBoxColumn();
            horavoo = new DataGridViewTextBoxColumn();
            aviaovoo = new DataGridViewTextBoxColumn();
            lugaresvoo = new DataGridViewTextBoxColumn();
            suplentes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Rota:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(64, 36);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button_listar
            // 
            button_listar.Location = new Point(299, 300);
            button_listar.Margin = new Padding(2);
            button_listar.Name = "button_listar";
            button_listar.Size = new Size(104, 39);
            button_listar.TabIndex = 5;
            button_listar.Text = "Listar";
            button_listar.UseVisualStyleBackColor = true;
            button_listar.Click += button_listar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(427, 300);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(105, 39);
            button_limpar.TabIndex = 5;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(556, 300);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(122, 39);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idrota, datavoo, horavoo, aviaovoo, lugaresvoo, suplentes });
            dataGridView1.Location = new Point(240, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(756, 268);
            dataGridView1.TabIndex = 6;
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
            // aviaovoo
            // 
            aviaovoo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aviaovoo.HeaderText = "Avião";
            aviaovoo.MinimumWidth = 6;
            aviaovoo.Name = "aviaovoo";
            aviaovoo.ReadOnly = true;
            aviaovoo.Resizable = DataGridViewTriState.False;
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
            // suplentes
            // 
            suplentes.HeaderText = "Suplentes";
            suplentes.MinimumWidth = 6;
            suplentes.Name = "suplentes";
            suplentes.ReadOnly = true;
            suplentes.Width = 102;
            // 
            // List_Voos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 372);
            Controls.Add(dataGridView1);
            Controls.Add(button_Sair);
            Controls.Add(button_limpar);
            Controls.Add(button_listar);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "List_Voos";
            Text = "Listar_rotas_voos";
            Load += List_Voos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button_listar;
        private Button button_limpar;
        private Button button_Sair;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idrota;
        private DataGridViewTextBoxColumn datavoo;
        private DataGridViewTextBoxColumn horavoo;
        private DataGridViewTextBoxColumn aviaovoo;
        private DataGridViewTextBoxColumn lugaresvoo;
        private DataGridViewTextBoxColumn suplentes;
    }
}