namespace Projeto_POO
{
    partial class Pág_administracao
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            bilhetesToolStripMenuItem = new ToolStripMenuItem();
            listarBilhetesToolStripMenuItem = new ToolStripMenuItem();
            passageirosToolStripMenuItem = new ToolStripMenuItem();
            listarPassageirosToolStripMenuItem = new ToolStripMenuItem();
            rotasToolStripMenuItem = new ToolStripMenuItem();
            adicionarRotaToolStripMenuItem = new ToolStripMenuItem();
            adiconarRotaToolStripMenuItem = new ToolStripMenuItem();
            adicionarVooAUmaRotaToolStripMenuItem = new ToolStripMenuItem();
            listarRotasToolStripMenuItem = new ToolStripMenuItem();
            voosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bilhetesToolStripMenuItem, passageirosToolStripMenuItem, rotasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(723, 26);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // bilhetesToolStripMenuItem
            // 
            bilhetesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarBilhetesToolStripMenuItem });
            bilhetesToolStripMenuItem.Name = "bilhetesToolStripMenuItem";
            bilhetesToolStripMenuItem.Size = new Size(75, 24);
            bilhetesToolStripMenuItem.Text = "Bilhetes";
            // 
            // listarBilhetesToolStripMenuItem
            // 
            listarBilhetesToolStripMenuItem.Name = "listarBilhetesToolStripMenuItem";
            listarBilhetesToolStripMenuItem.Size = new Size(224, 26);
            listarBilhetesToolStripMenuItem.Text = "Listar bilhetes";
            listarBilhetesToolStripMenuItem.Click += listarBilhetesToolStripMenuItem_Click;
            // 
            // passageirosToolStripMenuItem
            // 
            passageirosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarPassageirosToolStripMenuItem });
            passageirosToolStripMenuItem.Name = "passageirosToolStripMenuItem";
            passageirosToolStripMenuItem.Size = new Size(99, 24);
            passageirosToolStripMenuItem.Text = "Passageiros";
            // 
            // listarPassageirosToolStripMenuItem
            // 
            listarPassageirosToolStripMenuItem.Name = "listarPassageirosToolStripMenuItem";
            listarPassageirosToolStripMenuItem.Size = new Size(224, 26);
            listarPassageirosToolStripMenuItem.Text = "Listar passageiros";
            listarPassageirosToolStripMenuItem.Click += listarPassageirosToolStripMenuItem_Click;
            // 
            // rotasToolStripMenuItem
            // 
            rotasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarRotaToolStripMenuItem, listarRotasToolStripMenuItem, voosToolStripMenuItem });
            rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
            rotasToolStripMenuItem.Size = new Size(60, 24);
            rotasToolStripMenuItem.Text = "Rotas";
            // 
            // adicionarRotaToolStripMenuItem
            // 
            adicionarRotaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adiconarRotaToolStripMenuItem, adicionarVooAUmaRotaToolStripMenuItem });
            adicionarRotaToolStripMenuItem.Name = "adicionarRotaToolStripMenuItem";
            adicionarRotaToolStripMenuItem.Size = new Size(156, 26);
            adicionarRotaToolStripMenuItem.Text = "Adicionar";
            // 
            // adiconarRotaToolStripMenuItem
            // 
            adiconarRotaToolStripMenuItem.Name = "adiconarRotaToolStripMenuItem";
            adiconarRotaToolStripMenuItem.Size = new Size(261, 26);
            adiconarRotaToolStripMenuItem.Text = "Adicionar rota";
            adiconarRotaToolStripMenuItem.Click += adiconarRotaToolStripMenuItem_Click;
            // 
            // adicionarVooAUmaRotaToolStripMenuItem
            // 
            adicionarVooAUmaRotaToolStripMenuItem.Name = "adicionarVooAUmaRotaToolStripMenuItem";
            adicionarVooAUmaRotaToolStripMenuItem.Size = new Size(261, 26);
            adicionarVooAUmaRotaToolStripMenuItem.Text = "Adicionar voo a uma rota";
            adicionarVooAUmaRotaToolStripMenuItem.Click += adicionarVooAUmaRotaToolStripMenuItem_Click;
            // 
            // listarRotasToolStripMenuItem
            // 
            listarRotasToolStripMenuItem.Name = "listarRotasToolStripMenuItem";
            listarRotasToolStripMenuItem.Size = new Size(156, 26);
            listarRotasToolStripMenuItem.Text = "Rotas";
            listarRotasToolStripMenuItem.Click += listarRotasToolStripMenuItem_Click;
            // 
            // voosToolStripMenuItem
            // 
            voosToolStripMenuItem.Name = "voosToolStripMenuItem";
            voosToolStripMenuItem.Size = new Size(156, 26);
            voosToolStripMenuItem.Text = "Voos";
            voosToolStripMenuItem.Click += voosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Pág_administracao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 415);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Pág_administracao";
            Text = "Pág_administracao";
            Load += Pág_administracao_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bilhetesToolStripMenuItem;
        private ToolStripMenuItem listarBilhetesToolStripMenuItem;
        private ToolStripMenuItem passageirosToolStripMenuItem;
        private ToolStripMenuItem rotasToolStripMenuItem;
        private ToolStripMenuItem adicionarRotaToolStripMenuItem;
        private ToolStripMenuItem listarRotasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem listarPassageirosToolStripMenuItem;
        private ToolStripMenuItem adiconarRotaToolStripMenuItem;
        private ToolStripMenuItem adicionarVooAUmaRotaToolStripMenuItem;
        private ToolStripMenuItem voosToolStripMenuItem;
    }
}