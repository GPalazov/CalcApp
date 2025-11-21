namespace CalcApp
{

    //интерфейс за калкулатора
    public interface ICalculator
    {
        //методи за операциите в калкулатора
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }


    class Calculator: ICalculator
    {
        //метод за събиране
        public double Add(double a, double b)
        {
            return a + b;
        }

        //метод за изваждане
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        //метод за умножение
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        //метод за деление с проверка за деление на нула
        public double Divide(double a, double b)
        {
            return a / b;
        }


    }
    public partial class Form1 : Form
    {

        //конструктор на формата
        public Form1()
        {
            InitializeComponent();
        }

        //обект от класа калкулатор
        private Calculator calculator = new Calculator();


        //метод за парсване на входните данни
        private bool ParseInput(out double num1, out double num2)
        {
            bool n1 = double.TryParse(textBox1.Text, out num1);
            bool n2 = double.TryParse(textBox2.Text, out num2);
            return n1 && n2;
        }

        //event handler за събиране
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (ParseInput(out double num1, out double num2))
            {
                double result = calculator.Add(num1, num2);
                label1.Text = $"Резултат: {result}";
            }
            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
        //event handler за изваждане
        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (ParseInput(out double num1, out double num2))
            {
                double result = calculator.Subtract(num1, num2);
                label1.Text = $"Резултат: {result}";
            }
            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
        //event handler за умножение
        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (ParseInput(out double num1, out double num2))
            {
                double result = calculator.Multiply(num1, num2);
                label1.Text = $"Резултат: {result}";
            }
            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
        //event handler за деление с проверка за деление на нула
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (ParseInput(out double num1, out double num2))
            {
                if(num2 == 0)
                {
                    label1.Text = "Грешка: Деление на нула!";
                    return;
                }
                    double result = calculator.Divide(num1, num2);
                    label1.Text = $"Резултат: {result}";
       
            }
            else
            {
                label1.Text = "Грешка: Невалидни входни данни!";
            }
        }
    }
}
