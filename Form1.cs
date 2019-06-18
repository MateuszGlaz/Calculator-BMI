using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bmi(object sender, EventArgs e)
        {
            int waga, wzrost, bmi;
            waga = int.Parse(textBox1.Text);
            wzrost = int.Parse(textBox2.Text);
            bmi = (waga * 10000) / (wzrost * wzrost);
            if (bmi < 18.5)
            {
                label4.Text = "niedowaga";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                label4.Text = "Normalne";
            }
            else if (bmi > 25 && bmi < 29.9)
            {
                label4.Text = "Nadwaga";
            }
            else if (bmi > 30)
            {
                label4.Text = "Otylosc";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            int waga, wzrost, bmi;
            waga = int.Parse(textBox1.Text);
            wzrost = int.Parse(textBox2.Text);
            bmi = (waga * 10000) / (wzrost * wzrost);
            
            
                if (bmi < 18.5)
                {
                    label5.Text = "Masz niedowagę. Zacznij spożywać posiłki regularnie przynajmniej 5 razy w tygodniu. Spożywaj owoce warzywa " +
                        "oraz dbaj o nawodnienie organizmu. Pamiętaj że aktywność fizyczna może pomóc pobudzając apetyt.";
                }
                else if (bmi > 18.5 && bmi < 24.9)
                {
                    label5.Text = "Masz prawidłową wagę. Nie spoczywaj jednak na laurach i dbaj o swoje zdrowie regularnie";
                }
                else if (bmi > 25 && bmi < 29.9)
                {
                    label5.Text = "Masz nadwagę. Postaraj się ograniczyć ilość pożywienia oraz zacznij częściej uprawiać sport";
                }
                else if (bmi > 30)
                {
                    label5.Text = "Masz znacznie za duza mase ciala. Zglos sie do lekarza";
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.znanylekarz.pl/dietetyk/rzeszow");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://toczytam.pl/dlaczego-warto-dbac-o-zdrowie/");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = "Dziekujemy za przekazanie nam swojej opinii";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
