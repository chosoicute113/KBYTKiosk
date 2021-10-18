using KhaiBaoYTeKiosk.Models;
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



        private User _mainUser;

        public User MainUser
        {
            get { return _mainUser; }
            set { _mainUser = value; }
        }


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
            APIHelper.InitializeClient();
            _selectedViewModel = new LoginViewModel(this);
            UpdateViewCommand = new UpdateViewCommand(this);
        }

    }
}
