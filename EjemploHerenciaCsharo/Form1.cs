using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploHerenciaCsharo
{
    public partial class Form1 : Form
    {
        Fibonacci fibonacci = new Fibonacci();
        Factorial factorial = new Factorial();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
        

            fibonacci.setNumero( long.Parse(txtNumero.Text));

            foreach ( long valores in fibonacci.calcularFibonacci()){
                ltbLista.Items.Add(valores);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ltbLista.Items.Clear();
            txtNumero.Clear();
            txtNumero.Focus();
            lblFactorial.Visible = false;
        }

        private void btbCalcularFactorial_Click(object sender, EventArgs e)
        {
            factorial.setNumero(long.Parse(txtNumero.Text));
            lblFactorial.Visible = true;
            lblFactorial.Text = Convert.ToString(factorial.calcularFactorial());
        }
    }
}
