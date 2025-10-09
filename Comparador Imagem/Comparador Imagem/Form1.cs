using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparador_Imagem
{
    public partial class Form1 : Form
    {
        private Image selecionarImagem() 
        {
            using (OpenFileDialog openF = new OpenFileDialog())
            {
                openF.Title = "Selecione um arquivo de imgaem";
                openF.Filter = "Imagens | *.jpg;*.jpeg;*.png*.bmp";

                if (openF.ShowDialog() == DialogResult.OK)
                {
                    return Image.FromFile(openF.FileName);
                }
                return null;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btImagem1_Click(object sender, EventArgs e)
        {
            Image imagemEscolhida = selecionarImagem();
            if (imagemEscolhida != null)
            {
                btImagem1.Image = imagemEscolhida;
            }
        }

        private void btImagem2_Click(object sender, EventArgs e)
        {
            Image imagemEscolhida = selecionarImagem();
            if (imagemEscolhida != null)
            {
                btImagem2.Image = imagemEscolhida;
            }
        }
    }
}
