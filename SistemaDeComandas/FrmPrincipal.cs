using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas
{
    public partial class FrmPricipal : Form
    {
        public FrmPricipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
            CriarUsuarioAdmin();
        }

        private void CriarUsuarioAdmin()
        {
            // acessa o banco de dados
            using (var banco = new ComandaContexto())
            {
                // verificar se ja existe um admin
                var usuarioExiste = banco
                    .Usuarios
                    .FirstOrDefault(usuario =>
                        usuario
                            .Nome
                                .Equals("Admin"));

                if (usuarioExiste != null)
                    return;

                // cria um novo usuario
                var novoUsuario = new Usuario();
                // atribuimos os valores para cada prop usuario
                novoUsuario.Nome = "Admin";
                novoUsuario.Email = "admin@comanda.com";
                novoUsuario.Senha = "123";
                // banco, adicione na colecao usuario um novo usr
                banco.Usuarios.Add(novoUsuario);

                // confirmar a adição
                banco.SaveChanges();
            }
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
