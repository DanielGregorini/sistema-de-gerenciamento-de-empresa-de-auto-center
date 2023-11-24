using AutoCenter;
using AutoCenter.Data;
using AutoCenter.Model;
using AutoCenter.Repository;

namespace AutoCenter
{
    public partial class TelaCaixa : Form
    {
        public TelaCaixa(Caixa caixa)
        {
            InitializeComponent();
            this.Text = "Sistema de Gerenciamento de empresa Auto Center";
            caixa_nome.Text = caixa.Nome;

            // Obter dados das vendas
            var listaDeVendasEmAberto = VendaRepository.ListarVendas().Where(v => v.Estado != "Pago").ToList();
            
            // Atribuir a fonte de dados à DataGridView existente
            listaVendaEmAberto.DataSource = listaDeVendasEmAberto;
            // Adicionar uma nova coluna para o nome do vendedor
            

            // Ocultar as colunas desejadas
            listaVendaEmAberto.Columns["Vendedor"].Visible = false;
            listaVendaEmAberto.Columns["Cliente"].Visible = false;

            // Adicionar uma coluna de botão
            DataGridViewButtonColumn botaoColuna = new DataGridViewButtonColumn();
            botaoColuna.Name = "BotaoAcao";
            botaoColuna.HeaderText = "Ação";
            botaoColuna.Text = "Confirmar Pagamento";
            botaoColuna.UseColumnTextForButtonValue = true;
            listaVendaEmAberto.Columns.Add(botaoColuna);

            // Definir tamanhos específicos para as
            listaVendaEmAberto.Columns["VendaId"].Width = 60;
            listaVendaEmAberto.Columns["BotaoAcao"].Width = 150;
            listaVendaEmAberto.Columns["ClienteId"].Width = 50;
            listaVendaEmAberto.Columns["VendedorId"].Width = 70;  // Substitua "Nome" pelo nome real da coluna
            //listaVendaEmAberto.Columns["Preco"].Width = 100;  // Substitua "Preco" pelo nome real da coluna

            // Manipular o evento de clique no botão
            listaVendaEmAberto.CellContentClick += ListaVendaEmAberto_CellContentClick;

            // Atualizar o layout da DataGridView, se necessário
            listaVendaEmAberto.Refresh();
            listaVendaEmAberto.AutoResizeColumns();
        }

        private void RecarregarPagina()
        {
            // Obter dados das vendas
            var listaDeVendasEmAberto = VendaRepository.ListarVendas();

            // Atribuir a fonte de dados à DataGridView existente
            listaVendaEmAberto.DataSource = listaDeVendasEmAberto;

            // Ocultar as colunas desejadas
            listaVendaEmAberto.Columns["Vendedor"].Visible = false;
            listaVendaEmAberto.Columns["Cliente"].Visible = false;

            // Adicionar uma coluna de botão
            DataGridViewButtonColumn botaoColuna = new DataGridViewButtonColumn();
            botaoColuna.Name = "BotaoAcao";
            botaoColuna.HeaderText = "Ação";
            botaoColuna.Text = "Mudar Estado";
            botaoColuna.UseColumnTextForButtonValue = true;
            listaVendaEmAberto.Columns.Add(botaoColuna);

            // Manipular o evento de clique no botão
            listaVendaEmAberto.CellContentClick += ListaVendaEmAberto_CellContentClick;

            // Atualizar o layout da DataGridView, se necessário
            listaVendaEmAberto.AutoResizeColumns();
            RecarregarPagina();
        }

        private void ListaVendaEmAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verificar se o clique ocorreu na coluna de botão
            if (e.RowIndex >= 0 && e.ColumnIndex == listaVendaEmAberto.Columns["BotaoAcao"].Index)
            {
                // Obter o ID da venda na mesma linha
                int idVenda = Convert.ToInt32(listaVendaEmAberto.Rows[e.RowIndex].Cells["VendaId"].Value);
                MessageBox.Show($"A venda com ID {idVenda} será alterada.", "Aviso");
                // Chamar a função VendaRepository.MudarEstadoVenda com o ID da venda
                
                VendaRepository.MudarEstadoVenda(idVenda);
                listaVendaEmAberto.Refresh();
            }
        }

        private void TelaCaixa_Load(object sender, EventArgs e)
        {

        }

        private void listaVendaEmAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
