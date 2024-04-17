using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_POO
{
    public partial class Comprar_bilhete : Form
    {
        Gestor gestor;
        public Comprar_bilhete(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void Comprar_bilhete_Load(object sender, EventArgs e)
        {
            // Limpa os itens existentes no ComboBox
            comboBox_rotas.Items.Clear();

            // Obtém os destinos disponíveis
            Dictionary<string, List<Voo>> voosPorDestino = gestor.ListarVoos();

            // Adiciona os destinos ao ComboBox
            foreach (var destino in voosPorDestino.Keys)
            {
                comboBox_rotas.Items.Add(destino);
            }

            gestor.LerBilheteSuplente("BilheteSuplente.txt");
            gestor.LerBilheteEfetivo("BilheteEfetivo.txt");
        }

        private void ExibirListaVoos(List<Voo> voos)
        {
            // Limpa o DataGridView antes de adicionar novos dados
            dataGridView1.Rows.Clear();

            // Obtém a distância para o destino selecionado
            double distancia = gestor.ObterDistanciaParaDestino(comboBox_rotas.SelectedItem.ToString());

            // Determina o tipo de bilhete com base em alguma condição
            Bilhete bilhete;

            // Exemplo: Se a distância for menor ou igual a 300 km, usa Bilhete_A, 
            // se for maior que 300 e menor ou igual a 1000 km, usa Bilhete_B, 
            // caso contrário, usa Bilhete_C
            if (distancia <= 300)
            {
                bilhete = new Bilhete_A(0, 0, 0);
            }
            else if (distancia > 300 && distancia <= 1000)
            {
                bilhete = new Bilhete_B(0, 0, 0);
            }
            else
            {
                bilhete = new Bilhete_C(0, 0, 0);
            }

            // Adiciona os voos ao DataGridView
            foreach (var voo in voos)
            {
                // Formata a data 
                string dataFormatada = voo.Getdata().ToString("dd/MM/yyyy");

                // Calcula o preço com base na distância
                double preco = gestor.CalcularPreco(comboBox_rotas.SelectedItem.ToString(), distancia, bilhete);

                // Formata o preço com duas casas decimais
                string precoFormatado = preco.ToString("F2"); // F2 indica duas casas decimais

                // Adiciona a linha formatada ao DataGridView
                dataGridView1.Rows.Add(voo.GetIDvoo(), dataFormatada, voo.Gethora(), voo.GetNlugares(), voo.GetSuplentes(), precoFormatado);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void comboBox_rotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se um destino foi selecionado no ComboBox
            if (comboBox_rotas.SelectedItem != null)
            {
                string destinoSelecionado = comboBox_rotas.SelectedItem.ToString();

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


        private void button_comprar_Click(object sender, EventArgs e)
        {
            // Verifica se um voo foi selecionado
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o ID do voo a partir da linha selecionada no DataGridView
                int idVooSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idrota"].Value);

                // Pergunta ao usuário pelo NIF para comprar o bilhete
                string nif = Microsoft.VisualBasic.Interaction.InputBox("Por favor, insira o seu NIF:", "Compra de Bilhete");

                // Verifica se o usuário forneceu um NIF
                if (!string.IsNullOrEmpty(nif))
                {
                    // Flag para indicar se o passageiro com o NIF foi encontrado
                    bool passageiroEncontrado = false;

                    // Percorre a lista de passageiros
                    foreach (Passageiro passageiro in gestor.getListaPassag())
                    {
                        if (passageiro.getNif() == Convert.ToInt32(nif))
                        {
                            // O passageiro com o NIF fornecido foi encontrado
                            passageiroEncontrado = true;

                            // Chama o método ComprarBilhete do Gestor
                            string resultadoCompra = gestor.ComprarBilhete(idVooSelecionado, nif);

                            // Exibe uma mensagem com o resultado da compra
                            MessageBox.Show(resultadoCompra);

                            // Atualiza a exibição da lista de voos
                            comboBox_rotas_SelectedIndexChanged(sender, e);

                            // Sai do loop, pois o passageiro já foi encontrado
                            break;
                        }
                    }

                    // Verifica se o passageiro não foi encontrado
                    if (!passageiroEncontrado)
                    {
                        MessageBox.Show("Passageiro com o NIF fornecido não encontrado. A compra foi cancelada.");
                    }
                }
                else
                {
                    MessageBox.Show("NIF inválido. A compra foi cancelada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um voo na lista antes de comprar.");
            }
        }


        private void button_Sair_Click(object sender, EventArgs e)
        {
            gestor.GuardarBilheteSuplente("BilheteSuplente.txt");
            gestor.GuardarBilheteEfetivo("BilheteEfetivo.txt");
            Close();
        }
    }
}
