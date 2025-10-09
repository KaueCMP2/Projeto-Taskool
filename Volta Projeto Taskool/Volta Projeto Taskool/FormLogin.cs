using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        dbTarefasEntities4 ctx = new dbTarefasEntities4();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarioBuscado = ctx.Usuario.FirstOrDefault(x => x.Email==txtUsuario.Text);

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
            new FormCadastro().Show();
        }
    }
}
