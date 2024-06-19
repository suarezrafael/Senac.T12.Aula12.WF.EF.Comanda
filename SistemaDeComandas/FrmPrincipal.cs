using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;

namespace SistemaDeComandas
{
    public partial class FrmPricipal : Form
    {
        public FrmPricipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        private void CriarBancoDeDados()
        {
            using (var banco = new ComandaContexto())
            {
                banco.Database.Migrate();
            }
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            // crio o form de cardapio e exibo para o humano
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }
    }
}
