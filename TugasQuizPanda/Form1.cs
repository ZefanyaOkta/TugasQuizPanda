using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasQuizPanda
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            //hanya bisa huruf kecil
            string kalimat = textBoxKalimat.Text;
            string hurufawal = textBoxHurufAwal.Text;
            if (hurufawal == "a")
            {
                hurufawal = "1";
            }
            else if (hurufawal == "b")
            {
                hurufawal = "2";
            }
            else if (hurufawal == "c")
            {
                hurufawal = "3";
            }
            else if (hurufawal == "d")
            {
                hurufawal = "4";
            }
            else if (hurufawal == "e")
            {
                hurufawal = "5";
            }
            else if (hurufawal == "f")
            {
                hurufawal = "6";
            }
            else if (hurufawal == "g")
            {
                hurufawal = "7";
            }
            else if (hurufawal == "h")
            {
                hurufawal = "8";
            }
            else if (hurufawal == "i")
            {
                hurufawal = "9";
            }
            else if (hurufawal == "j")
            {
                hurufawal = "10";
            }
            else if (hurufawal == "k")
            {
                hurufawal = "11";
            }
            else if (hurufawal == "l")
            {
                hurufawal = "12";
            }
            else if (hurufawal == "m")
            {
                hurufawal = "13";
            }
            else if (hurufawal == "n")
            {
                hurufawal = "14";
            }
            else if (hurufawal == "o")
            {
                hurufawal = "15";
            }
            else if (hurufawal == "p")
            {
                hurufawal = "16";
            }
            else if (hurufawal == "q")
            {
                hurufawal = "17";
            }
            else if (hurufawal == "r")
            {
                hurufawal = "18";
            }
            else if (hurufawal == "s")
            {
                hurufawal = "19";
            }
            else if (hurufawal == "t")
            {
                hurufawal = "20";
            }
            else if (hurufawal == "u")
            {
                hurufawal = "21";
            }
            else if (hurufawal == "v")
            {
                hurufawal = "22";
            }
            else if (hurufawal == "w")
            {
                hurufawal = "23";
            }
            else if (hurufawal == "x")
            {
                hurufawal = "24";
            }
            else if (hurufawal == "y")
            {
                hurufawal = "25";
            }
            else if (hurufawal == "z")
            {
                hurufawal = "26";
            }

            string hurufakhir = textBoxHurufAkhir.Text;
            if (hurufakhir == "a")
            {
                hurufakhir = "1";
            }
            else if (hurufakhir == "b")
            {
                hurufakhir = "2";
            }
            else if (hurufakhir == "c")
            {
                hurufakhir = "3";
            }
            else if (hurufakhir == "d")
            {
                hurufakhir = "4";
            }
            else if (hurufakhir == "e")
            {
                hurufakhir = "5";
            }
            else if (hurufakhir == "f")
            {
                hurufakhir = "6";
            }
            else if (hurufakhir == "g")
            {
                hurufakhir = "7";
            }
            else if (hurufakhir == "h")
            {
                hurufakhir = "8";
            }
            else if (hurufakhir == "i")
            {
                hurufakhir = "9";
            }
            else if (hurufakhir == "j")
            {
                hurufakhir = "10";
            }
            else if (hurufakhir == "k")
            {
                hurufakhir = "11";
            }
            else if (hurufakhir == "l")
            {
                hurufakhir = "12";
            }
            else if (hurufakhir == "m")
            {
                hurufakhir = "13";
            }
            else if (hurufakhir == "n")
            {
                hurufakhir = "14";
            }
            else if (hurufakhir == "o")
            {
                hurufakhir = "15";
            }
            else if (hurufakhir == "p")
            {
                hurufakhir = "16";
            }
            else if (hurufakhir == "q")
            {
                hurufakhir = "17";
            }
            else if (hurufakhir == "r")
            {
                hurufakhir = "18";
            }
            else if (hurufakhir == "s")
            {
                hurufakhir = "19";
            }
            else if (hurufakhir == "t")
            {
                hurufakhir = "20";
            }
            else if (hurufakhir == "u")
            {
                hurufakhir = "21";
            }
            else if (hurufakhir == "v")
            {
                hurufakhir = "22";
            }
            else if (hurufakhir == "w")
            {
                hurufakhir = "23";
            }
            else if (hurufakhir == "x")
            {
                hurufakhir = "24";
            }
            else if (hurufakhir == "y")
            {
                hurufakhir = "25";
            }
            else if (hurufakhir == "z")
            {
                hurufakhir = "26";
            }

            int oper = Convert.ToInt32(hurufakhir) - Convert.ToInt32(hurufawal);
            labelHasilKalimat.Text = Convert.ToString(oper);
            string kal = string.Empty;

            for (int i = 0; i < kalimat.Length; i++)
            {
                char panda = kalimat[i];
                panda = (char)(panda + oper);
                if (Char.IsWhiteSpace(kalimat[i]))
                {
                    panda = ' ';
                }
                else if (panda > 'z')
                {
                    panda = (char)(panda - 26);
                }
                else if (panda < 'a')
                {
                    panda = (char)(panda + 26);
                }
                kal = kal + panda;
            }
            labelHasilKalimat.Text = kal;

        }
    }
}
