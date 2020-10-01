using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Calcular(string sexo)
		{
			double res;
			string sit = "Você está com o peso ideal";

			if ((radioFem.Checked || radioMasc.Checked) && double.TryParse(txtAltura.Text, out double altura) && double.TryParse(txtPeso.Text, out double peso))
			{
				switch (sexo)
				{
					case "Masc":
						res = (72.7 * altura) - 58;
						res = Math.Round(res, 3);
						if (peso < res) { sit = "Coma bastante massas e doces"; }
						if (peso > res) { sit = "Regime obrigatório já"; }

						txtSit.Text = sit;
						break;

					case "F":
						res = (62.1 * altura) - 44.7;
						res = Math.Round(res, 3);
						if (peso < res) { sit = "Coma bastante massas e doces"; }
						if (peso > res) { sit = "Regime obrigatório já"; }

						txtSit.Text = sit;
						break;
				}
			}
			else
			{
				MessageBox.Show("Valores inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void txtPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void txtAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void radioFem_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioMasc_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void txtSit_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			if (radioFem.Checked)
			{
				Calcular("Fem");
			}
			else {
				Calcular("Masc");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtAltura.Clear();
			txtSit.Clear();
			txtPeso.Clear();
			radioMasc.Checked = false;
			radioFem.Checked = false;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
