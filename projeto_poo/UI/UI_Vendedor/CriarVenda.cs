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
using AutoCenter.Model;
using AutoCenter.Repository;

namespace AutoCenter
{
    public partial class CriarVenda : Form
    {
        Cliente? ClienteSelecionado { get; set; }
        Produto? ProdutoSelecionado { get; set; }
        Vendedor VendedorLogado { get; set; }
        List<ProdutoVenda>? ListaProdutoVenda { get; set; }
        Venda? VendaCriada { get; set; }

        public CriarVenda(Vendedor vendedor)
        {
            ListaProdutoVenda = new List<ProdutoVenda>();
            VendedorLogado = vendedor;
            InitializeComponent();

            ProdutosNaVenda.CellContentClick += ProdutosNaVenda_CellContentClick;
        }

        //pesquisar cliente funções 
        private void PesquisarCliente_Click(object sender, EventArgs e)
        {
            this.ClienteSelecionado = null;

            string filtroCliente = ClienteBox.Text;

            if (string.IsNullOrEmpty(filtroCliente))
            {
                MessageBox.Show("Não pesquisou nem um cliente");
                return;
            }

            ListarClientes(filtroCliente);
        }

        private void ListarClientes(string filtro)
        {
            var clientes = ClienteRepository.ListarClientes();
            List<Cliente> clientesFitrados = new List<Cliente>();

            foreach (Cliente cliente in clientes)
            {
                if (ContemFiltroCliente(cliente, filtro))
                {

                    clientesFitrados.Add(cliente);
                }
            }

            CarregarClienteLista(clientesFitrados);
        }

        private bool ContemFiltroCliente(Cliente cliente, string filtro)
        {
            if (cliente.ClienteId.ToString().ToLower().Contains(filtro.ToLower()) ||
                    cliente.Nome.ToLower().Contains(filtro.ToLower()) ||
                    cliente.Rg.ToLower().Contains(filtro.ToLower()) ||
                    cliente.Cpf_Cnpj.ToLower().Contains(filtro.ToLower()) ||
                    cliente.Telefone.ToLower().Contains(filtro.ToLower()) ||
                    cliente.Endereco.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }
            return false;
        }

        private void CarregarClienteLista(List<Cliente> clientes)
        {
            //limpar lista
            ListaClientes.Items.Clear();

            foreach (var cliente in clientes)
            {
                ListaClientes.Items.Add($"ID:{cliente.ClienteId}- {cliente.Nome}");
            }
        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaClientes.SelectedItem != null)
            {
                // Obter a string selecionada
                string dados = ListaClientes.SelectedItem.ToString();

                // Separar a string pelo hífen
                string[] partes = dados.Split('-');

                // Verificar se há pelo menos duas partes (número e nome)
                if (partes.Length >= 2)
                {
                    // Extrair o número (primeira parte após a divisão)
                    string numeroString = partes[0].Substring(3); // Ignora os primeiros 3 caracteres ("ID:")

                    // Converter a string do número para um número (se necessário)
                    if (int.TryParse(numeroString, out int numeroExtraido))
                    {
                        int idCliente = numeroExtraido;
                        InserirDadosCliente(numeroExtraido);

                        //MessageBox.Show("Número extraído: " + numeroExtraido);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível converter o número para um número inteiro.");

                    }
                }
                else
                {
                    MessageBox.Show("String no formato esperado não encontrada.");
                }
            }
        }

        void InserirDadosCliente(int idCliente)
        {
            Cliente cliente = ClienteRepository.ClientePorId(idCliente);

            if (cliente == null)
            {
                MessageBox.Show("Erro na consulta cliente");
                return;
            }

            this.ClienteSelecionado = cliente;

            NomeClienteLabel.Text = "Nome:" + cliente.Nome;
            RgClienteLabel.Text = "RG: " + cliente.Rg;
            CpfCnpjClienteLabel.Text = "CPF/CNPJ: " + cliente.Cpf_Cnpj;
            EnderecoClienteLabel.Text = "Endereço: " + cliente.Endereco;
            TelefoneClienteLabel.Text = "Telefone: " + cliente.Telefone;
        }
        //////////////

        //////////////

