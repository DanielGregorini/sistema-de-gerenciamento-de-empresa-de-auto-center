using AutoCenter;
using AutoCenter.Data;
using AutoCenter.Model;
using AutoCenter.Repository;
using AutoCenter.UI_Gerente;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class TelaGerente : Form
    {
        private Gerente gerente; // Declare a variável como campo de classe

        public TelaGerente(Gerente gerente)
        {
            InitializeComponent();
            this.Text = "Sistema de Gerenciamento de empresa Auto Center";
            this.gerente = gerente; // Atribua o valor recebido ao campo de classe
        }

        private void CriarFuncionarioButton_Click(object sender, EventArgs e)
        {
            // Supondo que você tenha uma instância de Gerente chamada "gerente" na sua classe TelaGerente
            CriarFuncionario telaCriarFuncionario = new CriarFuncionario(gerente);
            telaCriarFuncionario.Show();
        }

        private void TelaGerente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarNovoProdutoButton_Click(object sender, EventArgs e)
        {

        }

        private void ProdutosLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
