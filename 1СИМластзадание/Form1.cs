using System;
using System.Globalization;
using System.Windows.Forms;

namespace MathExpressionCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                // Парсинг входных значений
                double a = double.Parse(txtA.Text.Replace(".", ","), CultureInfo.GetCultureInfo("ru-RU"));
                double b = double.Parse(txtB.Text.Replace(".", ","), CultureInfo.GetCultureInfo("ru-RU"));
                // Вычисление результата
                double result = Calculator.Calculate(a, b);
                txtResult.Text = result.ToString("0.###");
            }
            catch (FormatException)
            {
                errorProvider.SetError(txtA, "Некорректный формат числа");
                errorProvider.SetError(txtB, "Некорректный формат числа");
                MessageBox.Show("Введите числа в правильном формате (например: 4,29)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}