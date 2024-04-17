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
    public partial class Autenticacao : Form
    {
        Gestor gestor;
        public Autenticacao(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Autenticacao_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_proximo_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;


            if (user == "admin" || password == "admin")
            {
                Pág_administracao pagadmin = new Pág_administracao(gestor);
                pagadmin.ShowDialog();
            }
            else
                MessageBox.Show("Dados incorretos");


        }
    }
}
