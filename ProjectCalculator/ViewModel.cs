using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private string calcScreen;
        private string subScreen;
        private NumButton oneButton;
        private NumButton twoButton;
        private NumButton threeButton;
        private NumButton fourButton;
        private NumButton fiveButton;
        private NumButton sixButton;
        private NumButton sevenButton;
        private NumButton eightButton;
        private NumButton nineButton;
        private NumButton zeroButton;
        private NumButton addButton;
        private NumButton subtractButton;
        private NumButton multiplyButton;
        private NumButton divideButton;
        private EqualsButton equalsButton;
        private ClearButton clearButton;

        public ViewModel()
        {
            oneButton = new NumButton(this, "1");
            twoButton = new NumButton(this, "2");
            threeButton = new NumButton(this, "3");
            fourButton = new NumButton(this, "4");
            fiveButton = new NumButton(this, "5");
            sixButton = new NumButton(this, "6");
            sevenButton = new NumButton(this, "7");
            eightButton = new NumButton(this, "8");
            nineButton = new NumButton(this, "9");
            zeroButton = new NumButton(this, "0");
            addButton = new NumButton(this, " + ");
            subtractButton = new NumButton(this, " - ");
            multiplyButton = new NumButton(this, " * ");
            divideButton = new NumButton(this, " / ");
            equalsButton = new EqualsButton(this);
            clearButton = new ClearButton(this);
        }

        public string CalcScreen
        {
            get { return calcScreen; }
            set
            {
                calcScreen = value;
                OnPropertyChanged();
            }
        }

        public string SubScreen
        {
            get => subScreen;
            set
            {
                subScreen = value;
                OnPropertyChanged();
            }
        }

        public NumButton OneButton
        {
            get => oneButton;
            set
            {
                oneButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton TwoButton
        {
            get => twoButton;
            set
            {
                twoButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton ThreeButton
        {
            get => threeButton;
            set
            {
                threeButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton FourButton
        {
            get => fourButton;
            set
            {
                fourButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton FiveButton
        {
            get => fiveButton;
            set
            {
                fiveButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton SixButton
        {
            get => sixButton;
            set
            {
                sixButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton SevenButton
        {
            get => sevenButton;
            set
            {
                sevenButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton EightButton
        {
            get => eightButton;
            set
            {
                eightButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton NineButton
        {
            get => nineButton;
            set
            {
                nineButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton ZeroButton
        {
            get => zeroButton;
            set
            {
                zeroButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton AddButton
        {
            get => addButton;
            set
            {
                addButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton SubtractButton
        {
            get => subtractButton;
            set
            {
                subtractButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton MultiplyButton
        {
            get => multiplyButton;
            set
            {
                multiplyButton = value;
                OnPropertyChanged();
            }
        }

        public NumButton DivideButton
        {
            get => divideButton;
            set
            {
                divideButton = value;
                OnPropertyChanged();
            }
        }

        public EqualsButton EqualsButton
        {
            get => equalsButton;
            set
            {
                equalsButton = value;
                OnPropertyChanged();
            }
        }

        public ClearButton ClearButton
        {
            get => clearButton;
            set
            {
                clearButton = value;
                OnPropertyChanged();
            }
        }

        public void ConcatScreen(string addition)
        {
            CalcScreen += addition;
        }

        public void clearScreen()
        {
            CalcScreen = string.Empty;
            SubScreen = string.Empty;
        }

        public void computeString()
        {
            string calcString = calcScreen;
            DataTable dataTable = new DataTable();
            bool success;
            object answer;
            try
            {
                answer = dataTable.Compute(calcString, "");
                CalcScreen = answer.ToString();
                success = true;
            }
            catch
            {
                success = false;
            }
            if (!success)
            {
                CalcScreen = "Error!";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
