using AutoCenter;
using AutoCenter.Data;
using AutoCenter.Model;
using AutoCenter.Repository;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class TelaCaixa : Form
    {
        public TelaCaixa(Caixa caixa)
        {
            InitializeComponent();
            this.Text = "Sistema de Gerenciamento de Empresa Auto Center";
            caixa_nome.Text = caixa.Nome;

            CarregarDadosAsync();
        }

        private async void CarregarDadosAsync()
        {
            // Iniciar os métodos assíncronos e aguardar a conclusão de todos
            await Task.WhenAll(
                ConfigurarColunasDataGridViewVendas(), ConfigurarColunasDataGridViewOrdensDeServico()
            );

            await Task.WhenAll(
                CarregarDadosGridVendasEmAberto(), CarregarDadosGridOrdensDeServicoEmAberto()
            );

        }

        private async Task ConfigurarColunasDataGridViewVendas()
        {
            // Limpar as colunas existentes, se houver
            listaVendaEmAberto.Columns.Clear();

            // Criar e adicionar as colunas necessárias
            DataGridViewTextBoxColumn colunaIdVenda = new DataGridViewTextBoxColumn();
            colunaIdVenda.HeaderText = "Id Venda";
            colunaIdVenda.DataPropertyName = "IdVenda";
            listaVendaEmAberto.Columns.Add(colunaIdVenda);

            DataGridViewTextBoxColumn colunaNomeCliente = new DataGridViewTextBoxColumn();
            colunaNomeCliente.HeaderText = "Nome Cliente";
            colunaNomeCliente.DataPropertyName = "NomeCliente";
            listaVendaEmAberto.Columns.Add(colunaNomeCliente);

            DataGridViewTextBoxColumn colunaIdVendedor = new DataGridViewTextBoxColumn();
            colunaIdVendedor.HeaderText = "Id Vendedor";
            colunaIdVendedor.DataPropertyName = "IdVendedor";
            listaVendaEmAberto.Columns.Add(colunaIdVendedor);

            DataGridViewTextBoxColumn colunaValorTotal = new DataGridViewTextBoxColumn();
            colunaValorTotal.HeaderText = "Valor Total";
            colunaValorTotal.DataPropertyName = "ValorTotal";
            listaVendaEmAberto.Columns.Add(colunaValorTotal);

            DataGridViewButtonColumn botaoColuna = new DataGridViewButtonColumn();
            botaoColuna.Name = "BotaoAcao";
            botaoColuna.HeaderText = "Confirmar Venda";
            botaoColuna.UseColumnTextForButtonValue = true;
            listaVendaEmAberto.Columns.Add(botaoColuna);
        }

        private async Task CarregarDadosGridVendasEmAberto()
        {
            // Limpar as linhas existentes, se houver
            listaVendaEmAberto.Rows.Clear();

            // Lista de todas as vendas em aberto
            var listaDeVendasEmAberto = VendaRepository.ListarVendas().Where(v => v.Estado != "Pago").ToList();

            foreach (var venda in listaDeVendasEmAberto)
            {
                // Criar uma nova instância de DataGridViewRow
                DataGridViewRow novaLinha = new DataGridViewRow();

                // Adicionar as células à linha
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.VendaId });

                var cliente = ClienteRepository.ClientePorId(venda.ClienteId);
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Nome });

                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.VendedorId });
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.ValorTotal });

                // Adicionar a célula do botão à linha
                DataGridViewButtonCell botaoCelula = new DataGridViewButtonCell { Value = "Confirmar Pagamento" };
                novaLinha.Cells.Add(botaoCelula);

                // Adicionar a linha ao DataGridView
                listaVendaEmAberto.Rows.Add(novaLinha);
            }
        }

        private void ListaVendaEmAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se o clique ocorreu na coluna de botão
            if (e.RowIndex >= 0 && e.ColumnIndex == listaVendaEmAberto.Columns["BotaoAcao"].Index)
            {
                // Obter o valor da primeira coluna (índice 0) na mesma linha
                if (listaVendaEmAberto.Rows[e.RowIndex].Cells[0].Value is int idVenda)
                {
                    MessageBox.Show($"A venda com ID {idVenda} será alterada.", "Aviso");

                    // Chamar a função VendaRepository.MudarEstadoVenda com o ID da venda
                    VendaRepository.MudarEstadoVenda(idVenda);

                    // Recarregar o DataGridView chamando a função de carregar dados
                    CarregarDadosGridVendasEmAberto();
                }
            }
        }

        private async Task ConfigurarColunasDataGridViewOrdensDeServico()
        {
            //listaOrdemDeServicoEmAberto
            // Limpar as colunas existentes, se houver
            listaOrdemDeServicoEmAberto.Columns.Clear();

            // Criar e adicionar as colunas necessárias
            DataGridViewTextBoxColumn colunaIdOrdemDeServico = new DataGridViewTextBoxColumn();
            colunaIdOrdemDeServico.HeaderText = "Id Ordem de Serviço";
            colunaIdOrdemDeServico.DataPropertyName = "IdOrdemDeServico";
            listaOrdemDeServicoEmAberto.Columns.Add(colunaIdOrdemDeServico);

            DataGridViewTextBoxColumn colunaTipoDeServico = new DataGridViewTextBoxColumn();
            colunaTipoDeServico.HeaderText = "Tipo de Serviço";
            colunaTipoDeServico.DataPropertyName = "TipoDeServico";
            listaOrdemDeServicoEmAberto.Columns.Add(colunaTipoDeServico);

            DataGridViewTextBoxColumn colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.DataPropertyName = "Descricao";
            listaOrdemDeServicoEmAberto.Columns.Add(colunaDescricao);

            DataGridViewTextBoxColumn colunaNomeCliente = new DataGridViewTextBoxColumn();
            colunaNomeCliente.HeaderText = "Nome Cliente";
            colunaNomeCliente.DataPropertyName = "NomeCliente";
            listaOrdemDeServicoEmAberto.Columns.Add(colunaNomeCliente);

            DataGridViewTextBoxColumn colunaIdVendedor = new DataGridViewTextBoxColumn();
            colunaIdVendedor.HeaderText = "Id Vendedor";
            colunaIdVendedor.DataPropertyName = "IdVendedor";
            listaOrdemDeServicoEmAberto.Columns.Add(colunaIdVendedor);

            DataGridViewTextBoxColumn colunaValorTotal = new DataGridViewTextBoxColumn();
            colunaValorTotal.HeaderText = "Valor Total";
            colunaValorTotal.DataPropertyName = "ValorTotal";
            listaOrdemDeServicoEmAberto.Columns.Add(colunaValorTotal);

            DataGridViewTextBoxColumn colunaHorarioDeEntrega = new DataGridViewTextBoxColumn();
            colunaHorarioDeEntrega.HeaderText = "Horario de Entrega";
            colunaHorarioDeEntrega.DataPropertyName = "HorarioDeEntrega";
            listaOrdemDeServicoEmAberto.Columns.Add(colunaHorarioDeEntrega);

            DataGridViewButtonColumn botaoColuna = new DataGridViewButtonColumn();
            botaoColuna.Name = "BotaoAcao";
            botaoColuna.HeaderText = "Confirmar Ordem de Serviço";
            botaoColuna.UseColumnTextForButtonValue = true;
            listaOrdemDeServicoEmAberto.Columns.Add(botaoColuna);
        }

        private async Task CarregarDadosGridOrdensDeServicoEmAberto()
        {
            listaOrdemDeServicoEmAberto.Rows.Clear();

            var listaDeOrdensDeServicoEmAberto = OrdemDeServicoRepository.ListarOrdemDeServico().Where(v => v.Estado != "Pago").ToList();

            foreach (var ordemDeServico in listaDeOrdensDeServicoEmAberto)
            {
                DataGridViewRow novaLinha = new DataGridViewRow();

                // Adicionar as células à linha
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = ordemDeServico.OrdemDeServicoId });

                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = ordemDeServico.TipoDeServico });

                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = ordemDeServico.Descricao });

                var cliente = ClienteRepository.ClientePorId(ordemDeServico.ClienteId);
                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Nome });

                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = ordemDeServico.VendedorId });

                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = ordemDeServico.ValorTotal });

                novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = ordemDeServico.HorarioDeEntrega });

                DataGridViewButtonCell botaoCelulaOrdemDeServico = new DataGridViewButtonCell { Value = "Confirmar Pagamento" };

                novaLinha.Cells.Add(botaoCelulaOrdemDeServico);

                // Adicionar a linha ao DataGridView
                listaOrdemDeServicoEmAberto.Rows.Add(novaLinha);
            }

        }

        private void ListaOrdemDeServicoEmAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se o clique ocorreu na coluna de botão
            if (e.RowIndex >= 0 && e.ColumnIndex == listaOrdemDeServicoEmAberto.Columns["BotaoAcao"].Index)
            {
                // Obter o valor da primeira coluna (índice 0) na mesma linha
                if (listaOrdemDeServicoEmAberto.Rows[e.RowIndex].Cells[0].Value is int idOrdemDeServico)
                {
                    MessageBox.Show($"A ordem de serviço com ID {idOrdemDeServico} será confirmada.", "Aviso");

                    // Chamar a função para confirmar a ordem de serviço
                    OrdemDeServicoRepository.MudarEstadoOrdemDeServico(idOrdemDeServico);

                    // Recarregar o DataGridView chamando a função de carregar dados
                    CarregarDadosGridOrdensDeServicoEmAberto();
                }
            }
        }

        private void TelaCaixa_Load(object sender, EventArgs e)
        {
            // O código a ser executado ao carregar a tela, se necessário
        }

        private void listaOrdemDeServicoEmAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
