using AutoCenter.Data;
using AutoCenter.Model;
using AutoCenter.Repository;
using AutoCenter.Repository.Funcionarios_Empresa;

namespace projeto_poo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            }
            else if (CaixaRepository.LoginCaixa(login, senha))
            {
                MessageBox.Show("É CAIXA");
            }
            else if (GerenteRepository.LoginGerente(login, senha))
            {
                MessageBox.Show("É GERENTE");
            }
            //MessageBox.Show("é nada");
        }
    }
}