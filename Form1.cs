using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sistema_login
{
    public partial class Form1 : Form
    {
        Thread nt; //criação da Thead como 'se fosse uma variavel'
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Admin" && textBoxSenha.Text == "123456")
            {
                MessageBox.Show("Bem vindo ao sistema!", "Acesso ao sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Acesso Negado !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
