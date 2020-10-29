using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MaquinaCafeVirtual
{
    public partial class FrmMaquinaCafeVirtual : Form
    {
        //COMENTÁRIO 2 TESTE GITHUB
        public FrmMaquinaCafeVirtual()
        {
            InitializeComponent();
        }

        List<double> moedasInativas = new List<double>(); //lista das moedas que não podem se inseridas devido a problema na leitora

        protected double totalMoedasInseridas;
        protected double totalTroco;

        #region preço das bebidas
        protected double precoCappuccino = 3.50;
        protected double precoMocha = 4.00;
        protected double precoCafeComLeite = 3.00;
        #endregion

        #region valor das moedas
        protected double moeda1Centavo = 0.01; 
        protected double moeda5Centavos = 0.05;
        protected double moeda10Centavos = 0.10;
        protected double moeda25Centavos = 0.25;
        protected double moeda50Centavos = 0.50;
        protected double moeda1Real = 1.00;
        #endregion

        bool flagOptionSelected = false; //flag para identificar opçao da bebida já selecionada

        private void FrmMaquinaCafeVirtual_Load(object sender, EventArgs e)
        {
            //lista das moedas que não podem se inseridas devido a problema na leitora
            moedasInativas.Add(0.01);
            moedasInativas.Add(0.05);

            Inicial();
        }

        public void Inicial()
        {
            txtTotalMoedaInserida.Text = 0.00.ToString("C2");
            txtTroco.Text = 0.00.ToString("C2");
        }

        private void btn1Centavo_Click(object sender, EventArgs e)
        {
            moedaInserida(moeda1Centavo);
        }
  
        private void btn5Centavos_Click(object sender, EventArgs e)
        {
            moedaInserida(moeda5Centavos);
        }
        
        private void btn10Centavos_Click(object sender, EventArgs e)
        {
            moedaInserida(moeda10Centavos);
        }

        private void btn25Centavos_Click(object sender, EventArgs e)
        {
            moedaInserida(moeda25Centavos);
        }

        private void btn50Centavos_Click(object sender, EventArgs e)
        {
            moedaInserida(moeda50Centavos);
        }

        private void btn1Real_Click(object sender, EventArgs e)
        {
            moedaInserida(moeda1Real);
        }
       
        public void moedaInserida(double valorMoedaInserida)
        {
            if (moedasInativas.Contains(valorMoedaInserida)) //validação para moeda rejeitada selecionada
            {
                MessageBox.Show("Moeda rejeitada, por favor selecione outra opção.", "Problema na leitora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalMoedasInseridas = totalMoedasInseridas + valorMoedaInserida;
                txtTotalMoedaInserida.Text = totalMoedasInseridas.ToString("C2");
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            totalMoedasInseridas = new double();
            totalTroco = new double();
            txtTotalMoedaInserida.Text = txtTroco.Text = string.Empty;
            Inicial();
            flagOptionSelected = false;
        }

        
        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            BebidaSelecionada(precoCappuccino);
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            BebidaSelecionada(precoMocha);
        }

        private void btnCafeComLeite_Click(object sender, EventArgs e)
        {
            BebidaSelecionada(precoCafeComLeite);
        }

        private void BebidaSelecionada(double priceDrink)
        {
            if (flagOptionSelected)
            {
                MessageBox.Show("Clique em Novo Pedido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (totalMoedasInseridas >= priceDrink)
            {
                totalTroco = totalMoedasInseridas - priceDrink;
                if (totalMoedasInseridas != 0.00)
                {
                    txtTroco.Text = totalTroco.ToString("C2");
                    MessageBox.Show("Compra realizada com sucesso. Obrigada por utilizar nossos serviços.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagOptionSelected = true;
                }
            }
            else
            {
                MessageBox.Show("Dinheiro insuficiente. Selecione outra opção ou insira mais moedas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
