namespace Projeto_POO
{
    partial class Reg_passageiro
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
            button_registar = new Button();
            button_limpar = new Button();
            button_Sair = new Button();
            textBox_nome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_nif = new TextBox();
            textBox_morada = new TextBox();
            dateTimePicker_nascimento = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // button_registar
            // 
            button_registar.Location = new Point(58, 138);
            button_registar.Margin = new Padding(2);
            button_registar.Name = "button_registar";
            button_registar.Size = new Size(92, 29);
            button_registar.TabIndex = 1;
            button_registar.Text = "Registar";
            button_registar.UseVisualStyleBackColor = true;
            button_registar.Click += Button_registar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(154, 138);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(92, 29);
            button_limpar.TabIndex = 1;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += Button_limpar_Click;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(250, 138);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 1;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += Button_Sair_Click;
            // 
            // textBox_nome
            // 
            textBox_nome.Location = new Point(63, 5);
            textBox_nome.Margin = new Padding(2);
            textBox_nome.Name = "textBox_nome";
            textBox_nome.Size = new Size(338, 27);
            textBox_nome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 0;
            label2.Text = "NIF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 0;
            label3.Text = "Data de nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 103);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Morada:";
            // 
            // textBox_nif
            // 
            textBox_nif.Location = new Point(45, 36);
            textBox_nif.Margin = new Padding(2);
            textBox_nif.Name = "textBox_nif";
            textBox_nif.Size = new Size(357, 27);
            textBox_nif.TabIndex = 2;
            // 
            // textBox_morada
            // 
            textBox_morada.Location = new Point(73, 101);
            textBox_morada.Margin = new Padding(2);
            textBox_morada.Name = "textBox_morada";
            textBox_morada.Size = new Size(328, 27);
            textBox_morada.TabIndex = 2;
            // 
            // dateTimePicker_nascimento
            // 
            dateTimePicker_nascimento.Format = DateTimePickerFormat.Short;
            dateTimePicker_nascimento.Location = new Point(154, 68);
            dateTimePicker_nascimento.Margin = new Padding(2);
            dateTimePicker_nascimento.MaxDate = new DateTime(2023, 12, 11, 0, 0, 0, 0);
            dateTimePicker_nascimento.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dateTimePicker_nascimento.Name = "dateTimePicker_nascimento";
            dateTimePicker_nascimento.Size = new Size(248, 27);
            dateTimePicker_nascimento.TabIndex = 3;
            dateTimePicker_nascimento.Value = new DateTime(2005, 12, 25, 0, 0, 0, 0);
            dateTimePicker_nascimento.ValueChanged += dateTimePicker_nascimento_ValueChanged;
            // 
            // Reg_passageiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 185);
            Controls.Add(dateTimePicker_nascimento);
            Controls.Add(textBox_morada);
            Controls.Add(textBox_nif);
            Controls.Add(textBox_nome);
            Controls.Add(button_Sair);
            Controls.Add(button_limpar);
            Controls.Add(button_registar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Reg_passageiro";
            Text = "Reg_passageiro";
            Load += Reg_passageiro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_registar;
        private Button button_limpar;
        private Button button_Sair;
        private TextBox textBox_nome;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_nif;
        private TextBox textBox_morada;
        private DateTimePicker dateTimePicker_nascimento;
    }
}