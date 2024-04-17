namespace Projeto_POO
{
    partial class Autenticacao
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button_limpar = new Button();
            button_proximo = new Button();
            button_sair = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 46);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 91);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(151, 154);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(92, 29);
            button_limpar.TabIndex = 3;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_proximo
            // 
            button_proximo.Location = new Point(247, 154);
            button_proximo.Margin = new Padding(2);
            button_proximo.Name = "button_proximo";
            button_proximo.Size = new Size(92, 29);
            button_proximo.TabIndex = 3;
            button_proximo.Text = "Próximo";
            button_proximo.UseVisualStyleBackColor = true;
            button_proximo.Click += button_proximo_Click;
            // 
            // button_sair
            // 
            button_sair.Location = new Point(55, 154);
            button_sair.Margin = new Padding(2);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(92, 29);
            button_sair.TabIndex = 3;
            button_sair.Text = "Sair";
            button_sair.UseVisualStyleBackColor = true;
            button_sair.Click += button_voltar_Click;
            // 
            // Autenticacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 225);
            Controls.Add(button_proximo);
            Controls.Add(button_sair);
            Controls.Add(button_limpar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "Autenticacao";
            Text = "Autenticacao";
            Load += Autenticacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_limpar;
        private Button button_proximo;
        private Button button_sair;
    }
}