        private void BuscarProdutoButton_Click(object sender, EventArgs e)
        {
            this.ProdutoSelecionado = null;

            string filtroProduto = BuscarProdutoBox.Text;

            if (string.IsNullOrEmpty(filtroProduto))
            {
                MessageBox.Show("Não pesquisou nem um produto");
                return;
            }

            ListarProdutos(filtroProduto);
        }

        private void ListarProdutos(string filtro)
        {
            var listaProduto = ProdutoRepository.ListarProdutos();

            List<Produto> produtosFiltrados = new List<Produto>();

            foreach (Produto produto in listaProduto)
            {
                if (ContemFiltroProduto(produto, filtro))
                {
                    produtosFiltrados.Add(produto);
                }
            }

            CarregarListaProdutos(produtosFiltrados);
        }

        private bool ContemFiltroProduto(Produto produto, string filtro)
        {
            if (produto.ProdutoId.ToString().ToLower().Contains(filtro.ToLower()) ||
                    produto.Nome.ToLower().Contains(filtro.ToLower()) ||
                    produto.Descricao.ToLower().Contains(filtro.ToLower()))
            {
                return true;

            }

            return false;
        }

        private void CarregarListaProdutos(List<Produto> produtos)
        {
            //limpar lista
            ListaProdutos.Items.Clear();

            foreach (var produto in produtos)
            {
                ListaProdutos.Items.Add($"ID:{produto.ProdutoId}- {produto.Nome} - {produto.Descricao}");
            }
        }

