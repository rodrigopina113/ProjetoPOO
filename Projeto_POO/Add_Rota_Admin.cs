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
    public partial class Add_Rota_Admin : Form
    {
        private Gestor gestor;
        public Add_Rota_Admin(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Rota_Admin_Load(object sender, EventArgs e)
        {
            gestor.lerrotas("rotas.txt");
        }

        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_destino_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Sair_Click(object sender, EventArgs e)
        {
            gestor.Gravarrotas("rotas.txt");
            Close();
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_voos.Clear();
            textBox_distancia.Clear();
            textBox_destino.Clear();
        }

        private void Button_adicionar_Click(object sender, EventArgs e)
        {
            string id_rota = textBox_id.Text;
            string n_voos = textBox_voos.Text;
            string destino = textBox_destino.Text;
            string distancia = textBox_distancia.Text;
            string resp = gestor.adicionarota(Convert.ToInt32(id_rota), Convert.ToInt32(n_voos), destino, Convert.ToDouble(distancia));

            if (id_rota.Trim() != "" && n_voos.Trim() != "" && destino.Trim() != "" && distancia.Trim() != "")
            {
                MessageBox.Show(resp);
            }
            else
                MessageBox.Show("Falta preencher dados!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
