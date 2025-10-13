using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Volta_Projeto_Taskool.Model;

namespace Volta_Projeto_Taskool
{
    public partial class FormLogin : Form
    {
        bool FotoCarregada = false;
        byte[] imagemCarregadaBytes;

        // Funcao para carregar imagaem
        dbTarefasEntities6 ctx = new dbTarefasEntities6();
        private Image selecionarImagem()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione uma imagem";
                ofd.Filter = "Image Files | *.jpg;*.png;";
                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Indica que a credencial foi carregada
                    MessageBox.Show("Credencial selecionada com sucesso", "Parabens" ,MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Guarda a imagem em um array e muda o estado da variavel FotoCarregada para true
                    imagemCarregadaBytes = File.ReadAllBytes(ofd.FileName);
                    FotoCarregada = true;

                    // Imprime a imagem no Btcredencial
                    return Image.FromFile(ofd.FileName);
                }

                else
                {
                    FotoCarregada = false;
                    return null;
                }
            }
        }

        public FormLogin()
        {
            InitializeComponent();

            txtUsuario.ShortcutsEnabled = false;
        }

        // ABRIR TECLADO VIRTUAL...
        private void BtTecladoVt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Focar no campo de texto
            txtUsuario.Focus();

            //Abrir o teclado virtual
            Process.Start("osk.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image imagemEscolhida = selecionarImagem();
            if (imagemEscolhida != null)
            {
                btCredencial.Image = imagemEscolhida;
            }
        }

        private void linkCadastro_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormCadastro().ShowDialog();
            this.Close();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || FotoCarregada != true)
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Digite o nome de usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SystemSounds.Beep.Play();
                    txtUsuario.Focus();
                    return;
                }

                else if (!FotoCarregada)
                {
                    var resposta = MessageBox.Show("Nenhuma Credencial encontrada!", "Tentar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    SystemSounds.Beep.Play();

                    if(resposta == DialogResult.Yes)
                    {
                        var ImagemEscolhida = selecionarImagem();

                        if(ImagemEscolhida == null)
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }

            
        var usuarioBuscado = ctx.Usuario.FirstOrDefault(x => x.UsuarioLogin == txtUsuario.Text);

            if(usuarioBuscado == null)
            {
                MessageBox.Show("Dados não localizados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SystemSounds.Beep.Play();
                return;
            }
                
            byte[] imagemBanco = usuarioBuscado.Foto;
            byte[] imagemLocal = imagemCarregadaBytes;

            bool mesmaImagem = imagemBanco != null && imagemLocal != null && imagemBanco.SequenceEqual(imagemLocal);

                if (mesmaImagem)
                {
                    MessageBox.Show($"Parabens {usuarioBuscado.UsuarioLogin}! ", "login efetuado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SystemSounds.Beep .Play();

                    Form1 nFrm = new Form1();
                    nFrm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("A imagem não corresponde a credencial salva", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SystemSounds .Beep .Play();
                }                        
        }
    }
}
