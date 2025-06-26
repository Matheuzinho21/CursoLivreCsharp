using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
  
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            
        }
//instanciar a classe conta 
            Conta conta= new Conta();
        private int i;

        private void btnConta_Click(object sender, EventArgs e)
        {
            
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conta.Valor = 1500.00;
            MessageBox.Show("Valor da sua conta:" + conta.Valor);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Valor = Convert.ToDouble(txtValor.Text);

            double[] saldo = new double[10];

            for (int i = 0; i < saldo.Length; i++) {
                }
                {
                saldo[i] = conta.depositar(saldo[i]);
                }
              
                for(int i = 0; i < saldo.Length; ++i) {

                ltbExtrato.Items.Add("R$" + saldo[i]);

           
        }
    }

        private void btnConta_Click_1(object sender, EventArgs e)
        {
            Poupanca poupanca  = new Poupanca();
            
        }
    }
    }
