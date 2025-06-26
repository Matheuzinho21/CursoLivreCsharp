using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Padaria
{
    public partial class frmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        private object btnEnter;

        public frmLogin()
        {
            InitializeComponent();
        }

        public object MessagemBoxDefaultButton { get; private set; }
        public object MessagemBoxButtons { get; private set; }
        public object MessagemBoxIcon { get; private set; }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            //realizando as validações
            if (usuario.Equals("senac") && senha.Equals("senac")) ;
            
                frmMenuPrincipal abirir = new frmMenuPrincipal();
                abirir.Show();
                this.Hide();

            MessageBox.Show("Usuário ou senha  inválidos !");

            txtUsuario.Clear();
            txtSenha.Text="";
            txtUsuario.Focus();


            }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtSenha.Focus();
                
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmEntrar.Focus();
            }
                
        }

        private void btnEntrar(object sender, EventArgs e)
        {

        }
    }
    }

