using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Runtime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Volta_Projeto_Taskool.Model;

namespace Volta_Projeto_Taskool
{
    public partial class FormCadastro : Form
    {
        // Variaveis
        bool fotoCarregada = false; // fotoCarregada como false para validações futuras
        byte[] imagemCarregadaBytes; // defino a imagem carregada como array de bytes
        bool cadastroRealizado = false; // Definir estado do cadastro para validação
        bool emailInvalido = false;
        bool usuarioInvalido = false;
        public FormCadastro()
        {
            InitializeComponent();

            deixarCircular(BoxSelecionarCredencial);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private Image selecionarImagem()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecionar imagem";
                ofd.Filter = "Selecionar imagem | *.jpg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagemCarregadaBytes = File.ReadAllBytes(ofd.FileName);
                    fotoCarregada = true;
                    return Image.FromFile(ofd.FileName);
                }
                else
                {
                    return null;
                }
            }
        }
        // Arredondar o botao de vizualização da credencial
        private void deixarCircular(PictureBox pic)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1);
            pic.Region = new Region(gp);
        }

        dbTarefasEntities7 ctx = new dbTarefasEntities7(); // Instaciar ctx para chamar colunas do banco de dados
        private void btCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                 string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                 imagemCarregadaBytes == null || emailInvalido == false || usuarioInvalido == false)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ctx.Usuario.Any(u => u.Usuario1 == txtUsuario.Text))
            {
                var nomeIgual = MessageBox.Show($"O nome {txtUsuario.Text} ja esta cadastrado! Gerar Aleatorio?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                SystemSounds.Beep.Play();

                if (DialogResult.Yes == nomeIgual)
                {
                    btGeraAuto.Focus();
                }

                return;
            }

            else
            {
                Usuario usas = new Usuario();
                usas.Email = txtEmail.Text;
                usas.Nome = txtNome.Text;
                usas.Telefone = txtTelefone.Text;
                usas.Usuario1 = txtUsuario.Text;
                usas.dataNascimento = dataNascimento.Value;
                usas.Foto = imagemCarregadaBytes;

                ctx.Usuario.Add(usas);
                ctx.SaveChanges();
                cadastroRealizado = true;

                MessageBox.Show("Usuario adicionado com sucesso");

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image umagemEscolhida = selecionarImagem();
            if (umagemEscolhida != null)
            {
                BoxSelecionarCredencial.Image = umagemEscolhida;
                BoxSelecionarCredencial.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btGeraAuto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                var nomeCompleto = txtNome.Text;
                var random = new Random();
                string[] partesNome = nomeCompleto.Split(' ');
                string nickAleatiorio = partesNome[0] + '.';
                string ultimosDigitosAno = dataNascimento.Value.ToString("yy");

                if (partesNome.Length > 2)
                {
                    nickAleatiorio += partesNome[partesNome.Length - 1];
                    nickAleatiorio += ultimosDigitosAno;
                    bool nomeExiste = ctx.Usuario.Any(u => u.Usuario1 == nickAleatiorio);


                    if (nomeExiste)
                    {
                        nickAleatiorio = partesNome[0] + '.' + partesNome[partesNome.Length - 2] + ultimosDigitosAno;

                        string converterParaString = nickAleatiorio.ToString();
                        string nickToLower = converterParaString.ToLower();
                        txtUsuario.Text = nickToLower;
                        lblAviso.Visible = false;
                    }

                    else
                    {

                        string converterParaString = nickAleatiorio.ToString();
                        string nickToLower = converterParaString.ToLower();
                        txtUsuario.Text = nickToLower;
                        lblAviso.Visible = false;
                    }
                }

                else
                {
                    if (partesNome.Length <= 2)
                    {
                        MessageBox.Show("Adicione seu nome completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SystemSounds.Beep.Play();
                        txtNome.Focus();
                    }
                }
            }

            else
            {
                MessageBox.Show("Adicione seu nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SystemSounds.Beep.Play();
                txtNome.Focus();
            }

            if (cadastroRealizado == true)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SystemSounds.Beep.Play();

                FormLogin novoFormLogin = new FormLogin();
                novoFormLogin.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            BordaTxtNome.Visible = true;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            BordaTxtNome.Visible = false;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            BordaTxtEmail.Visible = true;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            var email = txtEmail.Text;

            BordaTxtEmail.Visible = false;

            try
            {
                MailAddress mailAddress;

                if (!string.IsNullOrWhiteSpace(email))
                {
                    mailAddress = new MailAddress(email);

                    var mensagemEmailInvalido = MessageBox.Show($"O email: {email}... é valido", "sucesso", MessageBoxButtons.OK);
                    SystemSounds.Beep.Play();
                }
                emailInvalido = false;
            }

            catch (Exception exc)
            {
                var mensagemEmailInvalido = MessageBox.Show($"O email: {email}... é invalido, por favor adcione um novo", "Erro", MessageBoxButtons.OK);
                SystemSounds.Beep.Play();

                if (mensagemEmailInvalido == DialogResult.OK)
                {
                    txtEmail.Focus();
                    emailInvalido = true;

                }
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            BordaTxtTelefone.Visible = true;
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            BordaTxtTelefone.Visible = false;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            BordaTxtUsuario.Visible = true;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            usuarioInvalido = ctx.Usuario.Any(u => u.Usuario1 == txtUsuario.Text);
            usuarioInvalido = true;

            if (usuarioInvalido)
            {
                lblAviso.Visible = true;


                MessageBox.Show("Ops, esse nome de usuario ja esta em uso", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Beep.Play();

            }
            BordaTxtUsuario.Visible = false;
        }

        private void lblAviso_MouseHover(object sender, EventArgs e)
        {
            lblEmUso.Visible = true;
        }

        private void lblAviso_MouseLeave(object sender, EventArgs e)
        {
            lblEmUso.Visible = false;
        }
    }
}
