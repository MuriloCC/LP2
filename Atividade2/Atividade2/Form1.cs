using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void calculo(string Tipo)
		{
			double num1, num2, Res;

			if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
			{
				switch (Tipo)
				{
					case "add":
						Res = num1 + num2;
						txtRes.Text = Res.ToString();
						break;

					case "sub":
						Res = num1 - num2;
						txtRes.Text = Res.ToString();
						break;

					case "mult":
						Res = num1 * num2;
						txtRes.Text = Res.ToString();
						break;

					case "div":
						Res = num1 / num2;
						txtRes.Text = Res.ToString();
						break;
				}
			}
			else
			{
				MessageBox.Show("Valores inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void txtNum1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtNum2_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtRes_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			calculo("add");
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			calculo("sub");
		}

		private void btnMult_Click(object sender, EventArgs e)
		{
			calculo("mult");
		}

		private void btnDiv_Click(object sender, EventArgs e)
		{
			calculo("div");
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtRes.Clear();
			txtNum1.Clear();
			txtNum2.Clear();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
