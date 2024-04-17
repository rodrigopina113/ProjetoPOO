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
    public partial class List_Pass_admin : Form
    {
        private Gestor gestor;
        public List_Pass_admin(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void List_Pass_admin_Load(object sender, EventArgs e)
        {
            gestor.LerFicheiroPassageiros("Passageiros.txt");
            gestor.LerFicheiroVoos("Voosrota.txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_passageiros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_efetivos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_suplentes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int idVoo))
            {
                bool efetivos = radioButton_efetivos.Checked;

                List<string> bilhetes = gestor.ListarBilhetesPorVoo(idVoo, efetivos);

                if (bilhetes.Count > 0)
                {
                    listBox_passageiros.Items.Clear();

                    foreach (string bilhete in bilhetes)
                    {
                        listBox_passageiros.Items.Add(bilhete);
                    }
                }
                else
                {
                    MessageBox.Show("Não foram encontrados bilhetes para o ID do voo especificado.");
                }
            }
            else
            {
                MessageBox.Show("ID do voo inválido. Por favor, insira um número inteiro para o ID do voo.");
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
