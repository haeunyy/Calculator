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
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            // 연산 상태인 경우 기존 숫자를 지우기
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }


        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if ( operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
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
             
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void ButtonMultiple_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Multiple;
            operatorChangeFlag = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);

            // 정수 범위 예외처리 해야함
            // 실수로 변경
            // 0으로 나눌수 없습니다. 후에 연산 가능 
            if( currentOperator != Operators.None )
            {
                switch ( currentOperator )
                {
                    case Operators.Add:
                        firstOperand += secondOperand;
                        display.Text = firstOperand.ToString();
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
