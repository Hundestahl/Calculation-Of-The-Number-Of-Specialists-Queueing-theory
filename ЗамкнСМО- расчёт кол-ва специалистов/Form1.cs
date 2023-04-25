using System;
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
            double a = 1, b = 10, h = 1;
            double ρ, Pk, k, sum, P0;
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
                double P1 = 0, P2 = 0, P3 = 0, P4 = 0, P5 = 0, P6 = 0, P7 = 0;
                // Расчёт вероятностей состояний
                while (k <= n)
                {
                    if (k < m && k >= 1)
                    {
                        Pk = (Factorial(n) * Math.Pow(ρ, k)) / (Factorial(k) * Factorial(n - k)); // при k < m
                        switch (k)
                        {
                            case 1:
                                P1 = Pk;
                                break;
                            case 2:
                                P2 = Pk;
                                break;
                            case 3:
                                P3 = Pk;
                                break;
                            case 4:
                                P4 = Pk;
                                break;
                            case 5:
                                P5 = Pk;
                                break;
                            case 6:
                                P6 = Pk;
                                break;
                            case 7:
                                P7 = Pk;
                                break;
                        }
                        sum += Pk;
                        k++;
                    }
                    else
                    {
                        Pk = (Factorial(n) * Math.Pow(ρ, k)) / (Factorial(m) * Math.Pow(m, k - m) * Factorial(n - k)); // при k >= m
                        switch (k)
                        {
                            case 1:
                                P1 = Pk;
                                break;
                            case 2:
                                P2 = Pk;
                                break;
                            case 3:
                                P3 = Pk;
                                break;
                            case 4:
                                P4 = Pk;
                                break;
                            case 5:
                                P5 = Pk;
                                break;
                            case 6:
                                P6 = Pk;
                                break;
                            case 7:
                                P7 = Pk;
                                break;
                        }
                        sum += Pk;
                        k++;
                    }
                }
                // Вероятность, что ничего не сломано
                P0 = 1 / (1 + sum);
                //Среднее число оборудования в системе(на обслуживании и в очереди)
                averKaput = P1 * 1 + P2 * 2 + P3 * 3 + P4 * 4 + P5 * 5 + P6 * 6 + P7 * 7;
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