namespace Projeto_POO
{
    partial class List_Rota
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
            button_Sair = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nvoos = new DataGridViewTextBoxColumn();
            destiny = new DataGridViewTextBoxColumn();
            distance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(465, 211);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 2;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nvoos, destiny, distance });
            dataGridView1.Location = new Point(86, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(499, 150);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // nvoos
            // 
            nvoos.HeaderText = "Nº Voos";
            nvoos.MinimumWidth = 6;
            nvoos.Name = "nvoos";
            nvoos.Width = 125;
            // 
            // destiny
            // 
            destiny.HeaderText = "Destino";
            destiny.MinimumWidth = 6;
            destiny.Name = "destiny";
            destiny.Width = 125;
            // 
            // distance
            // 
            distance.HeaderText = "Distancia";
            distance.MinimumWidth = 6;
            distance.Name = "distance";
            distance.Width = 125;
            // 
            // List_Rota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 271);
            Controls.Add(dataGridView1);
            Controls.Add(button_Sair);
            Margin = new Padding(2);
            Name = "List_Rota";
            Text = "List_Rota_Voo";
            Load += List_Rota_Voo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_Sair;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nvoos;
        private DataGridViewTextBoxColumn destiny;
        private DataGridViewTextBoxColumn distance;
    }
}