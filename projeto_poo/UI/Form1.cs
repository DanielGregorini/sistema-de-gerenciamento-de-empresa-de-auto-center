using AutoCenter;
using AutoCenter.Data;
using AutoCenter.Model;
using AutoCenter.Repository;

namespace AutoCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Sistema de Gerenciamento de empresa Auto Center";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Carregar a imagem a partir de um arquivo no sistema
            string imagePath = "imaegens/logo.png";
            Image imagem = Image.FromFile(imagePath);

            // Atribuir a imagem ao controle PictureBox
            pictureBox1.Image = imagem;
        }

        private void button_logar_Click(object sender, EventArgs e)
        {
            string login = text_login.Text;
            string senha = text_senha.Text;

            if (VendedorRepository.LoginVendedor(login, senha))
            {
                MessageBox.Show("É VENDEDOR");
                var vendedor = VendedorRepository.RetornarVendedorPorLogin(login, senha);
                TelaVendedor telaVendedor = new TelaVendedor(vendedor);
                telaVendedor.Show();
                this.Hide();
            }
            else if (CaixaRepository.LoginCaixa(login, senha))
            {
                Caixa caixaLogado = CaixaRepository.RetornarCaixaPorLogin(login, senha);
                MessageBox.Show("É CAIXA");
                TelaCaixa telaCaixa = new TelaCaixa(caixaLogado);
                telaCaixa.Show();
                this.Hide();
            }
            else if (GerenteRepository.LoginGerente(login, senha))
            {
                MessageBox.Show("É GERENTE");
                var gerenteLogado = GerenteRepository.RetornarGerentePorLogin(login, senha);
                TelaGerente telaGerente = new TelaGerente(gerenteLogado);
                telaGerente.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido");
                text_login.Text = "";
                text_senha.Text= "";
            }
        }
    }
}