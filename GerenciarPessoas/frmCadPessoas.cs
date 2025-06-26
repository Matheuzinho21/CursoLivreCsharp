using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarPessoas
{
    public partial class frmCadPessoas : Form
    {
        private object ltbItemsCadastrados;

        public string Email { get; private set; }

        public frmCadPessoas()
        {
            InitializeComponent();
            LimparCampos();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //executandoa classe pessoa 
            Pessoa ps = new Pessoa();

            ps.Nome = txtNome.Text;
            ps.Email = txtEmail.Text;
            ps.TelCel = mskTelefone.Text;

            btnItensCadastrados.Items.Add(ps.Nome + "-" + ps.Email + "-" + ps.TelCel);
        }
        //limpar campos 
        Public void LimparCampos()
        {    
                txtNome.Clear();
                txtEmail.Clear();
                mskTelefone.Clear();
                txtNome.Focus();
        }    

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnItensCadastrados.Items.Clear();
        }

        private void btnTestarClasse_Click(object sender, EventArgs e)
        {
            //executando a classe pessoa 
            Pessoa ps = new Pessoa(txtNome.Text, Text, txtEmail.Text.mskTelefone.Text);

           ltbItemsCadastrados.Items.Add(ps.Nome + ps Email + ps.TelCel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaPessoas abrir = new frmBuscaPessoas();
            abrir.ShowDialog();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
    
}
