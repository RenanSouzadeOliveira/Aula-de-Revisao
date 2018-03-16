using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Etec.AulaRevisao.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComfirmar_Click(object sender, EventArgs e)
        {
            // código de validação de tela
            if (validarTela())
            {
                
                MessageBox.Show("Cliente Validado", "Etec ZL");
            }
            else
            {
                MessageBox.Show("Cliente não validado!", "Etec ZL");
            }
        }
        private bool validarTela()
        {

            if (txtNome.Text != "" && txtSobrenome.Text !="")
            {
                return true;     
            }
            else 
            {
                if (txtNome.Text != "" && txtSobrenome.Text == "") MessageBox.Show("Sobrenome Inválido");
                else { 
                    MessageBox.Show("Nome Inválido");
                }
                return false;
            }
                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
        }


    }
}
