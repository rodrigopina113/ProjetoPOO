namespace Projeto_POO
{
    partial class Add_Rota_Admin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_id = new TextBox();
            textBox_destino = new TextBox();
            textBox_distancia = new TextBox();
            textBox_voos = new TextBox();
            button_adicionar = new Button();
            button_limpar = new Button();
            button_Sair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "ID de rota:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Nº de voos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 6);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Destino:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 35);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 0;
            label4.Text = "Distância:";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(88, 4);
            textBox_id.Margin = new Padding(2);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(133, 27);
            textBox_id.TabIndex = 1;
            textBox_id.TextChanged += TextBox_id_TextChanged;
            // 
            // textBox_destino
            // 
            textBox_destino.Location = new Point(330, 6);
            textBox_destino.Margin = new Padding(2);
            textBox_destino.Name = "textBox_destino";
            textBox_destino.Size = new Size(133, 27);
            textBox_destino.TabIndex = 1;
            textBox_destino.TextChanged += TextBox_destino_TextChanged;
            // 
            // textBox_distancia
            // 
            textBox_distancia.Location = new Point(88, 35);
            textBox_distancia.Margin = new Padding(2);
            textBox_distancia.Name = "textBox_distancia";
            textBox_distancia.Size = new Size(133, 27);
            textBox_distancia.TabIndex = 1;
            textBox_distancia.TextChanged += TextBox3_TextChanged;
            // 
            // textBox_voos
            // 
            textBox_voos.AutoCompleteCustomSource.AddRange(new string[] { "0" });
            textBox_voos.Enabled = false;
            textBox_voos.Location = new Point(338, 33);
            textBox_voos.Margin = new Padding(2);
            textBox_voos.Name = "textBox_voos";
            textBox_voos.PlaceholderText = "0";
            textBox_voos.Size = new Size(125, 27);
            textBox_voos.TabIndex = 1;
            textBox_voos.Text = "0";
            textBox_voos.TextChanged += TextBox3_TextChanged;
            // 
            // button_adicionar
            // 
            button_adicionar.Location = new Point(94, 106);
            button_adicionar.Margin = new Padding(2);
            button_adicionar.Name = "button_adicionar";
            button_adicionar.Size = new Size(92, 29);
            button_adicionar.TabIndex = 2;
            button_adicionar.Text = "Adicionar";
            button_adicionar.UseVisualStyleBackColor = true;
            button_adicionar.Click += Button_adicionar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(190, 106);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(92, 29);
            button_limpar.TabIndex = 2;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += Button_limpar_Click;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(286, 106);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 2;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += Button_Sair_Click;
            // 
            // Add_Rota_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 144);
            Controls.Add(button_Sair);
            Controls.Add(button_limpar);
            Controls.Add(button_adicionar);
            Controls.Add(textBox_voos);
            Controls.Add(textBox_distancia);
            Controls.Add(textBox_destino);
            Controls.Add(textBox_id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Add_Rota_Admin";
            Text = "Add_Rota_Admin";
            Load += Add_Rota_Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_id;
        private TextBox textBox_destino;
        private TextBox textBox_distancia;
        private TextBox textBox_voos;
        private Button button_adicionar;
        private Button button_limpar;
        private Button button_Sair;
    }
}