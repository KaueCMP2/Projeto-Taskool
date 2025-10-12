using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Separador_de_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome != null)
            {
                var random = new Random(); // Define o random como novo Random... desnecessario
                var nomeCompleto = txtNome.Text; // Define que o nome completo e o conteudo da caixa de texto
                string[] partesNome = nomeCompleto.Split(' '); // Indica que as strings começam e acabam quando tem ' ' o espaço

                // Usa o primeiro nome [0]
                string nickName = partesNome[0] + '.';

                //Se o numero de partes for maior que 1 ou seja 2
                if (partesNome.Length > 1)
                {
                  //nickName + partes nome 
                    nickName += partesNome[partesNome.Length -1];

                  //Nome de usuario concantenado com numero automatico de 0 a 100 
                    nickName += random.Next(1, 100);

                    // apreseta o nome gerado em um pop-pup
                    MessageBox.Show($"O nome gerado foi: {nickName}"); // $ indica um que pode passar uma intring
                }

                // senão, se ele for , menor ou igual a 1... (inserir um nome completo)
                else if(partesNome.Length <= 1)
                {
                    MessageBox.Show("Insira seu nome completo");
                }

            }

            // caso contrario (SE A CAIXA DE TEXTO ESTIVER VAZIA)...
            else
            {
                MessageBox.Show("Por favor, insira seu nome completo.");
            }
        }
    }
}
