namespace Projeto_POO
{
    partial class List_Bilh_Admin
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
            textBox_nif = new TextBox();
            radioButton_efetivo = new RadioButton();
            radioButton_suplente = new RadioButton();
            button_Sair = new Button();
            button_limpar = new Button();
            button_mostrar = new Button();
            listBox_bilhetes = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Passageiro:";
            // 
            // textBox_nif
            // 
            textBox_nif.Location = new Point(104, 22);
            textBox_nif.Margin = new Padding(2);
            textBox_nif.Name = "textBox_nif";
            textBox_nif.Size = new Size(125, 27);
            textBox_nif.TabIndex = 1;
            textBox_nif.TextChanged += textBox_nif_TextChanged;
            // 
            // radioButton_efetivo
            // 
            radioButton_efetivo.AutoSize = true;
            radioButton_efetivo.Location = new Point(20, 65);
            radioButton_efetivo.Margin = new Padding(2);
            radioButton_efetivo.Name = "radioButton_efetivo";
            radioButton_efetivo.Size = new Size(138, 24);
            radioButton_efetivo.TabIndex = 2;
            radioButton_efetivo.TabStop = true;
            radioButton_efetivo.Text = "Bilhetes efetivos";
            radioButton_efetivo.UseVisualStyleBackColor = true;
            radioButton_efetivo.CheckedChanged += radioButton_efetivo_CheckedChanged;
            // 
            // radioButton_suplente
            // 
            radioButton_suplente.AutoSize = true;
            radioButton_suplente.Location = new Point(20, 91);
            radioButton_suplente.Margin = new Padding(2);
            radioButton_suplente.Name = "radioButton_suplente";
            radioButton_suplente.Size = new Size(148, 24);
            radioButton_suplente.TabIndex = 2;
            radioButton_suplente.TabStop = true;
            radioButton_suplente.Text = "Bilhetes suplentes";
            radioButton_suplente.UseVisualStyleBackColor = true;
            radioButton_suplente.CheckedChanged += radioButton_suplente_CheckedChanged;
            // 
            // button_Sair
            // 
            button_Sair.Location = new Point(639, 167);
            button_Sair.Margin = new Padding(2);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(92, 29);
            button_Sair.TabIndex = 3;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = true;
            button_Sair.Click += button_Sair_Click;
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(543, 167);
            button_limpar.Margin = new Padding(2);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(92, 29);
            button_limpar.TabIndex = 3;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += button_limpar_Click;
            // 
            // button_mostrar
            // 
            button_mostrar.Location = new Point(20, 167);
            button_mostrar.Margin = new Padding(2);
            button_mostrar.Name = "button_mostrar";
            button_mostrar.Size = new Size(92, 29);
            button_mostrar.TabIndex = 3;
            button_mostrar.Text = "Mostrar";
            button_mostrar.UseVisualStyleBackColor = true;
            button_mostrar.Click += button_mostrar_Click;
            // 
            // listBox_bilhetes
            // 
            listBox_bilhetes.FormattingEnabled = true;
            listBox_bilhetes.ItemHeight = 20;
            listBox_bilhetes.Location = new Point(257, 22);
            listBox_bilhetes.Margin = new Padding(2);
            listBox_bilhetes.Name = "listBox_bilhetes";
            listBox_bilhetes.Size = new Size(481, 124);
            listBox_bilhetes.TabIndex = 4;
            listBox_bilhetes.SelectedIndexChanged += listBox_bilhetes_SelectedIndexChanged;
            // 
            // List_Bilh_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 216);
            Controls.Add(listBox_bilhetes);
            Controls.Add(button_mostrar);
            Controls.Add(button_limpar);
            Controls.Add(button_Sair);
            Controls.Add(radioButton_suplente);
            Controls.Add(radioButton_efetivo);
            Controls.Add(textBox_nif);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "List_Bilh_Admin";
            Text = "List_Bilh_Admin";
            Load += List_Bilh_Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_nif;
        private RadioButton radioButton_efetivo;
        private RadioButton radioButton_suplente;
        private Button button_Sair;
        private Button button_limpar;
        private Button button_mostrar;
        private ListBox listBox_bilhetes;
    }
}