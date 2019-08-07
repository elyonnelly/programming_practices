using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public double res = 0;
        Func<double, double> func = (double x) => Math.Exp(-x * x); // Функция для поиска интеграла

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { // метод Монте Карло
            double x;
            double y; // Случайная точка
            double value; 
            int square = 4; // Площадь на которой происходит интегрирование
            double entries = 0; // Кол-во попаданий под график
            int numberOfPoints = 6000; // Кол-во точек всего
            int index = 1;
            for (int i = 0; i < numberOfPoints; i++)
            {
                if (!backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress((int)(index++ * 100 / numberOfPoints));
                    x = rnd.Next(-2, 2) + rnd.NextDouble();
                    y = rnd.NextDouble();
                    value = func(x);
                    if (y < value) entries++;
                }
            }
            res = Math.Round(entries / numberOfPoints * square, 4);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { // Отслеживаем изменение процесса
            progressBar.Value = e.ProgressPercentage;
            lblProcessing.Text = $"Processing ... {e.ProgressPercentage}%";
            progressBar.Update();
            lblProcessing.Refresh();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show($"Вычисление завершено \n Результат: {res}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }
    }
}
