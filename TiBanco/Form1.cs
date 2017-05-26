﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArquivoTexto_Click(object sender, EventArgs e)
        {
            ManipulaArquivo arquivo = new ManipulaArquivo();
            Ordenacao ordena = new Ordenacao(arquivo.vetor);
            arquivo.escreve(ordena.bubble);
        }
    }
}
