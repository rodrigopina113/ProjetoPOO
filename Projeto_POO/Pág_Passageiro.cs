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
    public partial class Pág_Passageiro : Form
    {

        private Gestor gestor;

        public Pág_Passageiro(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pág_Passageiro_Load(object sender, EventArgs e)
        {

        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg_passageiro regpass = new(gestor)
            {
                MdiParent = this    // "pai" do form2 é o form1
            };
            regpass.Show();              // mostra o form2 - Form_Cliente
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comprar_bilhete compbilhete = new Comprar_bilhete(gestor);
            compbilhete.Show();
        }

        private void BilheteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancelar_bilhete cancelbilhete = new Cancelar_bilhete(gestor);
            cancelbilhete.Show();
        }

        private void ListarRotasvoosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Rota listarrotas = new List_Rota(gestor);
            listarrotas.Show();
        }

        private void VoosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List_Voos listavoos = new(gestor);
            listavoos.Show();
        }

        private void listarVoosEfetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Bilh_Admin listbilhete = new List_Bilh_Admin(gestor);
            listbilhete.Show();
        }

        private void listarHistóricoDoPassageiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historico hist = new Historico(gestor);
            hist.Show();
        }
    }
}
