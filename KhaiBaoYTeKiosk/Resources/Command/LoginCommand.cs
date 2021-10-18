using KhaiBaoYTeKiosk.API;
using KhaiBaoYTeKiosk.Models;
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
        private readonly LoginViewModel LoginVM;
        public LoginCommand(LoginViewModel vm)
        {
            LoginVM = vm;
        }
        public override async void Execute(object parameter)
        {
            Debug.WriteLine("Inside the LoginCommand");
            if (String.IsNullOrWhiteSpace(LoginVM.Username) || String.IsNullOrWhiteSpace(LoginVM.Password))
            {
                LoginVM.editErrorModal("THÔNG BÁO",
                "Vui lòng nhập đầy đủ thông tin",
                "/Resources/Images/ico_error_warn.png");
                LoginVM.ErrorModal = Visibility.Visible;
            }
            else
            {
                try
                {
                    var URL = "https://kbyt.khambenh.gov.vn/api/v1/login";
                    var account = new Account() { data = LoginVM.Username, password = LoginVM.Password };
                    User user = await LoginProcessor.LoadProcessor(URL, account);
                    if (user != null)
                    {
                        LoginVM.MainVM.MainUser = user;
                        LoginVM.MainVM.SelectedViewModel = new QRCheckinViewModel(LoginVM.MainVM);
                        Debug.WriteLine("API Calls successfully");

                    }
                }
                catch (Exception e)
                {
                    LoginVM.editErrorModal("LỖI ĐĂNG NHẬP",
                                    "Thông tin nhập vào sai",
                                    "/Resources/Images/ico_error_login.png");
                    LoginVM.ErrorModal = Visibility.Visible;
                    Debug.WriteLine("API Calls fail");
                    Debug.WriteLine(e.Message);
                }
            }
        }
    }
}
