﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_Media_Alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Botao de Calcular 
        {
            decimal soma, media, valor;
            soma = 0;
            
            foreach (Control controle  in this.Controls)
            {
                if (controle is TextBox)
                {
                    textBox1.Focus();
                    valor = Convert.ToDecimal(((TextBox)controle).Text);
                    soma += valor;
                }
                
                media = soma / 4;
                this.Controls["label7"].Text = media.ToString();
                    
            }
        }

        private void button2_Click(object sender, EventArgs e) // Botao de limpar
        {
            
            foreach(Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                this.Controls["label7"].Text = "[......]";

            }
          
        }

    }
}
