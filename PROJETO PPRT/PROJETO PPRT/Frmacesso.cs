using controller;
using modelo;
using System;
using System.Linq;
using System.Windows.Forms;
using Vonage;
using Vonage.Messages;
using Vonage.Messaging;
using Vonage.Request;

namespace PROJETO_PPRT
{
    public partial class Frmacesso : Form
    {
        public event EventHandler UsuarioCadastrado;

        private const string apiKey = "2fd7b66d";
        private const string apiSecret = "kU1cpsTFucVmCqTq";

        private Random random = new Random();
        private int codigoAutenticacao;
        private string mensagemEnviada;

        private ErrorProvider errorProvider = new ErrorProvider();
        private usuariocontroller usController = new usuariocontroller();

        public Frmacesso()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txttelefone.Text))
                {
                    MessageBox.Show("Por favor, insira um número de telefone válido.");
                    return;
                }

                codigoAutenticacao = random.Next(1000, 9999);

                mensagemEnviada = $"Seu código de autenticação é: {codigoAutenticacao}";

                var credentials = Credentials.FromApiKeyAndSecret(apiKey, apiSecret);
                var client = new VonageClient(credentials);

                var smsRequest = new SendSmsRequest
                {
                    To = txttelefone.Text,
                    From = "Vonage APIs",
                    Text = mensagemEnviada
                };

                var response = await client.SmsClient.SendAnSmsAsync(smsRequest);

                var messageStatus = response.Messages[0].Status;

                if (messageStatus == MessageStatus.Delivered)
                {
                    MessageBox.Show($"Código de autenticação enviado com sucesso! Mensagem: {mensagemEnviada}");
                }
                else
                {
                    MessageBox.Show($"SMS enviado com sucesso. {messageStatus}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcodigo.Text))
                {
                    MessageBox.Show("Por favor, insira o código de autenticação recebido por SMS.");
                    return;
                }

                int codigoDigitado;
                if (!int.TryParse(txtcodigo.Text, out codigoDigitado))
                {
                    MessageBox.Show("Por favor, insira um código numérico válido.");
                    return;
                }

                if (codigoDigitado == codigoAutenticacao)
                {
                    CadastrarUsuario();

                    // Atualiza o DataGridView após cadastrar o novo usuário
                    UsuarioCadastrado?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Autenticação bem-sucedida! Dados cadastrados no banco de dados.");
                }
                else
                {
                    MessageBox.Show("Código de autenticação incorreto. Por favor, tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void CadastrarUsuario()
        {
            try
            {
                usuariomodelo usmodelo = new usuariomodelo();

                usmodelo.nome = txtnomeusi.Text;
                usmodelo.senha = txtsenhausi.Text;
                usmodelo.email = txtemailusi.Text;
                usmodelo.telefone = txttelefone.Text;
                usmodelo.perfil = 1; // Defina o perfil como 1
                if (usController.cadastrar(usmodelo))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso, bem-vindo(a) " + txtnomeusi.Text);

                    // Atualize o DataGridView no formulário Frmcadastrousuario
                    Frmcadastrousuario formCadastroUsuario = Application.OpenForms.OfType<Frmcadastrousuario>().FirstOrDefault();
                    formCadastroUsuario?.AtualizarDadosUsuarios();

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            txtnomeusi.Text = string.Empty;
            txtsenhausi.Text = string.Empty;
            txtemailusi.Text = string.Empty;
            txttelefone.Text = string.Empty;
        }

        private void Frmacesso_Load(object sender, EventArgs e)
        {
            // Remova ou comente a linha abaixo para evitar erros relacionados ao DataGridView
            // dtusuario.DataSource = usControle.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");
        }
    }
}
