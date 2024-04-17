using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_POO
{
    public partial class Pág_administracao : Form
    {

        private Gestor gestor;

        public Pág_administracao(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void Pág_administracao_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listarRotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Rota listarrotas = new List_Rota(gestor);
            listarrotas.Show();
        }

        private void voosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Voos listavoos = new List_Voos(gestor);
            listavoos.Show();
        }

        private void adiconarRotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Rota_Admin addrota = new Add_Rota_Admin(gestor);
            addrota.Show();
        }

        private void adicionarVooAUmaRotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Voo_Rota_Admin addvoo = new Add_Voo_Rota_Admin(gestor);
            addvoo.Show();
        }

        private void listarBilhetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Bilh_Admin listbilhete = new List_Bilh_Admin(gestor);
            listbilhete.Show();
        }

        private void listarPassageirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Pass_admin listarpass = new List_Pass_admin(gestor);
            listarpass.Show();
        }
    }
}
