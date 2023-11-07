using AutoCenter.Data;
using AutoCenter.Model;

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
            Empresa empresa = new Empresa();

            empresa.Nome = "Video Som AutoCenter";
            empresa.RazaoSocial = "Auto Center";
            empresa.CNPJ = "4444-44444-4444/1000";
            empresa.Endereco = "Rua Paraguai, 1039";
            empresa.Telefone = "3264-1000";

            using (var context = new AutoCenterContext())
            {
                context.Empresas.Remove(empresa);
                context.SaveChanges();
            }
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
    }
}