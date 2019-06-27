int waga, wzrost, bmi;
            waga = int.Parse(textBox1.Text);
            wzrost = int.Parse(textBox2.Text);
            bmi = (waga * 10000) / (wzrost * wzrost);
            if (bmi < 18.5)
            {
                label4.Text = "Niedowaga";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                label4.Text = "Normalna";
            }
            else if (bmi > 25 && bmi < 29.9)
            {
                label4.Text = "Nadwaga";
            }
            else if (bmi > 30)
            {
                label4.Text = "Otylosc";
            }
