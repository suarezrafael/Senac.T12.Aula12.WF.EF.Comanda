using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas
{
    public partial class FrmUsuario : Form
    {
        private bool ehNovoUsuario;

        public FrmUsuario()
        {
            InitializeComponent();

            CarregarUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovoUsuario)
                CriarUsuario();
            else
                AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                // buscar o usuario pelo ID
                var usuario = banco
                    .Usuarios
                        .First(usuario =>
                                usuario.Id == 1);

                // atualizar as propriedades
                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;

                // salvar as alterações
                banco.SaveChanges();
            }
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovoUsuario = true;

            txtNome.TextButton = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ehNovoUsuario = false;
        }
    }
}
