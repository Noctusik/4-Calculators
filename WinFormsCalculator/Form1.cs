namespace WinFormsCalculator
{
    public enum Operation
    {
        None,
        Addition,
        Subtraction,
        Multiplication,
        Division

    }
    public partial class Form1 : Form
    {
        private string _firstValue;
        private string _secondValue;
        private bool _resultOnScreen = false;
        private Operation _currentOperation = Operation.None;
        public Form1()
        {
            InitializeComponent();
            mainBox.Text = "0";
            
        }

        private void bNumber_Click(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (mainBox.Text == "0" && clickedValue!=",")
            {
                mainBox.Text = String.Empty;
            }

            if (_resultOnScreen)
            {
                _resultOnScreen = false;
                mainBox.Text = String.Empty;
                if (clickedValue == ",")
                {
                    clickedValue = "0,";
                }
            }

            mainBox.Text += clickedValue;
            setResultButtonState(true);

            if (_currentOperation != Operation.None)
            {
                _secondValue += clickedValue;
            }
            else 
            {
                setOperationButtonState(true);                
            }
            
        }

        private void bOperation_Click(object sender, EventArgs e)
        {
            _firstValue = mainBox.Text;
            if (_resultOnScreen)
            {
                _resultOnScreen = false;
            }
            
            var clickedOperation = (sender as Button).Text;
            _currentOperation = clickedOperation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Subtraction,
                "*" => Operation.Division,
                "/" => Operation.Division,
                _ => Operation.None,
            };
            mainBox.Text += $" {clickedOperation} ";
            setOperationButtonState(false);
            setResultButtonState(false);

        }

        private void bResult_Click(object sender, EventArgs e)
        {
            if(_currentOperation == Operation.None)
            {
                return;
            }
            var firstNumber = double.Parse(_firstValue);
            var secondNumber = double.Parse(_secondValue);

            var result = Calculate(firstNumber, secondNumber);
            mainBox.Text = result.ToString();
            _secondValue = String.Empty;
            _currentOperation = Operation.None;
            _resultOnScreen = true;
            setResultButtonState(true);
            setOperationButtonState(true);

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            mainBox.Text = "0";
            _firstValue = String.Empty;
            _secondValue = String.Empty;
            _currentOperation = Operation.None;
            
        }

        private double Calculate(double firstNumber, double secondNumber)
        {
            switch (_currentOperation)
            {
                case Operation.None:
                    return firstNumber;
                    
                case Operation.Addition:
                    return firstNumber + secondNumber;
                    
                case Operation.Subtraction:
                    return firstNumber - secondNumber;
                    
                case Operation.Multiplication:
                    return firstNumber * secondNumber;
                   
                case Operation.Division:
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez 0!");
                        return 0;
                    }
                    else
                    {
                        return firstNumber / secondNumber;
                    }
                default:
                    return 0;
                    
            }
        }
        private void setOperationButtonState(bool value)
        {
            bPlus.Enabled = value;
            bMinus.Enabled = value;
            bDivide.Enabled = value;
            bMultiply.Enabled = value;
        }
        private void setResultButtonState(bool value)
        {
            bResult.Enabled = value;
        }
    }
}