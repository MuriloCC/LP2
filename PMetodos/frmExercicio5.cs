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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btSorteio_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;

            if (int.TryParse(txtNumero1.Text, out num1) && int.TryParse(txtNumero2.Text, out num2))
            {
                if (num1 >= num2)
                {
                    MessageBox.Show("O primeiro número deve ser maior que o segundo!");
                }
                else
                {
                    Random rand = new Random();

                    double r = rand.Next(num1, num2);

                    MessageBox.Show("O número sorteado é: " + r.ToString()); ;
                }
            }
            else
            {
                MessageBox.Show("Dígite somente números!");
            }
        }
    }
}