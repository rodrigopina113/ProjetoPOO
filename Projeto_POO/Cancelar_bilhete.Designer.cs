namespace Projeto_POO
{
    partial class Cancelar_bilhete
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
            radioButton_efetivo = new RadioButton();
            radioButton_suplente = new RadioButton();
            button_cancelar = new Button();
            button_limpar = new Button();
            button_Sair = new Button();
            label1 = new Label();
            textBox_nif = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // radioButton_efetivo
            // 
            radioButton_efetivo.AutoSize = true;
            radioButton_efetivo.Location = new Point(292, 13);
            radioButton_efetivo.Name = "radioButton_efetivo";
            radioButton_efetivo.Size = new Size(200, 36);
            radioButton_efetivo.TabIndex = 0;
            radioButton_efetivo.TabStop = true;
            radioButton_efetivo.Text = "Bilhete efetivo";
            radioButton_efetivo.UseVisualStyleBackColor = true;
            radioButton_efetivo.CheckedChanged += radioButton_efetivo_CheckedChanged_1;
            // 
            // radioButton_suplente
            // 
            radioButton_suplente.AutoSize = true;
            radioButton_suplente.Location = new Point(515, 13);
            radioButton_suplente.Name = "radioButton_suplente";
            radioButton_suplente.Size = new Size(218, 36);
            radioButton_suplente.TabIndex = 0;
            radioButton_suplente.TabStop = true;
            radioButton_suplente.Text = "Bilhete suplente";
            radioButton_suplente.UseVisualStyleBackColor = true;
            radioButton_suplente.CheckedChanged += radioButton_suplente_CheckedChanged_1;
            // 
            // button_cancelar
            // 
            button_cancelar.Location = new Point(102, 146);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(223, 46);
            button_cancelar.TabIndex = 1;
            button_cancelar.Text = "Cancelar bilhete";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click_1;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(332, 146);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(150, 46);
            button_limpar.TabIndex = 1;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(488, 146);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(150, 46);
            button_Sair.TabIndex = 1;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(55, 32);
            label1.TabIndex = 2;
            label1.Text = "NIF:";
            // 
            // textBox_nif
            // 
            textBox_nif.Location = new Point(73, 6);
            textBox_nif.Name = "textBox_nif";
            textBox_nif.Size = new Size(201, 39);
            textBox_nif.TabIndex = 3;
            textBox_nif.TextChanged += textBox_nif_TextChanged_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 40);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 62);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 2;
            label2.Text = "Bilhete a cancelar:";
            // 
            // Cancelar_bilhete
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 205);
            Controls.Add(comboBox1);
            Controls.Add(textBox_nif);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Sair);
            Controls.Add(button_limpar);
            Controls.Add(button_cancelar);
            Controls.Add(radioButton_suplente);
            Controls.Add(radioButton_efetivo);
            Name = "Cancelar_bilhete";
            Text = "Cancelar_bilhete";
            Load += Cancelar_bilhete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton_efetivo;
        private RadioButton radioButton_suplente;
        private Button button_cancelar;
        private Button button_limpar;
        private Button button_Sair;
        private Label label1;
        private TextBox textBox_nif;
        private ComboBox comboBox1;
        private Label label2;
    }
}