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
    public partial class EditarOrdemDeServico : Form
    {
        Cliente? ClienteSelecionado { get; set; }
        Veiculo? VeiculoSelecionado { get; set; }
        Produto? ProdutoSelecionado { get; set; }
        Vendedor VendedorLogado { get; set; }
        List<ProdutoOrdemDeServico>? ListaProdutoOrdemDeServico { get; set; }
        OrdemDeServico? OrdemDeServicoCriada { get; set; }

        public EditarOrdemDeServico(Vendedor vendedor)
        {
            InitializeComponent();
            VendedorLogado = vendedor;
            ListarODSEmAberto();
        }

        private void ListarODSEmAberto()
        {
            ListaODSEmAberto.Items.Clear();

            var listaDeOrdensDeServico = OrdemDeServicoRepository.ListarOrdemDeServico().Where(v => v.Estado != "Pago").ToList();

            foreach (var ordemDeServico in listaDeOrdensDeServico)
            {
                var cliente = ClienteRepository.ClientePorId(ordemDeServico.ClienteId);

                string OrdemDeServicoEmAberto = "ID ODS: " + ordemDeServico.OrdemDeServicoId.ToString() + "- ID cliente: " + cliente.ClienteId + "-" + cliente.Nome;

                ListaODSEmAberto.Items.Add(OrdemDeServicoEmAberto);
            }
        }
        private void ListaODSEmAberto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListaODSEmAberto.SelectedItem != null)
            {
                ListaProdutoOrdemDeServico = null;

                // Obter a string selecionada
                string dados = ListaODSEmAberto.SelectedItem.ToString();

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

                    string numeroStringIdOrdemDeServico = partes[0].Substring(8);

                    if (int.TryParse(numeroStringIdOrdemDeServico, out int numeroExtraidodOrdemDeServico))
                    {
                        int idOrdemDeServico = numeroExtraidodOrdemDeServico;
                        InserirProdutoOrdemDeServicoNaLista(idOrdemDeServico);
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

            ListarVeiculosDoCliente();
        }

        private void ListarVeiculosDoCliente()
        {
            if (ClienteSelecionado == null)
            {
                MessageBox.Show("Sem cliente para listar veículos");
                return;
            }
            // ListaDeVeiculos

            var listaVeiculos = VeiculoRepository.ListarVeiculosDeCliente(ClienteSelecionado.ClienteId);

            foreach (var veiculo in listaVeiculos)
            {
                ListaDeVeiculos.Items.Add($"ID:{veiculo.VeiculoId}-{veiculo.Modelo}-{veiculo.Placa}");
            }
        }

        private void ListaDeVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaDeVeiculos.SelectedItem != null)
            {
                string dados = ListaDeVeiculos.SelectedItem.ToString();

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
                        int idVeiculo = numeroExtraido;
                        //MessageBox.Show("Id veículo extraído: " + idVeiculo);

                        InserirDadosVeiculo(idVeiculo);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível converter o número para um número inteiro.");
                    }
                }
                else
                {
                    MessageBox.Show("String não formato esperado não encontrada.");
                }
            }
        }

        private void InserirDadosVeiculo(int idVeiculo)
        {
            Veiculo veiculo = VeiculoRepository.VeiculoPorId(idVeiculo);

            VeiculoSelecionado = veiculo;

            TipoVeiculoLabel.Text = "Tipo: " + veiculo.Tipo;
            ModeloVeiculoLabel.Text = "Modelo: " + veiculo.Modelo;
            PlacaVeiculoLabel.Text = "Placa: " + veiculo.Placa;
        }

        void InserirProdutoOrdemDeServicoNaLista(int idOrdemDeServico)
        {
            var ordemDeServico = OrdemDeServicoRepository.OrdemDeServicoPorId(idOrdemDeServico);

            TipoDeServicoBox.Text = ordemDeServico.TipoDeServico;
            DescricaoServicoBox.Text = ordemDeServico.Descricao;

            InserirDadosVeiculo(ordemDeServico.VeiculoId.Value);

            DataDeEntregaServicoBox.Value = ordemDeServico.HorarioDeEntrega;
            VeiculoSelecionado = VeiculoRepository.VeiculoPorId(ordemDeServico.VeiculoId.Value);
            OrdemDeServicoCriada = ordemDeServico;

            var produtoOrdensDeServico = ProdutoOrdemDeServicoRepository.ListarProdutoOrdensDeServicoPorOrdemDeServico(idOrdemDeServico);
            ListaProdutoOrdemDeServico = produtoOrdensDeServico;

            AtualizarDataGridListaDeProduto();
        }

        private void AtualizarDataGridListaDeProduto()
        {
            double valorTotal = 0;

            // Limpar as linhas existentes antes de adicionar novas
            ProdutosNaOrdemDeServico.Rows.Clear();

            if (ListaProdutoOrdemDeServico == null)
            {
                MessageBox.Show("não tem produtos nessa ordem de servico");
                return;
            }

            foreach (var produtoVenda in ListaProdutoOrdemDeServico)
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

                ProdutosNaOrdemDeServico.Rows.Add(novaLinha);
            }
            
            PrecoTotalVendaLabel.Text = "Valor Total: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture);

        }

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
                MessageBox.Show("Selecione um cliente antes de fazer ordem de serviço");
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
                    AdicionarProdutoBox.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("A quantidade não está formatado de uma forma correta");
                return;
            }

            var listaProdutoOrdemDeServico_ = ListaProdutoOrdemDeServico;

            foreach (var produtoOrdemDeServico in listaProdutoOrdemDeServico_)
            {
                if (ProdutoSelecionado.ProdutoId == produtoOrdemDeServico.ProdutoId)
                {
                    if ((produtoOrdemDeServico.Quantidade + (double)quantidadeVendida) > ProdutoSelecionado.Quantidade)
                    {
                        MessageBox.Show("Não pode adiconar mais produtos que tem no estoque");
                        return;
                    }
                   
                    produtoOrdemDeServico.Quantidade += (double)quantidadeVendida;
                    AtualizarDataGridListaDeProduto();
                    return;
                }
            }

            if (OrdemDeServicoCriada == null)
            {
                OrdemDeServico novaVenda = new OrdemDeServico
                {
                    ClienteId = ClienteSelecionado.ClienteId,
                    VendedorId = VendedorLogado.VendedorId,
                };

                OrdemDeServicoCriada = novaVenda;
            }

            AdicionarProdutoBox.Text = "";
            CriarNovaProdutoOrdemDeServico((double)quantidadeVendida);
        }

        private void CriarNovaProdutoOrdemDeServico(double quantidadeVendida)
        {
            Produto produto = ProdutoSelecionado;
            Vendedor vendedor = VendedorLogado;

            ProdutoOrdemDeServico produtoOrdemDeServico = new ProdutoOrdemDeServico
            {
                ProdutoId = produto.ProdutoId,
                Quantidade = quantidadeVendida
            };

            ListaProdutoOrdemDeServico.Add(produtoOrdemDeServico);

            AtualizarDataGridListaDeProduto();
        }

        private void CriarVeiculoButton_Click(object sender, EventArgs e)
        {
            if (ClienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            string tipo = TipoVeiculoBox.Text;
            string modelo = ModeloVeiculoBox.Text;
            string placa = PlacaVeiculoBox.Text;

            Veiculo veiculo = new Veiculo
            {
                Tipo = tipo,
                Modelo = modelo,
                Placa = placa,
                ClienteId = ClienteSelecionado.ClienteId
            };

            VeiculoRepository.AdicionarVeiculo(veiculo);

            ListarVeiculosDoCliente();
            LimparDadosCarro();
        }

        private void LimparDadosCarro()
        {
            TipoVeiculoBox.Text = "";
            ModeloVeiculoBox.Text = "";
            PlacaVeiculoBox.Text = "";
        }

        private void ProdutosNaOrdemDeServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProdutosNaOrdemDeServico.Columns["RemoverProduto"].Index && e.RowIndex >= 0)
            {
                int produtoId = Convert.ToInt32(ProdutosNaOrdemDeServico.Rows[e.RowIndex].Cells["IdProduto"].Value);

                ProdutoOrdemDeServico produtoRemovido = ListaProdutoOrdemDeServico.Find(produtoVenda => produtoVenda.ProdutoId == produtoId);

                ProdutoOrdemDeServicoRepository.ExcluirProdutoOrdemDeServico(produtoRemovido);

                ListaProdutoOrdemDeServico.RemoveAll(produtoVenda => produtoVenda.ProdutoId == produtoId);

                AtualizarDataGridListaDeProduto();
            }
        }

        private void ConcluirODS_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = DataDeEntregaServicoBox.Value;

            if (dataSelecionada < DateTime.Now)
            {
                MessageBox.Show("A data de entrega deve ser igual ou posterior à data atual.");
                return;
            }

            if (dataSelecionada == null)
            {
                MessageBox.Show("Nem data de entrega selecionada");
                return;
            }

            if (string.IsNullOrEmpty(TipoDeServicoBox.Text))
            {
                MessageBox.Show("O tipo de serviço está vazia");
            }

            if (string.IsNullOrEmpty(DescricaoServicoBox.Text))
            {
                MessageBox.Show("A descrição do serviço está vazia");
            }

            if (ClienteSelecionado == null ||
                ListaProdutoOrdemDeServico == null ||
                OrdemDeServicoCriada == null)
            {
                MessageBox.Show("Está faltando dados");
                return;
            }
            OrdemDeServicoCriada.VeiculoId = VeiculoSelecionado.VeiculoId;
            OrdemDeServicoCriada.HorarioDeEntrega = dataSelecionada;

            OrdemDeServicoCriada.TipoDeServico = TipoDeServicoBox.Text;
            OrdemDeServicoCriada.Descricao = DescricaoServicoBox.Text;

            //OrdemDeServicoRepository.AtualizarOrdemDeServico(OrdemDeServicoCriada.OrdemDeServicoId);

            foreach (var produtoOrdemDeServico in ListaProdutoOrdemDeServico)
            {
                var produtoOrdemDeServico_ = ProdutoOrdemDeServicoRepository.
                    ProdutoOrdemDeServicoPorId(produtoOrdemDeServico.ProdutoOrdemDeServicoId);

                produtoOrdemDeServico.OrdemDeServicoId = OrdemDeServicoCriada.OrdemDeServicoId;
                ;

                if (produtoOrdemDeServico_ == null)
                {
                    produtoOrdemDeServico.OrdemDeServicoId = OrdemDeServicoCriada.OrdemDeServicoId;
                    ProdutoOrdemDeServicoRepository.AdicionarProdutoOrdemDeServico(produtoOrdemDeServico);
                }
                else
                {
                    ProdutoOrdemDeServicoRepository.AtualizarProdutoOrdemDeServico(produtoOrdemDeServico);
                }
            }

            OrdemDeServicoRepository
                .AtualizarOrdemDeServico(OrdemDeServicoCriada.OrdemDeServicoId,
                TipoDeServicoBox.Text, DescricaoServicoBox.Text);
            LimparTodosDados();
        }

        //limpar os dados da venda, produto e cliente depois da criação da nova ods
        private void LimparTodosDados()
        {
            ListarODSEmAberto();
            TipoDeServicoBox.Text = "";
            DescricaoServicoBox.Text = "";

            ClienteSelecionado = null;
            ProdutoSelecionado = null;
            ProdutoSelecionado = null;
            ListaProdutoOrdemDeServico = null;
            OrdemDeServicoCriada = null;

            NomeProdutoLabel.Text = "Nome";
            Descricao.Text = "Descrição";
            PrecoLabel.Text = "Preço";
            QuantidadeDisponivelLabel.Text = "Quantidade disponível";
            CustoMedioLabel.Text = "Custo médio";

            TipoVeiculoLabel.Text = "Tipo:";
            ModeloVeiculoLabel.Text = "Modelo:";
            PlacaVeiculoLabel.Text = "Placa:";

            NomeClienteLabel.Text = "Nome";
            RgClienteLabel.Text = "RG";
            CpfCnpjClienteLabel.Text = "CPF/CNPJ";
            EnderecoClienteLabel.Text = "Endereço";
            TelefoneClienteLabel.Text = "Telefone";

            ListaDeVeiculos.SelectedItem = null;
            ListaProdutos.SelectedItem = null;

            AdicionarProdutoBox.Text = "";
            BuscarProdutoBox.Text = "";
            QuantidadeVendidaBox.Text = "";
            PrecoTotalVendaLabel.Text = "Valor Total:";


            ListaProdutos.Items.Clear();

            ProdutosNaOrdemDeServico.Rows.Clear();
        }
        private void DeletarButton_Click(object sender, EventArgs e)
        {
            if (OrdemDeServicoCriada == null)
            {
                MessageBox.Show("Sem ordem de serviço selecionada");
                return;
            }

            OrdemDeServicoRepository.ExcluirOrdemDeServico(OrdemDeServicoCriada);

            LimparTodosDados();
        }

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