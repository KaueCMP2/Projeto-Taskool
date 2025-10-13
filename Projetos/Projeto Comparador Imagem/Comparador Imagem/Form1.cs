using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparador_Imagem
{
    public partial class Form1 : Form
    {
        byte[] imagem1SelecionadaBytes;
        byte[] imagem2SelecionadaBytes;

        private Image selecionarImagem1() 
        {
            using (OpenFileDialog openF = new OpenFileDialog())
            {
                openF.Title = "Selecione um arquivo de imgaem";
                openF.Filter = "Tipos de imagem | *.jpg;*.png";

                if (openF.ShowDialog() == DialogResult.OK)
                {
                    imagem1SelecionadaBytes = File.ReadAllBytes(openF.FileName);
                    return Image.FromFile(openF.FileName);
                }
                return null;
            }
        }

        private Image selecionarImagem2()
        {
            using (OpenFileDialog openF = new OpenFileDialog())
            {
                openF.Title = "Selecione um arquivo de imgaem";
                openF.Filter = "Tipos de imagem | *.jpg;*.png";

                if (openF.ShowDialog() == DialogResult.OK)
                {
                    imagem2SelecionadaBytes = File.ReadAllBytes(openF.FileName);
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
            Image imagemEscolhida = selecionarImagem1();
            if (imagemEscolhida != null)
            {
                btImagem1.Image = imagemEscolhida;
            }
        }

        private void btImagem2_Click(object sender, EventArgs e)
        {
            Image imagemEscolhida = selecionarImagem2();
            if (imagemEscolhida != null)
            {
                btImagem2.Image = imagemEscolhida;
            }
        }

        private void btComparar_Click(object sender, EventArgs e)
        {
            bool mesmaImagem = imagem1SelecionadaBytes.SequenceEqual(imagem2SelecionadaBytes);

            if (mesmaImagem) 
            {
                var acertou = MessageBox.Show("As imagens sao iguais...", "Parabens", MessageBoxButtons.OK);
                
                if(acertou == DialogResult.OK)
                {
                    MessageBox.Show($"O array de bytes da imagem é: {imagem1SelecionadaBytes}");
                }
            }

            else
            {
                MessageBox.Show("Errou, sao diferentes");
            }
        }
    }
}
