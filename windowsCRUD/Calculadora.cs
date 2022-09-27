using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsCRUD
{
    public partial class Calculadora : Form
    {
        double primero,segundo;
        string operador;
        
        public Calculadora()
        {
            InitializeComponent();
        }

        ClasesCalculadora.clsSuma obj = new ClasesCalculadora.clsSuma();
        ClasesCalculadora.clsResta obj2 = new ClasesCalculadora.clsResta();
        ClasesCalculadora.clsPorcentaje obj3 = new ClasesCalculadora.clsPorcentaje();
        ClasesCalculadora.clsMultiplicar obj4 = new ClasesCalculadora.clsMultiplicar();
        ClasesCalculadora.clsDividir obj5 = new ClasesCalculadora.clsDividir();

        private void btnValor0_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void btnValor1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void btnValor2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void btnValor3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void btnValor4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void btnValor5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void btnValor6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void btnValor9_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void btnValor8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void btnValor7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "7";
        }

       

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnPorcen_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtScreen.Text);
            double Sum,Res,Mul,Div,Porc;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    txtScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Resta((primero), (segundo));
                    txtScreen.Text = Res.ToString();
                    break;
                case "%":
                    Porc = obj3.Porcen((primero), (segundo));
                    txtScreen.Text = Porc.ToString();
                    break;
                case "*":
                    Mul = obj4.multiplicar((primero), (segundo));
                    txtScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj5.dividir((primero), (segundo));
                    txtScreen.Text = Div.ToString();
                    break;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }



    }
}
