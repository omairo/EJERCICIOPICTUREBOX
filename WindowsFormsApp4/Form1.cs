using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private double valorhoras;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcularsalario_Click(object sender, EventArgs e)
        {
            double horastrabajadas = double.Parse(txthorastrabajadas.Text);
            double valorhora = double.Parse(txtvalorhoras.Text);
            double total = horastrabajadas * valorhoras;

            if (total>750000) {

                MessageBox.Show("el empleado gana mas del minimo");
                lbltotalsalario.Text = total.ToString();
                lbltotalsalario.Visible = true;

            
            else {

                    total = (total * 0.20) + total;

                    lbltotalsalario.Text = total.ToString();
                    lbltotalsalario.Visible=true
        }
    }
}
    }
