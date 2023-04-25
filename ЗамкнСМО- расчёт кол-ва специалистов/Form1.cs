using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ЗамкнСМО__расчёт_кол_ва_специалистов
{
    public partial class Form1 : Form
    {
        private readonly double hours = 24, month = 30;
        private double m, S, N, M, λ, n, Tp, averKaput;

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Grafik_Click(object sender, EventArgs e)
        {
            int a = 1, b = 10, h = 1, k;
            double ρ, Pk, sum, P0;
            n = Convert.ToDouble(textBox_n.Text);
            λ = Convert.ToDouble(textBox_λ.Text);
            N = Convert.ToDouble(textBox_Nh.Text);
            Tp = Convert.ToDouble(textBox_Tp.Text);
            M = Convert.ToDouble(textBox_M.Text);
            m = a;
            this.chart1.Series[0].Points.Clear();
            while (m <= b)
            {
                // Интенсивность нагрузки
                ρ = (λ / hours) * Tp;
                sum = 0;
                k = 1;
                Dictionary<int, double> probabilities = new Dictionary<int, double>();
                // Расчёт вероятностей состояний
                while (k <= n)
                {
                    if (k < m && k >= 1)
                    {
                        Pk = (Factorial(n) * Math.Pow(ρ, k)) / (Factorial(k) * Factorial(n - k)); // при k < m
                        probabilities.Add(k, Pk);
                        sum += Pk;
                        k++;
                    }
                    else
                    {
                        Pk = (Factorial(n) * Math.Pow(ρ, k)) / (Factorial(m) * Math.Pow(m, k - m) * Factorial(n - k)); // при k >= m
                        probabilities.Add(k, Pk);
                        sum += Pk;
                        k++;
                    }
                }
                // Вероятность, что ничего не сломано
                P0 = 1 / (1 + sum);
                //Среднее число оборудования в системе(на обслуживании и в очереди)
                //averKaput = P1 * 1 + P2 * 2 + P3 * 3 + P4 * 4 + ... Pk * k;
                averKaput = 0;
                for (int i = 1; i <= probabilities.Count; i++)
                {
                    averKaput += probabilities[i] * i;
                }
                //averKaput = n - (1 - P0) / ρ; // Альтернативная формула
                // Расходы S = Ср. число неисправных ЭВМ ∙ Стоимость простоя за час ∙ 24 часа ∙ 30 дней + 3 смены * кол-во работников * зарплата работника −> Поиск минимума расходов
                S = (averKaput * N * hours * month) + 3 * m * M;
                this.chart1.Series[0].Points.AddXY(m, S);
                Console.WriteLine(S);
                m += h;
            }
        }

        public double Factorial(double numb)
        {
            if (numb == 0) return 1;
            double res = 1;
            for (double i = numb; i > 1; i--)
                res *= i;
            return res;
        }

    }
}
