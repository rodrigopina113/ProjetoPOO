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
    public partial class Add_Voo_Rota_Admin : Form
    {
        private Gestor gestor;
        public Add_Voo_Rota_Admin(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            gestor.Gravarrotas("rotas.txt");
            gestor.GuardarFicheiroVoos("Voosrota.txt");
            Close();

        }

        private void Add_Voo_Rota_Admin_Load(object sender, EventArgs e)
        {
            comboBox_aviao.Items.Add("Bombardier Challenger 350; 10");
            comboBox_aviao.Items.Add("Embraer Phenom 300; 9");
            comboBox_aviao.Items.Add("Cessna Citation Latitude; 12");
            comboBox_aviao.Items.Add("Bombardier Global 6000; 17");

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

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_hora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_voo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            string id_voo = textBox_id.Text;
            string data = dateTimePicker_data.Value.ToString("dd/MM/yyyy");
            string hora = maskedTextBox_hora.Text;
            string aviao = comboBox_aviao.Text;

            // Divide o nome do avião e o número de lugares usando o ponto e vírgula
            string[] partesAviao = aviao.Split(';');

            if (partesAviao.Length == 2)
            {
                string nomeAviao = partesAviao[0].Trim();
                int n_lugares = Convert.ToInt32(partesAviao[1].Trim());

                // Verifica se um destino foi selecionado no ComboBox
                if (comboBox1.SelectedItem != null)
                {
                    string destinoSelecionado = comboBox1.SelectedItem.ToString();

                    // Chama o método AdicionarVoo do gestor
                    string resp = gestor.AdicionarVoo(Convert.ToInt32(id_voo), Convert.ToDateTime(data), hora, nomeAviao, n_lugares, destinoSelecionado);


                    // Exibe mensagem 
                    MessageBox.Show(resp);
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um destino.");
                }
            }
            else
            {
                MessageBox.Show("Insira um avião!");
            }
        }

        private void comboBox_aviao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
