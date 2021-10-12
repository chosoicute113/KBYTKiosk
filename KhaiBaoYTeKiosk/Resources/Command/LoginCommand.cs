using KhaiBaoYTeKiosk.ViewModels;
using MVVMEssentials.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KhaiBaoYTeKiosk.Resources.Command
{
    class LoginCommand : CommandBase
    {
        private readonly LoginViewModel _vm;
        public LoginCommand(LoginViewModel vm)
        {
            _vm = vm;
        }
        public override void Execute(object parameter)
        {
            if (_vm.Username != _vm.loginUsername || _vm.Password != _vm.loginPassword)
            {
                _vm.ErrorModal = Visibility.Visible;
            }
            else _vm.mainvm.SelectedViewModel = new QRCheckinViewModel();
        }
    }
}
