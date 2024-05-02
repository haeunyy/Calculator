using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiple,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;     
        Boolean operatorChangeFlag = false;
        double firstOperand = 0;
        double secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            // 연산 상태인 경우 기존 숫자를 지우기
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            Button button = (Button)sender;
            string strNumber = display.Text += button.Text;
            double Number = double.Parse(strNumber);
            display.Text = Number.ToString(); 
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            firstOperand = 0;
            secondOperand = 0;
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber;

            if ( display.Text == "" )
            {
                strNumber = "0.";
            } else
            {
                strNumber = display.Text += ".";
            }

            double Number = double.Parse(strNumber);
            display.Text = Number.ToString();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            (Button)sender.Text;
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void ButtonMultiple_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Multiple;
            operatorChangeFlag = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = double.Parse(display.Text);

            // 정수 범위 예외처리 해야함
            // 실수로 변경
            // 0으로 나눌수 없습니다. 후에 연산 가능 
            if( currentOperator != Operators.None )
            {
                switch ( currentOperator )
                {
                    case Operators.Add:
                        double result = firstOperand + secondOperand;
                        display.Text = result.ToString();
                        displayEx.Text = firstOperand.ToString() + " + " + secondOperand.ToString() + " = ";
                        break;
                    case Operators.Subtract:
                        firstOperand -= secondOperand;
                        display.Text = firstOperand.ToString(); 
                        break;
                    case Operators.Divide:
                        firstOperand /= secondOperand;
                        display.Text = firstOperand.ToString();
                        break;
                    case Operators.Multiple:
                        if ( secondOperand == 0 )
                        {
                            display.Text = "0으로 나눌수 없습니다. ";
                        } else
                        {
                            firstOperand *= secondOperand;
                            display.Text = firstOperand.ToString();   
                        }
                        break;
                }
            }
        }
    }
}
