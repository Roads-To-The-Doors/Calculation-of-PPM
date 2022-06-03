using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation_of_ppm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*************************************************/

        readonly string error = "!           !";

        readonly string empty = "";

        private void ShowMessage(bool value, string message)
        {
            if (value)
            {
                MessageBox.Show(message);
            }
        }

        /*************************************************/

        private void GetAllResult(double sexs)
        {
            double _massAlc = Convert.ToDouble(massAlc.Text);

            double _procAlc = Convert.ToDouble(procAlc.Text) / 100;

            double _massBody = Convert.ToDouble(massBody.Text);

            double _result = _massAlc * _procAlc / (_massBody * sexs);

            Result.Text = Convert.ToString(Math.Round(_result, 2));
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            // Если не нажата ни одна радио-кнопка
            bool checkRadio = !Man.Checked && !Woman.Checked;

            // Если масса алкоголя ничему не равна или отрицательна
            bool massAlcNull = massAlc.Text == empty || Convert.ToDouble(massAlc.Text) <= 0;

            // Если градус алкоголя ничему не равен или отрицателен
            bool procAlcNull = procAlc.Text == empty || Convert.ToDouble(procAlc.Text) <= 0;

            // Если масса тела ничему не равна или отрицательна
            bool massBodyNull = massBody.Text == empty || Convert.ToDouble(massBody.Text) <= 0;

            // Если есть хотя бы одно нулевое значение или отрицательное
            bool resultNull = massAlcNull || procAlcNull || massBodyNull;

            if ((checkRadio) || resultNull)
            {
                Result.Text = error;
            }
            else
            {
                if (Man.Checked)
                {
                    GetAllResult(0.7);
                }
                if (Woman.Checked)
                {
                    GetAllResult(0.6);
                }
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (Result.Text != error && Result.Text != empty)
            {
                double _result = Convert.ToDouble(Result.Text);

                ShowMessage(_result < 0.3, "До 0,3 промилле – человек ведет себя адекватно, о принятом алкоголе можно догадаться лишь по характерному запаху.");

                ShowMessage(_result >= 0.3 && _result < 0.5, "0,3-0,5 – ощущение легкой эйфории.");

                ShowMessage(_result >= 0.5 && _result < 1.5, "0,5-1,5 – повышенная возбудимость, нервозность.");

                ShowMessage(_result >= 1.5 && _result < 2.5, "1,5-2,5 – заторможенность, нарушение координации движения.");

                ShowMessage(_result >= 2.5 && _result < 3, "2,5-3 – речь спутанная, человек не контролирует свои движения.");

                ShowMessage(_result >= 3 && _result <= 5, "3-5 – совершенно не реагирует на посторонних, может спать или находиться в бессознательном состоянии.");

                ShowMessage(_result > 5, "От 5 – велика возможность летального исхода.");
            }
        }
    }
}
