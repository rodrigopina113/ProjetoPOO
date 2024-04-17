namespace Projeto_POO
{
    partial class Historico
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
            listBox_bilhetes = new ListBox();
            button_mostrar = new Button();
            button_Sair = new Button();
            textBox_nif = new TextBox();
            label1 = new Label();
            radioButton_suplente = new RadioButton();
            radioButton_efetivo = new RadioButton();
            SuspendLayout();
            // 
            // listBox_bilhetes
            // 
            listBox_bilhetes.FormattingEnabled = true;
            listBox_bilhetes.ItemHeight = 20;
            listBox_bilhetes.Location = new Point(266, 34);
            listBox_bilhetes.Margin = new Padding(2);
            listBox_bilhetes.Name = "listBox_bilhetes";
            listBox_bilhetes.Size = new Size(481, 124);
            listBox_bilhetes.TabIndex = 9;
            listBox_bilhetes.SelectedIndexChanged += listBox_bilhetes_SelectedIndexChanged;
            // 
            // button_mostrar
            // 
            button_mostrar.Location = new Point(535, 179);
            button_mostrar.Margin = new Padding(2);
            button_mostrar.Name = "button_mostrar";
            button_mostrar.Size = new Size(92, 29);
            button_mostrar.TabIndex = 7;
            button_mostrar.Text = "Mostrar";
            button_mostrar.UseVisualStyleBackColor = true;
            button_mostrar.Click += button_mostrar_Click;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(648, 179);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 8;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // textBox_nif
            // 
            textBox_nif.Location = new Point(113, 34);
            textBox_nif.Margin = new Padding(2);
            textBox_nif.Name = "textBox_nif";
            textBox_nif.Size = new Size(125, 27);
            textBox_nif.TabIndex = 6;
            textBox_nif.TextChanged += textBox_nif_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Passageiro:";
            label1.Click += label1_Click;
            // 
            // radioButton_suplente
            // 
            radioButton_suplente.AutoSize = true;
            radioButton_suplente.Location = new Point(43, 134);
            radioButton_suplente.Margin = new Padding(2);
            radioButton_suplente.Name = "radioButton_suplente";
            radioButton_suplente.Size = new Size(148, 24);
            radioButton_suplente.TabIndex = 10;
            radioButton_suplente.TabStop = true;
            radioButton_suplente.Text = "Bilhetes suplentes";
            radioButton_suplente.UseVisualStyleBackColor = true;
            radioButton_suplente.CheckedChanged += radioButton_suplente_CheckedChanged;
            // 
            // radioButton_efetivo
            // 
            radioButton_efetivo.AutoSize = true;
            radioButton_efetivo.Location = new Point(43, 108);
            radioButton_efetivo.Margin = new Padding(2);
            radioButton_efetivo.Name = "radioButton_efetivo";
            radioButton_efetivo.Size = new Size(138, 24);
            radioButton_efetivo.TabIndex = 11;
            radioButton_efetivo.TabStop = true;
            radioButton_efetivo.Text = "Bilhetes efetivos";
            radioButton_efetivo.UseVisualStyleBackColor = true;
            radioButton_efetivo.CheckedChanged += radioButton_efetivo_CheckedChanged;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 233);
            Controls.Add(radioButton_suplente);
            Controls.Add(radioButton_efetivo);
            Controls.Add(listBox_bilhetes);
            Controls.Add(button_mostrar);
            Controls.Add(button_Sair);
            Controls.Add(textBox_nif);
            Controls.Add(label1);
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_bilhetes;
        private Button button_mostrar;
        private Button button_Sair;
        private TextBox textBox_nif;
        private Label label1;
        private RadioButton radioButton_suplente;
        private RadioButton radioButton_efetivo;
    }
}