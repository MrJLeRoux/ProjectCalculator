using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectCalculator
{
    abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter) => true;

        public abstract void Execute(object parameter);
    }

    internal class NumButton : Command
    {
        ViewModel _vm;
        string add;
        public NumButton(ViewModel vm, string addition)
        {
            _vm = vm;
            add = addition;
        }

        public override void Execute(object parameter)
        {
            _vm.ConcatScreen(add);
        }
    }

    internal class EqualsButton : Command
    {
        ViewModel _vm;

        public EqualsButton(ViewModel vm)
        {
            _vm = vm;
        }

        public override void Execute(object parameter)
        {
            _vm.computeString();
        }
    }

    internal class ClearButton : Command
    {
        ViewModel _vm;

        public ClearButton(ViewModel vm)
        {
            _vm = vm;
        }

        public override void Execute(object parameter)
        {
            _vm.clearScreen();
        }
    }

}
