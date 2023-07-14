using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAula05MaquinaDeComida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionarDinheiro_Click(object sender, EventArgs e)
        {
            Form2 adicionarDinheiro = new Form2();
            adicionarDinheiro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarNOVOSaldo_Click(object sender, EventArgs e)
        {
            double saldo;
            double valor;

            valor = Double.Parse(txtParaAdicionarNOVOSaldo.Text); //Caixinha de texto
            saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));  // É ONDE TA O R$ e converte em numero

            double resultado = saldo + valor;
            lblSaldo.Text = $"R$: {resultado}";
        }

        private void btnPipocaDoce_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 7;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = - valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void btcPipocaSalgada_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 11;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = - valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void btnSalgadinho_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 3;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = - valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Danoninho_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 7;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Bolacha_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 3;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Floquinhos_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 11;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void suco_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 3;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void todinho_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 3;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void nesquik_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 3;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void ovomaltine_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 3;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void batata_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 11;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Fruta_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 11;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Salada_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 11;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void feijao_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 11;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Moqueca_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 7;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Acarajé_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 7;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Tacacá_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 7;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }

        private void Arroz_Click(object sender, EventArgs e)
        {
            double valorDoProduto = 7;
            if (Double.Parse(lblSaldo.Text.Replace("R$:", "")) >= valorDoProduto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$:", ""));
                double consumo = -valorDoProduto; //VALOR DO PRODUTO TEM QUE TER O MENOS PARA SUBTRAIR


                //double valor = 0;
                //double resultado = saldo + valor;
                double resultado = saldo + consumo;
                lblSaldo.Text = $"R$: {resultado}";
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente!");
                MessageBox.Show("SEU POBRE!");
            }
        }
    }
}
