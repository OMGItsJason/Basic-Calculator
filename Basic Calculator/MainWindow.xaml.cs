using System;
using System.Windows;
using CalculatorPrivateAssembly;

namespace Basic_Calculator
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            string[] _operators = new string[]
            {
                "+",
                "-",
                "*",
                "/"
            };
            for (int o = 0; o < 4; o++)
            {
                CbOperators.Items.Add(_operators[o].ToString());
            }
        }

        private void CalculateBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string selectedOperator = CbOperators.SelectedItem as string;

            float operandOne = float.Parse(OperandOne.Text);
            float operandTwo = float.Parse(OperandTwo.Text);
            float result = 0;

            switch (selectedOperator)
            {
                case "+":
                    result = BasicComputation.Addition(operandOne, operandTwo);
                    break;
                case "-":
                    result = BasicComputation.Subtraction(operandOne, operandTwo);
                    break;
                case "*":
                    result = BasicComputation.Multiplication(operandOne, operandTwo);
                    break;
                case "/":
                    result = BasicComputation.Division(operandOne, operandTwo);
                    break;
                default:
                    MessageBox.Show("Invalid");
                    break;
            }

            Total.Text = result.ToString();
        }
    }
}