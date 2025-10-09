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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        dbTarefasEntities4 ctx = new dbTarefasEntities4();
        private void btCadastro_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtEmail.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            Usuario usas = new Usuario();
            usas.Email = txtEmail.Text;
            usas.Nome = txtNome.Text;
            usas.Telefone = txtTelefone.Text;
            usas.DataNascimento = dateTimePicker1.Value;

            ctx.Usuario.Add (usas);
            ctx.SaveChanges();


            MessageBox.Show("Usuario adicionado com sucesso");
        }
    }
}
