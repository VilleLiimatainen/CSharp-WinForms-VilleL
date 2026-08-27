using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _112
{
    public partial class Laskin : Form
    {
        Calculator _calculator;

        private List<String> _inputs;
        private List<String> _operatorInputs;

        private bool calcResult = false;
        private string _input;
        private string[] _operators = ["+", "-", "*", "/"];

        public Laskin()
        {
            InitializeComponent();
            tbNumberInputs.Clear();

            _calculator = new Calculator();
            _inputs = new List<String>();
            _operatorInputs = new List<String>();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            ButtonSwitcher(sender);
        }

        private void ButtonSwitcher(object sender)
        {
            Button pressedButton = sender as Button;
            switch (pressedButton.Name)
            {
                // Number buttons
                case "btn1":
                    UpdateInput("1");
                    break;
                case "btn2":
                    UpdateInput("2");
                    break;
                case "btn3":
                    UpdateInput("3");
                    break;
                case "btn4":
                    UpdateInput("4");
                    break;
                case "btn5":
                    UpdateInput("5");
                    break;
                case "btn6":
                    UpdateInput("6");
                    break;
                case "btn7":
                    UpdateInput("7");
                    break;
                case "btn8":
                    UpdateInput("8");
                    break;
                case "btn9":
                    UpdateInput("9");
                    break;
                case "btn0":
                    UpdateInput("0");
                    break;

                case "btnComma":
                    if (_input != "" && _input.Contains(",") == false)
                        UpdateInput(",");
                    break;


                // Operator buttons
                case "btnPlus":
                    OperatorButtonOperations("+");
                    break;
                case "btnMinus":
                    OperatorButtonOperations("-");
                    break;
                case "btnMultiply":
                    OperatorButtonOperations("*");
                    break;
                case "btnDivide":
                    OperatorButtonOperations("/");
                    break;


                // Result
                case "btnEquals":
                    if (_operatorInputs.Count > 0 && _operators.Any(x => tbNumberInputs.Text.EndsWith(x)) == false)
                    {
                        AddInputToList();
                        tbNumberInputs.Text = _calculator.DoMath(_inputs, _operatorInputs);

                        ClearListsAndInputString();
                        calcResult = true;
                    }
                    break;

                // Clear inputs and textbox
                case "btnClear":
                    tbNumberInputs.Clear();
                    ClearListsAndInputString();
                    calcResult = false;
                    break;
            }
        }

        private void UpdateInput(string n)
        {
            if (calcResult)
                tbNumberInputs.Clear();
                calcResult = false;

            tbNumberInputs.Text += n;
            _input += n;
        }

        private void OperatorButtonOperations(string operatorBtn)
        {
            if (tbNumberInputs.Text != "" && _operators.Any(x => tbNumberInputs.Text.EndsWith(x)) == false && calcResult == false)
            {
                tbNumberInputs.Text += operatorBtn;
                _operatorInputs.Add(operatorBtn);
                AddInputToList();
            }
        }

        private void AddInputToList()
        {
            _inputs.Add(_input);
            _input = "";
        }

        private void ClearListsAndInputString()
        {
            _inputs.Clear();
            _operatorInputs.Clear();
            _input = "";
        }
    }
}
