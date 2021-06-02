using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        Statistical_processing SP = new Statistical_processing();
        public Form1()
        {
            InitializeComponent();
        }
        private void start_Click(object sender, EventArgs e)
        {
            double p1 = (double)par1.Value;
            double p2 = p1 * (1 - p1);
            double p3 = p2 * (1 - p1);
            double p4 = p3 * (1 - p1);
            double[] prob = new double[4] { p1, p2, p3, p4 };
            double N = (double)number.Value;
            double[] freq = new double[4] { 0, 0, 0, 0 };
            double[] stat = new double[4] { 0, 0, 0, 0 };
            for (int i = 1; i <= (int)N; i++)
            {
                double value = SP.GetData(p1);
                if (value == 0)
                {
                    stat[0]++;
                }
                if (value == 1)
                {
                    stat[1]++;
                }
                if (value == 2)
                {
                    stat[2]++;
                }
                if (value > 2)
                {
                    stat[3]++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                freq[i] = stat[i] / (double)number.Value;
            }

            int[] X = new int[4] { 0, 1, 2, 3 };
            chart1.Series["Series1"].Points.DataBindXY(X, freq);

            double math_ave = 0;
            double average = 0;

            double[] events = new double[4] { 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                math_ave += (double)prob[i] * events[i];
                average += (double)freq[i] * events[i];
            }

            double math_var = 0;
            double variance = 0;
            for (int i = 0; i < 4; i++)
            {
                math_var += (double)prob[i] * Math.Pow((events[i] - math_ave), 2);
                variance += (double)freq[i] * Math.Pow((events[i] - average), 2);
            }

            double error_ave = Math.Abs(((math_ave - average) / math_ave) * 100);
            double error_var = Math.Abs(((math_var - variance) / math_var) * 100);

            Average.Text = Math.Round(average, 3).ToString();
            Variance.Text = Math.Round(variance, 3).ToString();
            Ave_err.Text = " (error = " + Math.Round(error_ave, 2).ToString() + "%)";
            Var_err.Text = " (error = " + Math.Round(error_var, 2).ToString() + "%)";
            double chi_square = 0;
            double chi_square_norm = 9.488;

            for (int i = 0; i < 3; i++)
            {
                chi_square += Math.Pow(stat[i] - N * prob[i], 2) / (N * prob[i]);
            }

            if (chi_square > chi_square_norm)
            {
                Chi_squared.Text = Math.Round(chi_square, 3).ToString() + " > " + chi_square_norm.ToString();
                label7.Text = "Гипотеза неверна";
            }
            else
            {

                Chi_squared.Text = Math.Round(chi_square, 3).ToString() + " <= " + chi_square_norm.ToString();
                label7.Text = "Гипотеза верна";
            }

        }
    }
    public class Statistical_processing
    {
        Random rng = new Random();
        public int GetData(double p)
        {
            double alpha = rng.NextDouble();
            double x = Math.Log(alpha) / Math.Log(1 - p);
            return (int)x;
        }
    }
}
