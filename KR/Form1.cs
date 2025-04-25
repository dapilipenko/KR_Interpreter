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
            try
            {
                PolishInverseReselt.Text = Fraction.Instance.GetConvertToPolishInverseEntry(input.Text).ToString();
                resultLabel.Text = Fraction.Instance.Calculate(PolishInverseReselt.Text).ToString();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Помилка! Аргумент відсутній");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Помилка! Операція не дійсна");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Помилка! Індекс вийшов за межі списку");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}   