using KhaiBaoYTeKiosk.Resources.Command;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KhaiBaoYTeKiosk.ViewModels
{
    class HealthDeclarationViewModel : ViewModelBase
    {
        private ViewModelBase _modalViewModel;
        public ViewModelBase ModalViewModel
        {
            get { return _modalViewModel; }
            private set { _modalViewModel = value;
                OnPropertyChanged(nameof(ModalViewModel)); }
        }
        public ICommand UpdateViewCommand { get; set; }
        public HealthDeclarationViewModel(MainViewModel mainView)
        {
            _modalViewModel = new QRCheckinViewModel();
            UpdateViewCommand = new UpdateViewCommand(mainView);
        }
    }
}
