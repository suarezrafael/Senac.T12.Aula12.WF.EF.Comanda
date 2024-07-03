using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();

            CarregarUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CriarUsuario();
            //AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            throw new NotImplementedException();
        }

        private void CriarUsuario()
        {
            // validar se os campos estão preenchidos
            if (txtNome.TextButton == string.Empty)
            {
                MessageBox.Show("Preencha o Nome");
                return;
            }
            if (txtEmail.TextButton == string.Empty)
            {
                MessageBox.Show("Preencha o Email");
                return;
            }
            if (txtSenha.TextButton == string.Empty)
            {
                MessageBox.Show("Preencha o Senha");
                return;
            }
            using (var banco = new ComandaContexto())
            {
                // criar o objeto usuario
                var novoUsuario = new Usuario();
                novoUsuario.Nome = txtNome.Text;
                novoUsuario.Email = txtEmail.Text;
                novoUsuario.Senha = txtSenha.Text;

                // adiciona esse objeto no contexto do banco
                banco.Usuarios.Add(novoUsuario);

                // salvar as alterações (INSERT INTO Usuarios (Id, Nome, Email) Values())
                banco.SaveChanges();
            }
        }

        private void CarregarUsuarios()
        {
            using (var banco = new ComandaContexto())
            {
                // consulta todos os usuario na tabela Usuarios (SELECT * FROM usuarios )
                var usuarios = banco.Usuarios.ToList();

                // dados da tabela usuarios serão exibidos no GRID
                dgvUsuarios.DataSource = usuarios;
            }
        }
    }
}
