using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFCalculator.Commands;

namespace WPFCalculator.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {


        private string _screenVal;
        private List<string> _avaibleOperations = new List<string> { "+", "-", "*", "/" };
        private DataTable _dataTable = new DataTable();
        private bool _isLastSignOperation;
        public MainViewModel()
        {
            ScreenVal = "0";
            AddNumberCommand = new RelayCommand(AddNumber);
            AddOperationCommand = new RelayCommand(AddOperation, CanAddOpeation);
            GetResultCommand = new RelayCommand(GetResult, CanGetResult);
            ClearScreenCommand = new RelayCommand(ClearScreen);

        }

        private bool CanAddOpeation(object obj)
        {
            return !_isLastSignOperation != false;
        }

        private bool CanGetResult(object obj)
        {
            return !_isLastSignOperation != false;
        }

        private void ClearScreen(object obj)
        {
            ScreenVal = "0";
            _isLastSignOperation = false;
        }

        private void GetResult(object obj)
        {
            var result = _dataTable.Compute(ScreenVal.Replace(",", "."), "");
            ScreenVal = result.ToString();
            _isLastSignOperation = false;
        }

        private void AddOperation(object obj)
        {
            var operation = obj as string;

            ScreenVal += operation;
            _isLastSignOperation = true;
        }

        private void AddNumber(object obj)
        {
            var number = obj as string;

            if (ScreenVal == "0" && number != ",")
            {
                ScreenVal = string.Empty;
            }
            else if (number == "," && _avaibleOperations.Contains(ScreenVal.Substring(ScreenVal.Length - 1)))
            {
                number = "0,";
            }
            ScreenVal += number;
            _isLastSignOperation = false;
        }

        public ICommand AddNumberCommand { get; set; }
        public ICommand AddOperationCommand { get; set; }
        public ICommand GetResultCommand { get; set; }
        public ICommand ClearScreenCommand { get; set; }


        public string ScreenVal
        {
            get { return _screenVal; }
            set
            {
                _screenVal = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler
            PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }     

    }
}
