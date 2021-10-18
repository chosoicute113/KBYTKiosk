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
        public MainViewModel MainVM;
        private Visibility _errorModal = Visibility.Collapsed;

        private string _errorMessage = "ERROR MESSAGE";
        public string ErrorNessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorNessage));
            }
        }

        private string _errorTitle = "ERROR TITLE";
        public string ErrorTitle
        {
            get { return _errorTitle; }
            set
            {
                _errorTitle = value;
                OnPropertyChanged(nameof(ErrorTitle));
            }
        }

        private string _errorImage = "/Resources/Images/ico_error_login.png";
        public string ErrorImage
        {
            get { return _errorImage; }
            set
            {
                _errorImage = value;
                OnPropertyChanged(nameof(ErrorImage));
            }
        }
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
            MainVM = mvm;
            LoginCommand = new LoginCommand(this);
        }

        public void editErrorModal(string title, string description, string imagepath)
        {
            ErrorNessage = description;
            ErrorImage = imagepath;
            ErrorTitle = title;
        }
    }
}
