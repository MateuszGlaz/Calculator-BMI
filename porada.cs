int waga, wzrost, bmi;
            waga = int.Parse(textBox1.Text);
            wzrost = int.Parse(textBox2.Text);
            bmi = (waga * 10000) / (wzrost * wzrost);
            if (bmi < 18.5)
            {
                label5.Text = "Masz niedowage. Zacznij spozywac regularnie posilki oraz uprawiac sport.";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                label5.Text = "Maz odpowiednia mase cial. Nie spoczywaj jednak na laurach i dbaj regularnie o zdrowie";
            }
            else if (bmi > 25 && bmi < 29.9)
            {
                label5.Text = "Masz nadwage. Doloz wiecej ruchu do swojego codziennego dnia oraz unikaj jedzenia przed snem";
            }
            else if (bmi > 30)
            {
                label5.Text = "Masz zdecydowanie za duza mase ciala. Zglos sie do lekarza";
            }
