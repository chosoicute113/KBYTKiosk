using KhaiBaoYTeKiosk.ViewModels;
using MVVMEssentials.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KhaiBaoYTeKiosk.Resources.Command
{
    public class UpdateViewCommand : CommandBase
    {
        private MainViewModel _viewModel;

        public UpdateViewCommand(MainViewModel ViewModel)
        {
            _viewModel = ViewModel;

        }

        public override void Execute(object parameter)
        {
            Debug.WriteLine("In the Command");
            switch (parameter.ToString())
            {
                case "Login":
                    {
                        _viewModel.SelectedViewModel = new LoginViewModel(_viewModel);
                        break;
                    }
                case "QR":
                    {
                        _viewModel.SelectedViewModel = new QRCheckinViewModel(_viewModel);
                        break;
                    }
            }
        }
    }
}
