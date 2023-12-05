using AutoCenter.Model;
using AutoCenter.Repository;
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

namespace AutoCenter
{
    public partial class EditarVenda : Form
    {
        Cliente? ClienteSelecionado { get; set; }
        Produto? ProdutoSelecionado { get; set; }
        Vendedor VendedorLogado { get; set; }
        List<ProdutoVenda>? ListaProdutoVenda { get; set; }
        Venda? VendaCriada { get; set; }

        public EditarVenda(Vendedor vendedor)
        {
            ListaProdutoVenda = new List<ProdutoVenda>();
            VendedorLogado = vendedor;

            InitializeComponent();
            ListarVendasEmAberto();
        }

        private void ListarVendasEmAberto()
        {
            ListaVendasEmAberto.Items.Clear();


            var listaDeVendasEmAberto = VendaRepository.ListarVendas().Where(v => v.Estado != "Pago").ToList();

            foreach (var venda in listaDeVendasEmAberto)
            {
                var cliente = ClienteRepository.ClientePorId(venda.ClienteId);

                string vendaEmAberto = "ID venda: " + venda.VendaId.ToString() + "- ID cliente: " + cliente.ClienteId + "-" + cliente.Nome;

                ListaVendasEmAberto.Items.Add(vendaEmAberto);
            }
        }

        private void ListaVendasEmAberto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaVendasEmAberto.SelectedItem != null)
            {
                ListaProdutoVenda = null;

                // Obter a string selecionada
                string dados = ListaVendasEmAberto.SelectedItem.ToString();

                // Separar a string pelo hífen
                string[] partes = dados.Split('-');

                // Verificar se há pelo menos duas partes (número e nome, descricao)
                if (partes.Length >= 2)
                {
                    //MessageBox.Show(partes[1]);
                    // Extrair o número (segunda parte após a divisão)
                    string numeroString = partes[1].Substring(13); // Ignora os primeiros 13 caracteres ("ID: cliente: ")

                    // Converter a string do número para um número (se necessário)
                    if (int.TryParse(numeroString, out int numeroExtraido))
                    {
                        int idCliente = numeroExtraido;
                        InserirDadosCliente(idCliente);

                        // MessageBox.Show("Número extraído cliente: " + idCliente);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível converter o número para um número inteiro.");
                    }

                    string numeroStringIdVenda = partes[0].Substring(10);

                    if (int.TryParse(numeroStringIdVenda, out int numeroExtraidoIdVenda))
                    {
                        int idVenda = numeroExtraidoIdVenda;
                        InserirProdutoVendaNaLista(idVenda);

                        //MessageBox.Show("Número extraído venda: " + idVenda);
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

        void InserirProdutoVendaNaLista(int idVenda)
        {
            var venda = VendaRepository.VendaPorId(idVenda);

            VendaCriada = venda;

            var produtosVenda = ProdutoVendaRepository.ListarProdutoVendasPorVenda(idVenda);
            ListaProdutoVenda = produtosVenda;

            AtualizarDataGridListaDeProduto();
        }

        private void AtualizarDataGridListaDeProduto()
        {
            double valorTotal = 0;

            // Limpar as linhas existentes antes de adicionar novas
            ProdutosNaVenda.Rows.Clear();

            if (ListaProdutoVenda == null)
            {
                MessageBox.Show("não tem produtos nessa venda");
                return;
            }

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
            PrecoTotalVendaLabel.Text = "Valor Total: " + valorTotal.ToString();
        }

        //dados do cliente 

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

        //Listar produtos

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

        //----------------------------------------------------------------------------------//

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
            PrecoLabel.Text = "Preço: " + produto.Preco.ToString("C2"); 
            QuantidadeDisponivelLabel.Text = "Quantidade disponível: " + produto.Quantidade.ToString("N3");
            CustoMedioLabel.Text = "Custo médio: " + produto.CustoMedio.ToString("N2"); 

        }
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

        private void ProdutosNaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProdutosNaVenda.Columns["RemoverProduto"].Index && e.RowIndex >= 0)
            {
                int produtoId = Convert.ToInt32(ProdutosNaVenda.Rows[e.RowIndex].Cells["IdProduto"].Value);

                ProdutoVenda produtoRemovido = ListaProdutoVenda.Find(produtoVenda => produtoVenda.ProdutoId == produtoId);

                ProdutoVendaRepository.ExcluirProdutoVenda(produtoRemovido);

                ListaProdutoVenda.RemoveAll(produtoVenda => produtoVenda.ProdutoId == produtoId);

                AtualizarDataGridListaDeProduto();
            }
        }

        //deixa apenas numero e . no textbox
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

        private void ConcluirVenda_Click(object sender, EventArgs e)
        {
            if (ClienteSelecionado == null || ProdutoSelecionado == null ||
                            ProdutoSelecionado == null || ListaProdutoVenda == null ||
                            VendaCriada == null)
            {
                MessageBox.Show("Está faltando dados");
                return;
            }

            foreach (var produtoVenda in ListaProdutoVenda)
            {
                var produtoVenda_ = ProdutoVendaRepository.ProdutoVendaPorId(produtoVenda.ProdutoVendaId);

                produtoVenda.VendaId = VendaCriada.VendaId;

                if (produtoVenda_ == null)
                {
                    ProdutoVendaRepository.AdicionarProdutoVenda(produtoVenda);
                }
                else
                {
                    ProdutoVendaRepository.AtualizarProdutoVenda(produtoVenda);
                }
            }

            VendaRepository.AtualizarVenda(VendaCriada.VendaId);

            LimparTodosDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(VendaCriada == null)
            {
                MessageBox.Show("Sem venda selecionada");
                return;
            }

            VendaRepository.ExcluirVenda(VendaCriada);

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
            QuantidadeVendidaBox.Text = "";
            PrecoTotalVendaLabel.Text = "Valor Total:";

            ListaProdutos.Items.Clear();
            ProdutosNaVenda.Rows.Clear();
            ListarVendasEmAberto();

            ListaVendasEmAberto.SelectedItem = null;
        }
    }
}