    using System.Data;

    namespace Calculator;

    public partial class AdvancedPage : ContentPage
    {
        string currentEntry = "";
        int currentState = 1;
        string mathOperator;
        double firstNumber, secondNumber;
        string input = "";
        string decimalFormat = "N0";


        public AdvancedPage()
        {
            InitializeComponent();
            OnClearEvent(this, null);
        }

        void OnSelectNumber(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            String btnpressed = button.Text;
            if (btnpressed == "mod")
            {
                input += "%";
            }
            else if (btnpressed == "×")
            {
                input += "*";
            }
            else if (btnpressed == "÷")
            {
                input += "/";
            }
            else if (btnpressed == "%")
            {
                input += "/100";
            }
            else
            {
                input += btnpressed;
            }

            result.Text = input;
            CurrentCalculation.Text = input;
        }

    

        private void LockNumberValue(string text)
        {
            double number;
            if (double.TryParse(text, out number))
            {
                if (currentState == 1)
                {
                    firstNumber = number;
                    }
                else
                {
                    secondNumber = number;
                }


                currentEntry = string.Empty;
            }
        }

        void OnClearEvent(object sender, EventArgs e)
        {
            input = String.Empty;
            this.result.Text = "0";
            CurrentCalculation.Text = "0";
            currentEntry = string.Empty;
        }

        
    
    }
