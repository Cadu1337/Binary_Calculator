using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n1, n2, result;
        Boolean Apresenta;
        string Count;

        private void Botão_0(object sender, EventArgs e){
            if (Apresenta == true){
                Conta.Text = Conta.Text + "0";

                Apresenta = false;
            }
            else if (Apresenta == false){
                Conta.Text = Conta.Text + "0";
            }
        }

        private void Botão_1(object sender, EventArgs e){
            if (Apresenta == true){
                Conta.Text = Conta.Text + "1";

                Apresenta = false;
            }
            else if (Apresenta == false){
                Conta.Text = Conta.Text + "1";
            }
        }

        private void Soma(object sender, EventArgs e){
            Count = "+";
            n1 = Convert.ToInt32(Conta.Text, 2);
            Conta.Clear();
        }

        private void Subtração(object sender, EventArgs e){
            Count = "-";
            n1 = Convert.ToInt32(Conta.Text, 2);
            Conta.Clear();
        }

        private void Multiplicação(object sender, EventArgs e){
            Count = "*";
            n1 = Convert.ToInt32(Conta.Text, 2);
            Conta.Clear();
        }

        private void Divisão(object sender, EventArgs e){
            Count = "/";
            n1 = Convert.ToInt32(Conta.Text, 2);
            Conta.Clear();
        }

        private void Igual(object sender, EventArgs e){
            n2 = Convert.ToInt32(Conta.Text, 2);
            switch (Count){
                case "+":
                    result = n1 + n2;

                    break;

                case "-":
                    result = n1 - n2;
                    break;

                case "*":
                    result = n1 * n2;
                    break;

                case "/":
                    result = n1 / 2;
                    break;
            }

            int Ndecimal = int.Parse(result.ToString());
            
            int remainder;
            
            string resultado_ = string.Empty;

            while (Ndecimal > 0){
                remainder = Ndecimal % 2;
                Ndecimal /= 2;
                resultado_ = remainder.ToString() + resultado_;
            }
            Resultado.Text = resultado_;
        }

        private void BinárioParaDecimal(object sender, EventArgs e){
            BinárioDecimal.Text = Convert.ToInt64(Convert.ToInt64(BinárioDecimal.Text, 2)).ToString();
        }

        private void HexacimalParaDecimal(object sender, EventArgs e){
            string Hey = Convert.ToInt64(HexadecimalDecimal.Text, 2).ToString();
            int decValue = Convert.ToInt32(Hey);
            string HexValue = decValue.ToString("X");
            HexadecimalDecimal.Text = HexValue;
        }
 
    }
}
