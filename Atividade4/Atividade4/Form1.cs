using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtRes_TextChanged(object sender, EventArgs e)
		{
            
        }

		private void btnCalc_Click(object sender, EventArgs e)
		{
            if (double.TryParse(txtLadoA.Text, out double ladoA) && double.TryParse(txtLadoB.Text, out double ladoB) && double.TryParse(txtLadoC.Text, out double ladoC))
            {
                if (Math.Abs(ladoB - ladoC) < ladoA && ladoA < ladoB + ladoC && Math.Abs(ladoA - ladoC) < ladoB && ladoB < ladoA + ladoA && Math.Abs(ladoA - ladoB) < ladoC && ladoC < ladoA + ladoB)
                {
                    if (ladoA == ladoB && ladoB == ladoC) { txtRes.Text = "Equilatero"; }
                    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC) { txtRes.Text = "Isóceles"; }
                    else { txtRes.Text = "Escaleno"; }
                }
                else
                {
                    MessageBox.Show("Não é um triangulo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

		private void btnClear_Click(object sender, EventArgs e)
		{
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtRes.Clear();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
