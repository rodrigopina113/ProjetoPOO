using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_POO
{
    public partial class Reg_passageiro : Form
    {

        private Gestor gestor;
        public Reg_passageiro(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void Reg_passageiro_Load(object sender, EventArgs e)
        {
            gestor.LerFicheiroPassageiros("Passageiros.txt");
        }

        private void Button_registar_Click(object sender, EventArgs e)
        {
            string nome = textBox_nome.Text;
            string morada = textBox_morada.Text;
            string dataNasc = dateTimePicker_nascimento.Value.ToString("dd/MM/yyyy");
            string nif = textBox_nif.Text;
            string resp = gestor.AdicionaPassageiro(nome, morada, DateTime.ParseExact(dataNasc, "dd/MM/yyyy", CultureInfo.InvariantCulture), Convert.ToInt32(nif));


            if (nome.Trim() != "" && morada.Trim() != "" && dataNasc.Trim() != "" && nif.Trim() != "")
            {
                MessageBox.Show(resp);
            }
            else
                MessageBox.Show("Falta preencher dados!");
        }

        private void Button_Sair_Click(object sender, EventArgs e)
        {
            gestor.gravarpassageirosficheiro("Passageiros.txt");
            Close();
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            textBox_morada.Clear();
            textBox_nif.Clear();
            textBox_nome.Clear();
            dateTimePicker_nascimento.ResetText();
        }

        private void dateTimePicker_nascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
