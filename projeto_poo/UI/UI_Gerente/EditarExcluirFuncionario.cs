using AutoCenter.Model;
using AutoCenter.Repository;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoCenter
{
    public partial class EditarExcluirFuncionario : Form
    {
        private string tipoFuncionario { get; set; }
        private int idFuncionario { get; set; }
        private Gerente GerenteLogado { get; set; }

        public EditarExcluirFuncionario(Gerente gerente)
        {
            InitializeComponent();
            this.GerenteLogado = gerente;
            NomeGerenteLabel.Text = gerente.Nome;
        }


        private void EditarExcluirFuncionario_Activated(object sender, EventArgs e)
        {

        }

        private void VendedorButton_CheckedChanged(object sender, EventArgs e)
        {
            if (VendedorButton.Checked)
            {
                LimparDadosEdicao();
                // Código a ser executado quando o RadioButton GerenteButton é marcado
                tipoFuncionario = "vendedor";

                var vendedores = VendedorRepository.ListarVendedores();

                List<int> idVendedores = new List<int>();

                foreach (var vendedor in vendedores)
                {
                    idVendedores.Add(vendedor.VendedorId);
                }

                AtualizarListBox(idVendedores);
            }
        }

        private void CaixaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CaixaButton.Checked)
            {
                LimparDadosEdicao();
                // Código a ser executado quando o RadioButton GerenteButton é marcado
                tipoFuncionario = "caixa";

                var caixas = CaixaRepository.ListarCaixas();

                List<int> idCaixas = new List<int>();

                foreach (var caixa in caixas)
                {
                    idCaixas.Add(caixa.CaixaId);
                }

                AtualizarListBox(idCaixas);
            }
        }

        private void GerenteButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GerenteButton.Checked)
            {
                LimparDadosEdicao();
                // Código a ser executado quando o RadioButton GerenteButton é marcado
                tipoFuncionario = "gerente";

                var gerentes = GerenteRepository.ListarGerentes();

                List<int> idGerente = new List<int>();

                foreach (var gerente in gerentes)
                {
                    idGerente.Add(gerente.GerenteId);
                }

                AtualizarListBox(idGerente);
            }
        }

        private void AtualizarListBox(List<int> listaIdFuncionario)
        {
            // Atualiza a ListBox com os nomes dos funcionários
            ListaFuncionarios.Items.Clear();
            foreach (var funcionarioId in listaIdFuncionario)
            {
                ListaFuncionarios.Items.Add(funcionarioId);
            }
        }

        private void ListaFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manipulador de eventos chamado quando o índice selecionado na lista é alterado

            if (ListaFuncionarios.SelectedItem != null)
            {
                // Obtém o valor selecionado (convertendo para int, se possível)
                if (int.TryParse(ListaFuncionarios.SelectedItem.ToString(), out int IdFuncionarioSelecionado))
                {
                    this.idFuncionario = IdFuncionarioSelecionado;
                    CarregarDadosFuncionario(IdFuncionarioSelecionado);
                }
                else
                {
                    // Não foi possível converter para int
                    // Lide com a situação de falha conforme necessário
                    MessageBox.Show("Não foi possível consultar esse funcionario");
                }
            }
        }
        private void CarregarDadosFuncionario(int IdFuncionario)
        {
            if (tipoFuncionario == "vendedor")
            {
                Vendedor vendedor = VendedorRepository.VendedorPorId(IdFuncionario);

                NomeBox.Text = vendedor.Nome;
                CpfBox.Text = vendedor.Cpf;
                LoginBox.Text = vendedor.Login;
                SenhaBox.Text = vendedor.Senha;
            }
            else if (tipoFuncionario == "caixa")
            {
                Caixa caixa = CaixaRepository.CaixaPorId(IdFuncionario);

                NomeBox.Text = caixa.Nome;
                CpfBox.Text = caixa.Cpf;
                LoginBox.Text = caixa.Login;
                SenhaBox.Text = caixa.Senha;

            }
            else if (tipoFuncionario == "gerente")
            {
                Gerente gerente = GerenteRepository.GerentePorId(IdFuncionario);

                NomeBox.Text = gerente.Nome;
                CpfBox.Text = gerente.Cpf;
                LoginBox.Text = gerente.Login;
                SenhaBox.Text = gerente.Senha;
            }
        }

        private void ConfirmarEdicao_Click(object sender, EventArgs e)
        {
            string nome = NomeBox.Text;
            string cpf = CpfBox.Text;
            string login = LoginBox.Text;
            string senha = SenhaBox.Text;

            if (GerenteRepository.LoginGerente(this.GerenteLogado.Login, this.GerenteLogado.Senha))
            {
                if (tipoFuncionario == "vendedor")
                {
                    VendedorRepository.EditarVendedor(this.idFuncionario, nome, cpf, login, senha);

                    LimparDadosEdicao();
                    MessageBox.Show("Dados do Vendedor alterados");
                }
                else if (tipoFuncionario == "caixa")
                {
                    CaixaRepository.EditarCaixa(this.idFuncionario, nome, cpf, login, senha);

                    LimparDadosEdicao();
                    MessageBox.Show("Dados do Caixa alterados");

                }
                else if (tipoFuncionario == "gerente")
                {
                    GerenteRepository.EditarGerente(this.idFuncionario, nome, cpf, login, senha);

                    LimparDadosEdicao();
                    MessageBox.Show("Dados do Gerente alterados");
                }
            }
        }         

        private void LimparDadosEdicao()
        {
            ListaFuncionarios.SelectedItem = null;
            NomeBox.Text = "";
            CpfBox.Text = "";
            LoginBox.Text = "";
            SenhaBox.Text = "";
        }
    }
}
