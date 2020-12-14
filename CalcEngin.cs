using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calculator;

namespace SimpleCalculator
{
    public partial class CalcEngin : SimpleCalculator.CalcUI
    {
        public CalcEngin()
        {
            InitializeComponent();
        }     

        private void CalcEngin_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button5, "Факториал числа");
            toolTip1.SetToolTip(this.button6, "Извлечение кубического корня");
            toolTip1.SetToolTip(this.button1, "Возведение числа в степень");
            toolTip1.SetToolTip(this.button2, "Извлечение квадратного корня");
            toolTip1.SetToolTip(this.button3, "Расчет обратного значения");
            toolTip1.SetToolTip(this.button4, "Определение квадрата числа");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePower);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSqrt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eInverse);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSquareDegree);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eCubeRoot);
        }
    }
}
