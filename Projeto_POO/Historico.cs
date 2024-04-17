using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_POO
{
    public partial class Historico : Form
    {
        private Gestor gestor;
        public Historico(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nif_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_bilhetes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            string nif = textBox_nif.Text;

            if (!string.IsNullOrEmpty(nif))
            {
                bool efetivos = radioButton_efetivo.Checked;

                // Lista os bilhetes do passageiro
                List<string> bilhetes = gestor.ListarBilhetesPorPassageiro(nif, efetivos);

                Console.WriteLine($"Número de bilhetes encontrados: {bilhetes.Count}");

                if (bilhetes.Count > 0)
                {
                    // Exibe os bilhetes na ListBox
                    listBox_bilhetes.Items.Clear();

                    foreach (string bilhete in bilhetes)
                    {
                        // Obtém o ID do voo a partir do bilhete
                        int idVoo = int.Parse(bilhete.Split('-')[0]);

                        // Obtém a data do voo usando o ID do voo
                        DateTime dataVoo = gestor.ObterDataPorID(idVoo);

                        // Verifica se a data do voo é passada
                        if (dataVoo < DateTime.Now)
                        {
                            // Obtém o destino do voo usando o ID do voo
                            string destino = gestor.ObterDestinoPorID(idVoo);

                            // Adiciona o destino à ListBox junto com o bilhete
                            listBox_bilhetes.Items.Add($"Destino: {destino}, Bilhete: {bilhete}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não foram encontrados bilhetes para o NIF especificado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um NIF para listar os bilhetes.");
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            gestor.GuardarBilheteEfetivo("BilheteEfetivo.txt");
            gestor.GuardarBilheteSuplente("BilheteSuplente.txt");
            Close();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            gestor.LerBilheteEfetivo("BilheteEfetivo.txt");
            gestor.LerBilheteSuplente("BilheteSuplente.txt");
        }

        private void radioButton_suplente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_efetivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
