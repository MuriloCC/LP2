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
    public partial class frmExercici2 : Form
    {
        public frmExercici2()
        {
            InitializeComponent();
        }

       

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int lenTxt2 = txtPal2.Text.Length/2;

            txtPal2.Text = txtPal2.Text.Substring(0, lenTxt2) + txtPal1.Text + txtPal2.Text.Substring(lenTxt2);
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int lenTxt1 = txtPal1.Text.Length/2;

            txtPal2.Text = txtPal1.Text.Insert(lenTxt1, "**");
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPal1.Text, txtPal2.Text) == 0)
            {
                MessageBox.Show("Palavras são iguais.");
            }
            else
            {
                MessageBox.Show("Palavras são diferentes");
            }
        }
    }
}