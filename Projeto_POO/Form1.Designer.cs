namespace Projeto_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_administracao = new Button();
            button_passageiro = new Button();
            button_sair = new Button();
            SuspendLayout();
            // 
            // button_administracao
            // 
            button_administracao.Location = new Point(117, 11);
            button_administracao.Margin = new Padding(2);
            button_administracao.Name = "button_administracao";
            button_administracao.Size = new Size(115, 29);
            button_administracao.TabIndex = 2;
            button_administracao.Text = "Administração";
            button_administracao.UseVisualStyleBackColor = true;
            button_administracao.Click += Button_administracao_Click;
            // 
            // button_passageiro
            // 
            button_passageiro.Location = new Point(11, 11);
            button_passageiro.Margin = new Padding(2);
            button_passageiro.Name = "button_passageiro";
            button_passageiro.Size = new Size(92, 29);
            button_passageiro.TabIndex = 3;
            button_passageiro.Text = "Passageiro";
            button_passageiro.UseVisualStyleBackColor = true;
            button_passageiro.Click += Button_passageiro_Click;
            // 
            // button_sair
            // 
            button_sair.Location = new Point(217, 130);
            button_sair.Margin = new Padding(2);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(115, 29);
            button_sair.TabIndex = 4;
            button_sair.Text = "Sair";
            button_sair.UseVisualStyleBackColor = true;
            button_sair.Click += Button_sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 195);
            Controls.Add(button_sair);
            Controls.Add(button_administracao);
            Controls.Add(button_passageiro);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_administracao;
        private Button button_passageiro;
        private Button button_sair;
    }
}