        private void ListaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaProdutos.SelectedItem != null)
            {
                // Obter a string selecionada
                string dados = ListaProdutos.SelectedItem.ToString();

                // Separar a string pelo hífen
                string[] partes = dados.Split('-');

                // Verificar se há pelo menos duas partes (número e nome, descricao)
                if (partes.Length >= 2)
                {
                    // Extrair o número (primeira parte após a divisão)
                    string numeroString = partes[0].Substring(3); // Ignora os primeiros 3 caracteres ("ID:")

                    // Converter a string do número para um número (se necessário)
                    if (int.TryParse(numeroString, out int numeroExtraido))
                    {
                        int IdProduto = numeroExtraido;
                        InserirDadosProduto(IdProduto);

                        //MessageBox.Show("Número extraído: " + IdProduto);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível converter o número para um número inteiro.");

                    }
                }
                else
                {
                    MessageBox.Show("String no formato esperado não encontrada.");
                }
            }
        }

        private void InserirDadosProduto(int idProduto)
        {
            var produto = ProdutoRepository.ProdutoPorId(idProduto);

            ProdutoSelecionado = produto;

            NomeProdutoLabel.Text = "Nome: " + produto.Nome;
            Descricao.Text = "Descrição: " + produto.Descricao;
            PrecoLabel.Text = "Preço: " + produto.Preco.ToString();
            QuantidadeDisponivelLabel.Text = "Quantidade disponível: " + produto.Quantidade.ToString();
            CustoMedioLabel.Text = "Custo médio: " + produto.CustoMedio.ToString();
        }

        /////////
        //-Inserar e criação do venda produto--//
        /////////

        private void AdicionarProdutoBox_Click(object sender, EventArgs e)
        {
            if (ProdutoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            if (ClienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente antes de vender");
                return;
            }

            if (decimal.TryParse(QuantidadeVendidaBox.Text, NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out decimal quantidadeVendida) &&
                quantidadeVendida >= 0)
            {
                // O custo foi convertido com sucesso
                if ((double)quantidadeVendida == 0)
                {
                    MessageBox.Show("Não pode adicionar 0 produto");
                    return;
                }

                if ((double)quantidadeVendida > ProdutoSelecionado.Quantidade)
                {
                    MessageBox.Show("Não pode vender mais que tem em estoque");
                    return;
                }
            }
            else
            {
                MessageBox.Show("A quantidade não está formatado de uma forma correta");
                return;
            }

            var ListaProdutoVenda_ = ListaProdutoVenda;

            foreach (var produtoVenda in ListaProdutoVenda_)
            {
                if (ProdutoSelecionado.ProdutoId == produtoVenda.ProdutoId)
                {
                    if ((produtoVenda.Quantidade + (double)quantidadeVendida) > ProdutoSelecionado.Quantidade)
                    {
                        MessageBox.Show("Não pode adiconar mais produtos que tem no estoque");
                        return;
                    }

                    produtoVenda.Quantidade += (double)quantidadeVendida;
                    AtualizarDataGridListaDeProduto();
                    return;
                }
            }

            if (VendaCriada == null)
            {
                Venda novaVenda = new Venda
                {
                    ClienteId = ClienteSelecionado.ClienteId,
                    VendedorId = VendedorLogado.VendedorId,
                };

                VendaCriada = novaVenda;
            }
            AdicionarProdutoBox.Text = "Adicionar";
            CriarNovaProdutoVenda((double)quantidadeVendida);
        }

        private void CriarNovaProdutoVenda(double quantidadeVendida)
        {
            Produto produto = ProdutoSelecionado;
            Vendedor vendedor = VendedorLogado;

            ProdutoVenda produtoVenda = new ProdutoVenda
            {
                ProdutoId = produto.ProdutoId,
                Quantidade = quantidadeVendida
            };

            ListaProdutoVenda.Add(produtoVenda);

            AtualizarDataGridListaDeProduto();
        }

        private void AtualizarDataGridListaDeProduto()
        {
            double valorTotal = 0;

            // Limpar as linhas existentes antes de adicionar novas
            ProdutosNaVenda.Rows.Clear();

            foreach (var produtoVenda in ListaProdutoVenda)
            {
                var produto = ProdutoRepository.ProdutoPorId(produtoVenda.ProdutoId);

                valorTotal += produto.Preco * produtoVenda.Quantidade;

                DataGridViewRow novaLinha = new DataGridViewRow(); // Criar uma nova instância aqui

                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produtoVenda.ProdutoId });
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Nome });
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produtoVenda.Quantidade });
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Preco });
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Preco * produtoVenda.Quantidade });

                DataGridViewButtonCell botaoCelula = new DataGridViewButtonCell { Value = "Remover Produto" };
                novaLinha.Cells.Add(botaoCelula);

                ProdutosNaVenda.Rows.Add(novaLinha);
            }
            PrecoTotalVendaLabel.Text = "Valor Total: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void ProdutosNaVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProdutosNaVenda.Columns["RemoverProduto"].Index && e.RowIndex >= 0)
            {
                int produtoId = Convert.ToInt32(ProdutosNaVenda.Rows[e.RowIndex].Cells["IdProduto"].Value);

                ListaProdutoVenda.RemoveAll(produtoVenda => produtoVenda.ProdutoId == produtoId);

                AtualizarDataGridListaDeProduto();
            }
        }

        private void ConcluirVenda_Click(object sender, EventArgs e)
        {
            if (ClienteSelecionado == null || ProdutoSelecionado == null ||
                ProdutoSelecionado == null || ListaProdutoVenda == null ||
                VendaCriada == null)
            {
                MessageBox.Show("Está faltando dados");
                return;
            }

            VendaRepository.AdicionarVenda(VendaCriada);

            foreach (var produtoVenda in ListaProdutoVenda)
            {
                produtoVenda.VendaId = VendaCriada.VendaId;
                ProdutoVendaRepository.AdicionarProdutoVenda(produtoVenda);
            }

            LimparTodosDados();
        }

        //limpar os dados da venda, produto e cliente depois da criação da nova venda;
        private void LimparTodosDados()
        {
            ClienteSelecionado = null;
            ProdutoSelecionado = null;
            ProdutoSelecionado = null;
            ListaProdutoVenda = null;
            VendaCriada = null;

            NomeProdutoLabel.Text = "Nome";
            Descricao.Text = "Descrição";
            PrecoLabel.Text = "Preço";
            QuantidadeDisponivelLabel.Text = "Quantidade disponível";
            CustoMedioLabel.Text = "Custo médio";

            NomeClienteLabel.Text = "Nome";
            RgClienteLabel.Text = "RG";
            CpfCnpjClienteLabel.Text = "CPF/CNPJ";
            EnderecoClienteLabel.Text = "Endereço";
            TelefoneClienteLabel.Text = "Telefone";

            BuscarProdutoBox.Text = "";
            ClienteBox.Text = "";
            QuantidadeVendidaBox.Text = "";
            PrecoTotalVendaLabel.Text = "Valor Total:";

            ListaClientes.Items.Clear();
            ListaProdutos.Items.Clear();

            ProdutosNaVenda.Rows.Clear();
        }

        //Apenas deixa inserir números e . na caixa de quantidade do produto
        private void QuantidadeVendidaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, o ponto decimal e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
