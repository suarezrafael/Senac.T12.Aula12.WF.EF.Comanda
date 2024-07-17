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

            LimparCampos();
            DesabilitarCampos();
            CarregarUsuarios();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }
        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                // buscar o usuario pelo ID
                var usuario = banco
                    .Usuarios
                        .First(usuario =>
                                usuario.Id == int.Parse(txtId.TextButton));

                // SELECT * FROM usuarios
                // WHERE id = 234

                // atualizar as propriedades
                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;

                // salvar as alterações
                // UPDATE usuarios SET
                // Nome = 'Rafael <- (txtNome.TextButton)',
                // Email = 'rafaelv_s@hotmail.gov'
                // WHERE id = 1
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário atualizado com sucesso");
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
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;

                // adiciona esse objeto no contexto do banco
                banco.Usuarios.Add(novoUsuario);

                // salvar as alterações (INSERT INTO Usuarios (Nome, Email,Senha) Values('1','fsd','32423'))
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário cadastrado com sucesso.");
        }

        private void CarregarUsuarios()
        {
            using (var banco = new ComandaContexto())
            {
                // consulta todos os usuario na tabela Usuarios (SELECT * FROM usuarios )
                var usuarios = banco.Usuarios.ToList();

                dgvUsuarios.DataSource = null;
                // dados da tabela usuarios serão exibidos no GRID
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // informa que esta cadastrando um novo usuario
            ehNovoUsuario = true;
            // limpa os campos da tela
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
            // chama o metodo que habilita os campos para digitação
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ehNovoUsuario = false;
            HabilitarCampos();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verificar se a linha foi selecionada
            if (e.RowIndex >= 0)
            {
                // obter a linha
                var linha = dgvUsuarios.Rows[e.RowIndex];

                // popular os campos da tela de acordo com a linha
                txtId.TextButton = linha.Cells["Id"].Value.ToString();
                txtNome.TextButton = linha.Cells["Nome"].Value.ToString();
                txtEmail.TextButton = linha.Cells["Email"].Value.ToString();
                txtSenha.TextButton = linha.Cells["Senha"].Value.ToString();
            }
        }
    }
}
