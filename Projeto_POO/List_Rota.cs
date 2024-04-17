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
        public partial class List_Rota : Form
        {

            private Gestor gestor;
            public List_Rota(Gestor gestor)
            {
                InitializeComponent();
                this.gestor = gestor;
            }
            private void List_Rota_Voo_Load(object sender, EventArgs e)
            {
                // Limpa o ListBox antes de adicionar novos itens
                dataGridView1.Rows.Clear();

                List<Rota> listarota = gestor.listar_rota();
                foreach (Rota rota in listarota)
                    dataGridView1.Rows.Add(rota.Getid_rota(), rota.Getn_rota(), rota.GetDestino(), rota.Getdistancia());


                   gestor.lerrotas("rotas.txt");
            }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
            private void button_Sair_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
}
