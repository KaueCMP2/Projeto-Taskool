using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
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

        private Image selecionarImagem() 
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecionar imagem";
                ofd.Filter = "Selecionar imagem | *.jpg;*.png";

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    return Image.FromFile(ofd.FileName);
                }
                else
                {
                    return null;
                }
            }
        }
        public FormCadastro()
        {
            InitializeComponent();

            deixarCircular(BoxSelecionarCredencial);
        }

        private void deixarCircular(PictureBox pic)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0,0, pic.Width - 1, pic.Height - 1);
            pic.Region = new Region(gp);
        }

        dbTarefasEntities6 ctx = new dbTarefasEntities6();
        private void btCadastro_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtEmail.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            else { 
                Usuario usas = new Usuario();
                usas.Email = txtEmail.Text;
                usas.Nome = txtNome.Text;
                usas.Telefone = txtTelefone.Text;
                usas.Usuario1 = txtUsuario.Text;
                usas.dataNascimento = dateTimePicker1.Value;


                ctx.Usuario.Add (usas);
                ctx.SaveChanges();


                MessageBox.Show("Usuario adicionado com sucesso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image umagemEscolhida = selecionarImagem();
            if(umagemEscolhida != null)
            {
                BoxSelecionarCredencial.Image = umagemEscolhida;
                BoxSelecionarCredencial.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btGeraAuto_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != null)
            {
                var nomeCompleto = txtNome.Text;
                var random = new Random();
                string[] partesNome = nomeCompleto.Split(' ');

                string nickAleatiorio = partesNome[0] + '.';

                if (partesNome.Length > 1)
                {
                    nickAleatiorio += partesNome[partesNome.Length - 1];
                    nickAleatiorio += random.Next(1, 100);

                    txtUsuario.Text = nickAleatiorio;
                }

                else if (partesNome.Length <= 1)
                {

                    MessageBox.Show("Adicione seu nome completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SystemSounds.Beep.Play();
                    txtNome.Focus();
                }
            }

            else
            {
                MessageBox.Show("Adicione seu nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SystemSounds.Beep.Play();
                txtNome.Focus();
            }
        }
    }
}
