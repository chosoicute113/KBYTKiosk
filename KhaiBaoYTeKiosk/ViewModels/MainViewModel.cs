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
    public class MainViewModel: ViewModelBase
    {
        private ViewModelBase _selectedViewModel;

        public ViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public ICommand UpdateViewCommand { get; set; }
        public MainViewModel()
        {
            _selectedViewModel = new LoginViewModel(this);
            UpdateViewCommand = new UpdateViewCommand(this);
        }

    }
}
