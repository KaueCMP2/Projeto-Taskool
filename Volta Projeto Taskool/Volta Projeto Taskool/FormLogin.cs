using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Volta_Projeto_Taskool.Model;

namespace Volta_Projeto_Taskool
{
    public partial class FormLogin : Form
    {
        
        dbTarefasEntities6 ctx = new dbTarefasEntities6();
        private Image selecionarImagem()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione uma imagem";
                ofd.Filter = "Image Files | *.jpg;*.png;";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return Image.FromFile(ofd.FileName);
                }
                else
                {
                    return null;
                }
            }
        }


        public FormLogin()
        {
            InitializeComponent();

            txtUsuario.ShortcutsEnabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarioBuscado = ctx.Usuario.FirstOrDefault(x => x.Usuario1 == txtUsuario.Text);

            if (usuarioBuscado == null)
            {
                MessageBox.Show("Dados incorretos!");
            }

            else
            {
                MessageBox.Show($"Dados Corretos! Bem Vido {usuarioBuscado.Nome}");
            }
        }

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
        }
    }
}
