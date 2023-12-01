using AutoCenter.Model;
using AutoCenter.Repository;

namespace AutoCenter
{
    public partial class CriarFuncionario : Form
    {
        private Gerente gerenteLogado;

        public CriarFuncionario(Gerente gerente)
        {
            InitializeComponent();
            this.gerenteLogado = gerente;
            this.Text = "Criar novo funcionário";
        }

        private void ButtonCriar_Click(object sender, EventArgs e)
        { 
            string nome = NomeBox.Text;
            string cpf = SenhaBox.Text;
            string login = NomeBox.Text ;
            string senha = SenhaBox.Text;

            //validação se existe um campo nulo
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Dados faltando");
                return;
            }

            //senha muito curta
            if (senha.Length <= 4)
            {
                MessageBox.Show("Senha muito curta");
                SenhaBox.Text = "";
                return;
            }

            //validando se já existe este login
            if (VendedorRepository.LoginVendedor(login, senha) || CaixaRepository.LoginCaixa(login, senha) ||
                GerenteRepository.LoginGerente(login, senha))
            {
                MessageBox.Show("Já existe esse login");
                return;
            }

            if(ButtonCaixa.Checked)
            {
                Caixa caixaNovo = new Caixa
                {
                    EmpresaId = 1,
                    Nome = nome,
                    Cpf = cpf,
                    Login = login,
                    Senha = senha
                };

                CaixaRepository.AdicionarCaixa(caixaNovo, gerenteLogado.Login, gerenteLogado.Senha);
            }
            else if(ButtonVendedor.Checked)
            {
                Vendedor vendedorNovo = new Vendedor
                {
                    EmpresaId = 1,
                    Nome = nome,
                    Cpf = cpf,
                    Login = login,
                    Senha = senha
                };

                VendedorRepository.AdicionarVendedor(vendedorNovo, gerenteLogado.Login, gerenteLogado.Senha);
            }
            else if (ButtonGerente.Checked)
            {
                Gerente gerenteNovo = new Gerente
                {
                    EmpresaId = 1,
                    Nome = nome,
                    Cpf = cpf,
                    Login = login,
                    Senha = senha
                };

                GerenteRepository.AdicionarGerente(gerenteNovo, gerenteLogado.Login, gerenteLogado.Senha);
            }

            NomeBox.Text = "";
            CpfBox.Text = "";
            LoginBox.Text = "";
            SenhaBox.Text = "";
        }
    }
}
