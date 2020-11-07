using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btNumericos_Click(object sender, EventArgs e)
        {
            int numeros = 0;

            for (int i = 0; i < rchTxt.Text.Length; i++)
            {
                if (Char.IsNumber(Convert.ToChar(rchTxt.Text[i])))
                {
                    numeros++;
                }
            }

            MessageBox.Show("A quantidade de números é: " + numeros.ToString());
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            int i = 0;
            int posBranco = 0;

            while (i < rchTxt.Text.Length)
            {
                if (char.IsWhiteSpace(rchTxt.Text[i]))
                {
                    posBranco = i;
                    break;
                }

                i++;
            }

            MessageBox.Show("O primeiro espaço em branco está na posição " + posBranco.ToString());
        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (char chara in rchTxt.Text)
            {
                if (char.IsLetter(chara))
                {
                    i++;
                }
            }

            MessageBox.Show("O texto tem " + i.ToString() + " caracteres alfabéticos");
        }
    }
}