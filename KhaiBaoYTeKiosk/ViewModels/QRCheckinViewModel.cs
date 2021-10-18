using KhaiBaoYTeKiosk.Resources.Command;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KhaiBaoYTeKiosk.ViewModels
{
    class QRCheckinViewModel: ViewModelBase
    {
        public MainViewModel MainVM;

        private string _scannedCode ="";
        public string ScannedCode
        {
            get { return _scannedCode; }
            set {
                if (value != null)
                {
                    _scannedCode = value;
                    if (value.Length >= 87)
                    {
                        
                        QRScanCommand.Execute(null);
                    }
                }
                OnPropertyChanged(nameof(ScannedCode));
            }
        }

        public void emptyScannedCode()
        {
            _scannedCode = "";
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage)); }
        }


        

        public ICommand QRScanCommand { get; set; }

        public QRCheckinViewModel(MainViewModel vm)
        {

            MainVM = vm;
            QRScanCommand = new QRScanCommand(this);
        }
    }
}
