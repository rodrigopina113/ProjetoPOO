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
    public partial class Cancelar_bilhete : Form
    {
        private Gestor gestor;
        public Cancelar_bilhete(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void Cancelar_bilhete_Load(object sender, EventArgs e)
        {
            gestor.LerBilheteEfetivo("BilheteEfetivo.txt");
            gestor.LerBilheteSuplente("BilheteSuplente.txt");
        }


        private void CarregarBilhetes(bool efetivos)
        {
            comboBox1.Items.Clear();

            // Obter o NIF
            string nif = textBox_nif.Text;

            if (!string.IsNullOrEmpty(nif))
            {
                // Lista os bilhetes do passageiro
                List<string> bilhetes;
                if (efetivos)
                {
                    bilhetes = gestor.ListarBilhetesPorPassageiro(nif, true);
                }
                else
                {
                    bilhetes = gestor.ListarBilhetesPorPassageiro(nif, false);
                }

                // Adiciona os bilhetes ao ComboBox
                comboBox1.Items.AddRange(bilhetes.ToArray());
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox_nif_TextChanged_1(object sender, EventArgs e)
        {
            CarregarBilhetes(radioButton_efetivo.Checked);
        }

        private void radioButton_efetivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton_efetivo.Checked)
            {
                // Carregar bilhetes efetivos no combobox
                CarregarBilhetes(true);
            }
        }

        private void button_cancelar_Click_1(object sender, EventArgs e)
        {
            string nif = textBox_nif.Text;
            bool efetivos = radioButton_efetivo.Checked;
            string bilheteSelecionado = comboBox1.SelectedItem as string;

            if (string.IsNullOrEmpty(nif) || string.IsNullOrEmpty(bilheteSelecionado))
            {
                MessageBox.Show("Por favor, preencha o NIF e selecione um bilhete.");
                return;
            }

            string resultado = gestor.CancelarBilhetes(nif, efetivos, bilheteSelecionado);

            MessageBox.Show(resultado);
            // Atualizar ComboBox após o cancelamento do bilhete
            CarregarBilhetes(efetivos);
        }

        private void radioButton_suplente_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton_suplente.Checked)
            {
                // Carregar bilhetes suplentes no combobox
                CarregarBilhetes(false);
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            gestor.GuardarBilheteEfetivo("BilheteEfetivo.txt");
            gestor.GuardarBilheteSuplente("BilheteSuplente.txt");
            Close();
        }
    }
}
