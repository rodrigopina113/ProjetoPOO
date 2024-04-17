namespace Projeto_POO
{
    partial class List_Pass_admin
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
            radioButton_efetivos = new RadioButton();
            radioButton_suplentes = new RadioButton();
            listBox_passageiros = new ListBox();
            button_mostrar = new Button();
            button_limpar = new Button();
            button_Sair = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // radioButton_efetivos
            // 
            radioButton_efetivos.AutoSize = true;
            radioButton_efetivos.Location = new Point(11, 64);
            radioButton_efetivos.Margin = new Padding(2);
            radioButton_efetivos.Name = "radioButton_efetivos";
            radioButton_efetivos.Size = new Size(162, 24);
            radioButton_efetivos.TabIndex = 0;
            radioButton_efetivos.TabStop = true;
            radioButton_efetivos.Text = "Passageiros efetivos";
            radioButton_efetivos.UseVisualStyleBackColor = true;
            radioButton_efetivos.CheckedChanged += radioButton_efetivos_CheckedChanged;
            // 
            // radioButton_suplentes
            // 
            radioButton_suplentes.AutoSize = true;
            radioButton_suplentes.Location = new Point(11, 93);
            radioButton_suplentes.Margin = new Padding(2);
            radioButton_suplentes.Name = "radioButton_suplentes";
            radioButton_suplentes.Size = new Size(172, 24);
            radioButton_suplentes.TabIndex = 0;
            radioButton_suplentes.TabStop = true;
            radioButton_suplentes.Text = "Passageiros suplentes";
            radioButton_suplentes.UseVisualStyleBackColor = true;
            radioButton_suplentes.CheckedChanged += radioButton_suplentes_CheckedChanged;
            // 
            // listBox_passageiros
            // 
            listBox_passageiros.FormattingEnabled = true;
            listBox_passageiros.ItemHeight = 20;
            listBox_passageiros.Location = new Point(206, 8);
            listBox_passageiros.Margin = new Padding(2);
            listBox_passageiros.Name = "listBox_passageiros";
            listBox_passageiros.Size = new Size(508, 204);
            listBox_passageiros.TabIndex = 1;
            listBox_passageiros.SelectedIndexChanged += listBox_passageiros_SelectedIndexChanged;
            // 
            // button_mostrar
            // 
            button_mostrar.Location = new Point(7, 136);
            button_mostrar.Margin = new Padding(2);
            button_mostrar.Name = "button_mostrar";
            button_mostrar.Size = new Size(92, 29);
            button_mostrar.TabIndex = 2;
            button_mostrar.Text = "Mostrar";
            button_mostrar.UseVisualStyleBackColor = true;
            button_mostrar.Click += button_mostrar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(7, 181);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(92, 29);
            button_limpar.TabIndex = 2;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(103, 181);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 2;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 4;
            label1.Text = "IdVoo";
            label1.Click += label1_Click;
            // 
            // List_Pass_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 223);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button_Sair);
            Controls.Add(button_limpar);
            Controls.Add(button_mostrar);
            Controls.Add(listBox_passageiros);
            Controls.Add(radioButton_suplentes);
            Controls.Add(radioButton_efetivos);
            Margin = new Padding(2);
            Name = "List_Pass_admin";
            Text = "List_Pass_admin";
            Load += List_Pass_admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton_efetivos;
        private RadioButton radioButton_suplentes;
        private ListBox listBox_passageiros;
        private Button button_mostrar;
        private Button button_limpar;
        private Button button_Sair;
        private TextBox textBox1;
        private Label label1;
    }
}