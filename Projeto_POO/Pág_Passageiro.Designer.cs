namespace Projeto_POO
{
    partial class Pág_Passageiro
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
            menuStrip1 = new MenuStrip();
            registarToolStripMenuItem = new ToolStripMenuItem();
            bilhetesToolStripMenuItem = new ToolStripMenuItem();
            comprarToolStripMenuItem = new ToolStripMenuItem();
            bilheteToolStripMenuItem = new ToolStripMenuItem();
            rotasToolStripMenuItem = new ToolStripMenuItem();
            listarRotasvoosToolStripMenuItem = new ToolStripMenuItem();
            voosToolStripMenuItem1 = new ToolStripMenuItem();
            voosToolStripMenuItem = new ToolStripMenuItem();
            listarVoosEfetivosToolStripMenuItem = new ToolStripMenuItem();
            históricoToolStripMenuItem = new ToolStripMenuItem();
            listarHistóricoDoPassageiroToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registarToolStripMenuItem, bilhetesToolStripMenuItem, rotasToolStripMenuItem, voosToolStripMenuItem, históricoToolStripMenuItem, voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(708, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registarToolStripMenuItem
            // 
            registarToolStripMenuItem.Name = "registarToolStripMenuItem";
            registarToolStripMenuItem.Size = new Size(77, 24);
            registarToolStripMenuItem.Text = "Registar";
            registarToolStripMenuItem.Click += registarToolStripMenuItem_Click;
            // 
            // bilhetesToolStripMenuItem
            // 
            bilhetesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comprarToolStripMenuItem, bilheteToolStripMenuItem });
            bilhetesToolStripMenuItem.Name = "bilhetesToolStripMenuItem";
            bilhetesToolStripMenuItem.Size = new Size(75, 24);
            bilhetesToolStripMenuItem.Text = "Bilhetes";
            // 
            // comprarToolStripMenuItem
            // 
            comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            comprarToolStripMenuItem.Size = new Size(261, 26);
            comprarToolStripMenuItem.Text = "Comprar";
            comprarToolStripMenuItem.Click += comprarToolStripMenuItem_Click;
            // 
            // bilheteToolStripMenuItem
            // 
            bilheteToolStripMenuItem.Name = "bilheteToolStripMenuItem";
            bilheteToolStripMenuItem.Size = new Size(261, 26);
            bilheteToolStripMenuItem.Text = "Cancelar efetivo/suplente";
            bilheteToolStripMenuItem.Click += BilheteToolStripMenuItem_Click;
            // 
            // rotasToolStripMenuItem
            // 
            rotasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarRotasvoosToolStripMenuItem, voosToolStripMenuItem1 });
            rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
            rotasToolStripMenuItem.Size = new Size(60, 24);
            rotasToolStripMenuItem.Text = "Rotas";
            // 
            // listarRotasvoosToolStripMenuItem
            // 
            listarRotasvoosToolStripMenuItem.Name = "listarRotasvoosToolStripMenuItem";
            listarRotasvoosToolStripMenuItem.Size = new Size(129, 26);
            listarRotasvoosToolStripMenuItem.Text = "Rotas";
            listarRotasvoosToolStripMenuItem.Click += ListarRotasvoosToolStripMenuItem_Click;
            // 
            // voosToolStripMenuItem1
            // 
            voosToolStripMenuItem1.Name = "voosToolStripMenuItem1";
            voosToolStripMenuItem1.Size = new Size(129, 26);
            voosToolStripMenuItem1.Text = "Voos";
            voosToolStripMenuItem1.Click += VoosToolStripMenuItem1_Click;
            // 
            // voosToolStripMenuItem
            // 
            voosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarVoosEfetivosToolStripMenuItem });
            voosToolStripMenuItem.Name = "voosToolStripMenuItem";
            voosToolStripMenuItem.Size = new Size(55, 24);
            voosToolStripMenuItem.Text = "Voos";
            // 
            // listarVoosEfetivosToolStripMenuItem
            // 
            listarVoosEfetivosToolStripMenuItem.Name = "listarVoosEfetivosToolStripMenuItem";
            listarVoosEfetivosToolStripMenuItem.Size = new Size(162, 26);
            listarVoosEfetivosToolStripMenuItem.Text = "Listar voos";
            listarVoosEfetivosToolStripMenuItem.Click += listarVoosEfetivosToolStripMenuItem_Click;
            // 
            // históricoToolStripMenuItem
            // 
            históricoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarHistóricoDoPassageiroToolStripMenuItem });
            históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            históricoToolStripMenuItem.Size = new Size(83, 24);
            históricoToolStripMenuItem.Text = "Histórico";
            // 
            // listarHistóricoDoPassageiroToolStripMenuItem
            // 
            listarHistóricoDoPassageiroToolStripMenuItem.Name = "listarHistóricoDoPassageiroToolStripMenuItem";
            listarHistóricoDoPassageiroToolStripMenuItem.Size = new Size(286, 26);
            listarHistóricoDoPassageiroToolStripMenuItem.Text = "Listar histórico do passageiro";
            listarHistóricoDoPassageiroToolStripMenuItem.Click += listarHistóricoDoPassageiroToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(48, 24);
            voltarToolStripMenuItem.Text = "Sair";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // Pág_Passageiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 396);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Pág_Passageiro";
            Text = "Pág_Passageiro";
            Load += Pág_Passageiro_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bilhetesToolStripMenuItem;
        private ToolStripMenuItem comprarToolStripMenuItem;
        private ToolStripMenuItem bilheteToolStripMenuItem;
        private ToolStripMenuItem rotasToolStripMenuItem;
        private ToolStripMenuItem voosToolStripMenuItem;
        private ToolStripMenuItem históricoToolStripMenuItem;
        private ToolStripMenuItem listarHistóricoDoPassageiroToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private ToolStripMenuItem registarToolStripMenuItem;
        private ToolStripMenuItem listarRotasvoosToolStripMenuItem;
        private ToolStripMenuItem listarVoosEfetivosToolStripMenuItem;
        private ToolStripMenuItem voosToolStripMenuItem1;
    }
}