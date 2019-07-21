using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using twc =Treinaweb.Calculadora.Util;


namespace Calculadora.WinForms
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2 = 0;
                if (!int.TryParse(txtPrimeiroArgumento.Text, out num1))
                {
                    MessageBox.Show("O primeiro número é inválido."); 
                }

                if (!int.TryParse(txtSegundoArgumento.Text, out num2))
                {
                    MessageBox.Show("O primeiro número é inválido.");
                }

                twc.Calculadora calc = new twc.Calculadora();
                switch(cboOperacao.SelectedIndex)
                {
                    case 0:
                        txtResultado.Text = calc.Somar(num1, num2).ToString();
                        break;
                    case 1:
                        txtResultado.Text = calc.Subtrair(num1, num2).ToString();
                        break;
                    case 2:
                        txtResultado.Text = calc.Mutiplicar(num1, num2).ToString();
                        break;
                    case 3:
                        txtResultado.Text = calc.Dividir(num1, num2).ToString();
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
