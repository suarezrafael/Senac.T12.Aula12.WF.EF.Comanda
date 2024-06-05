using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;

namespace SistemaDeComandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        // metodo criar o banco de dados
        void CriarBancoDeDados()
        {
            // criando um novo(new) contexto do banco
            using (var banco = new ComandaContexto())
            {
                // criar as tabelas do banco
                banco.Database.Migrate();
            }
        }
    }
}
