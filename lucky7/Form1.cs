using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lucky7
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int saldo = 10;
        public Form1()
        {
            InitializeComponent();
        }
        private void Saldo()
        {
            label6.Text = "Saldo: " + saldo + " créditos";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (saldo >= 1)
            {
                pictureBox1.Visible = false;
                int result1 = random.Next(10);
                int result2 = random.Next(10);
                int result3 = random.Next(10);
                label3.Text = result1.ToString();
                label4.Text = result2.ToString();
                label5.Text = result3.ToString();
                // Verifica se três "7s" iguais foram sorteados
                if (result1 == 7 && result2 == 7 && result3 == 7)
                {
                    saldo += 5; // Jackpot - ganha 5 créditos
                    MessageBox.Show("Jackpot! Você ganhou 5 créditos!");
                    pictureBox1.Visible = true;
                }
                else if (result1 == 7 && result2 == 7 || result2 == 7 && result3 == 7)
                {
                    saldo += 2; // Dois "7s" iguais - ganha 2 créditos
                    MessageBox.Show("Você ganhou 2 créditos!");
                    pictureBox1.Visible = true;
                }
                else if (result1 == 7 || result2 == 7 || result3 == 7)
                {
                    saldo += 1; // Um "7" - ganha 1 crédito
                    MessageBox.Show("Você ganhou 1 crédito!");
                    pictureBox1.Visible = true;
                }
                else
                {
                    saldo -= 1; // Desconta 1 crédito por rodada
                    MessageBox.Show("Você perdeu 1 crédito. Tente novamente.");
                }
                Saldo(); // Atualiza o rótulo do saldo na interface
            }
            else
            {
                MessageBox.Show("Saldo insuficiente. Recarregue para continuar.");
                Application.Exit();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Tem a certeza que quer sair?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Verifica a escolha do usuário
            if (sair == DialogResult.Yes)
            {
                // O usuário escolheu sair, então o programa é fechado
                Application.Exit();
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}