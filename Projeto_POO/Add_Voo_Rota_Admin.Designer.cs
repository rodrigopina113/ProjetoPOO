namespace Projeto_POO
{
    partial class Add_Voo_Rota_Admin
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
            textBox_id = new TextBox();
            button_adicionar = new Button();
            button_limpar = new Button();
            button_Sair = new Button();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker_data = new DateTimePicker();
            maskedTextBox_hora = new MaskedTextBox();
            label5 = new Label();
            comboBox_aviao = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Nº voo:";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(126, 32);
            textBox_id.Margin = new Padding(2);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(248, 27);
            textBox_id.TabIndex = 1;
            textBox_id.TextChanged += textBox_id_TextChanged;
            // 
            // button_adicionar
            // 
            button_adicionar.Location = new Point(246, 434);
            button_adicionar.Margin = new Padding(2);
            button_adicionar.Name = "button_adicionar";
            button_adicionar.Size = new Size(92, 29);
            button_adicionar.TabIndex = 2;
            button_adicionar.Text = "Adicionar";
            button_adicionar.UseVisualStyleBackColor = true;
            button_adicionar.Click += button_adicionar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(342, 434);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(92, 29);
            button_limpar.TabIndex = 2;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += button_limpar_Click;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(438, 434);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 2;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 0;
            label3.Text = "Hora:";
            // 
            // dateTimePicker_data
            // 
            dateTimePicker_data.Location = new Point(126, 71);
            dateTimePicker_data.Margin = new Padding(2);
            dateTimePicker_data.Name = "dateTimePicker_data";
            dateTimePicker_data.Size = new Size(248, 27);
            dateTimePicker_data.TabIndex = 3;
            dateTimePicker_data.ValueChanged += dateTimePicker_data_ValueChanged;
            // 
            // maskedTextBox_hora
            // 
            maskedTextBox_hora.Location = new Point(126, 110);
            maskedTextBox_hora.Margin = new Padding(2);
            maskedTextBox_hora.Mask = "00:00";
            maskedTextBox_hora.Name = "maskedTextBox_hora";
            maskedTextBox_hora.Size = new Size(248, 27);
            maskedTextBox_hora.TabIndex = 4;
            maskedTextBox_hora.ValidatingType = typeof(DateTime);
            maskedTextBox_hora.MaskInputRejected += maskedTextBox_hora_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 159);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Avião:";
            label5.Click += label5_Click;
            // 
            // comboBox_aviao
            // 
            comboBox_aviao.FormattingEnabled = true;
            comboBox_aviao.Location = new Point(117, 159);
            comboBox_aviao.Margin = new Padding(2);
            comboBox_aviao.Name = "comboBox_aviao";
            comboBox_aviao.Size = new Size(257, 28);
            comboBox_aviao.TabIndex = 6;
            comboBox_aviao.SelectedIndexChanged += comboBox_aviao_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(455, 46);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 46);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 7;
            label6.Text = "Rota:";
            // 
            // Add_Voo_Rota_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 501);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(comboBox_aviao);
            Controls.Add(label5);
            Controls.Add(maskedTextBox_hora);
            Controls.Add(dateTimePicker_data);
            Controls.Add(button_Sair);
            Controls.Add(button_limpar);
            Controls.Add(button_adicionar);
            Controls.Add(textBox_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Add_Voo_Rota_Admin";
            Text = "Add_Voo_Rota_Admin";
            Load += Add_Voo_Rota_Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_id;
        private Button button_adicionar;
        private Button button_limpar;
        private Button button_Sair;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker_data;
        private MaskedTextBox maskedTextBox_hora;
        private Label label5;
        private ComboBox comboBox_aviao;
        private ComboBox comboBox1;
        private Label label6;
    }
}