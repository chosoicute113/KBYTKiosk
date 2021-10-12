using KhaiBaoYTeKiosk.Resources.Command;
using MVVMEssentials.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace KhaiBaoYTeKiosk.ViewModels
{
    class LoginViewModel: ViewModelBase
    {
        public string loginUsername = "admin";
        public string loginPassword = "admin";
        public MainViewModel mainvm;
        private Visibility _errorModal = Visibility.Collapsed;
        public Visibility ErrorModal
        {
            get { return _errorModal; }
            set { _errorModal = value;
                OnPropertyChanged(nameof(ErrorModal));}
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value;
                OnPropertyChanged(nameof(Username)); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value;
                OnPropertyChanged(nameof(Username));}
        }

        public ICommand LoginCommand { get; set; }
        public LoginViewModel(MainViewModel mvm)
        {
            mainvm = mvm;
            LoginCommand = new LoginCommand(this);
        }
    }
}
