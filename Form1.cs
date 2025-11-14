namespace CalcApp
{
    public partial class Form1 : Form
    {

        //конструктор на формата
        public Form1()
        {
            InitializeComponent();
        }

        //метод за парсване на входните данни
        private bool ParseInput(out double num1, out double num2)
        {
            bool n1 = double.TryParse(textBox1.Text, out num1);
            bool n2 = double.TryParse(textBox2.Text, out num2);
            return n1 && n2;
        }

        //event handler за математическата операция събиране
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if(ParseInput(out double num1, out double num2))
            {
                double result = num1 + num2;
                label1.Text = $"Резултат: {result}";
            }
            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
        //event handler за математическата операция изваждане
        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (ParseInput(out double num1, out double num2))
            {
                double result = num1 - num2;
                label1.Text = $"Резултат: {result}";
            }
            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
        //event handler за математическата операция умножение
        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (ParseInput(out double num1, out double num2))
            {
                double result = num1 * num2;
                label1.Text = $"Резултат: {result}";
            }
            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
        //event handler за математическата операция деление с проверка за деление на нула
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (ParseInput(out double num1, out double num2))
            {
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    label1.Text = $"Резултат: {result}";
                }
                else
                {
                    label1.Text = "Грешка: Деление на нула!";
                }
            }

            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
    }
}
