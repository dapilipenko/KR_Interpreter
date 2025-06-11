using System;
using System.Windows.Forms;

namespace KR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetResult(object sender, EventArgs e)
        {
            if (input.Text.Length == 0) return;
            try
            {
                int digits = 0;
                if (roundType.SelectedItem != null)
                {
                    int.TryParse((roundType.SelectedItem.ToString()), out digits);

                }
                double result = Fraction.Instance.Calculate(Fraction.Instance.GetConvertToPolishInverseEntry(input.Text).ToString());
                resultLabel.Text = "Результат: " + Math.Round(result, digits).ToString();
                listBox.Items.Add(input.Text + " = " + resultLabel.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Помилка! Аргумент відсутній");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Помилка! Некоректний ввід: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Помилка! Операція не дійсна: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($"Помилка! {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Невідома помилка: {ex.Message}");
            }
        }
         private void clearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
        private void roundType_SelectedValueChanged(object sender, EventArgs e)
        {
            GetResult(sender, e);
        }
    }
}