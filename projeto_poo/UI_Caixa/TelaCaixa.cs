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
            caixa_nome.Text = "";
            caixa_nome.Text = caixa.Nome;
        }

        private void TelaCaixa_Load(object sender, EventArgs e)
        {

        }
    }
}
