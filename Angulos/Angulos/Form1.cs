using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmClassificar_Click(object sender, EventArgs e)
        {
            int primeiro = int.Parse(txtangulo1.Text);
            int segundo = int.Parse(txtangulo2.Text);
            int terceiro = int.Parse(txtangulo3.Text);

            if (primeiro + segundo + terceiro != 180)
            {
                MessageBox.Show("A soma dos ângulos internos não pode ser maior que 180°!");
            }
            else if (primeiro > segundo && primeiro > terceiro)
            {
                if (primeiro > 90)
                {
                    txtresultado.Text = "Obtusângulo";
                }
                else if (primeiro == 90)
                {
                    txtresultado.Text = "Reto";
                }
                else
                {
                    txtresultado.Text = "Acutângulo";
                }
            }
            else if (segundo > primeiro && segundo > terceiro)
            {
                if (segundo > 90)
                {
                    txtresultado.Text = "Obtusângulo";
                }
                else if (segundo == 90)
                {
                    txtresultado.Text = "Reto";
                }
                else
                {
                    txtresultado.Text = "Acutângulo";
                }
            }
            else if (terceiro > primeiro && terceiro > segundo)
            {
                if (terceiro > 90)
                {
                    txtresultado.Text = "Obtusângulo";
                }
                else if (terceiro == 90)
                {
                    txtresultado.Text = "Reto";
                }
                else
                {
                    txtresultado.Text = "Acutângulo";
                }
            
                txtangulo1.Clear();
                txtangulo2.Clear();
                txtangulo3.Clear();
                txtangulo1.Focus();
            }
                }

        private void txtangulo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Insira valores inteiros!");
            }
        }

        private void txtangulo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Insira valores inteiros!");
            }
        }

        private void txtangulo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Insira valores inteiros!");
            }
        }
    }
        } 
