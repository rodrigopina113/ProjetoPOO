namespace Projeto_POO
{
    public partial class Form1 : Form
    {
        //variáveis
        private Gestor gestor;

        //construtor
        public Form1()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        private void Button_passageiro_Click(object sender, EventArgs e)
        {
            Pág_Passageiro pagpass = new(gestor);
            pagpass.ShowDialog();
        }

        private void Button_administracao_Click(object sender, EventArgs e)
        {
            Autenticacao login = new(gestor);
            login.ShowDialog();
        }

        private void Button_sair_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestor.LerFicheiroPassageiros("Passageiros.txt");
            gestor.lerrotas("rotas.txt");
            gestor.LerFicheiroVoos("Voosrota.txt");
        }
    }
}