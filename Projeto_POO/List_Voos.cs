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
    public partial class List_Voos : Form
    {
        private Gestor gestor;

        public List_Voos(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            // Verifica se um destino foi selecionado no ComboBox
            if (comboBox1.SelectedItem != null)
            {
                string destinoSelecionado = comboBox1.SelectedItem.ToString();

                // Verifica se há voos para o destino selecionado
                if (gestor.ListarVoos().ContainsKey(destinoSelecionado))
                {
                    // Obtem a lista de voos para o destino selecionado
                    List<Voo> voosParaDestino = gestor.ListarVoos()[destinoSelecionado];

                    // Exibe a lista de voos no DataGridView
                    ExibirListaVoos(voosParaDestino);
                }
                else
                {
                    MessageBox.Show("Não há voos disponíveis para o destino selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um destino no ComboBox.");
            }
        }

        private void ExibirListaVoos(List<Voo> voos)
        {
            // Limpa o DataGridView antes de adicionar novos dados
            dataGridView1.Rows.Clear();

            // Adiciona os voos ao DataGridView
            foreach (var voo in voos)
            {
                // Formata a data 
                string dataFormatada = voo.Getdata().ToString("dd/MM/yyyy");


                // Adiciona a linha formatada ao DataGridView
                dataGridView1.Rows.Add(voo.GetIDvoo(), dataFormatada, voo.Gethora(), voo.Getaviao(), voo.GetNlugares(), voo.GetSuplentes());
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_Voos_Load(object sender, EventArgs e)
        {
            // Limpa os itens existentes no ComboBox
            comboBox1.Items.Clear();

            // Obtém os destinos disponíveis
            Dictionary<string, List<Voo>> voosPorDestino = gestor.ListarVoos();

            // Adiciona os destinos ao ComboBox
            foreach (var destino in voosPorDestino.Keys)
            {
                comboBox1.Items.Add(destino);
            }
            gestor.lerrotas("rotas.txt");
            gestor.LerFicheiroVoos("Voosrota.txt");
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
