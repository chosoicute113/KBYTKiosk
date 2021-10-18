using KhaiBaoYTeKiosk.API;
using KhaiBaoYTeKiosk.Models;
using KhaiBaoYTeKiosk.ViewModels;
using MVVMEssentials.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoYTeKiosk.Resources.Command
{
    class QRScanCommand : CommandBase
    {
        private QRCheckinViewModel QRCheckinVM;
        private CheckinUser user = new CheckinUser();

        public QRScanCommand(QRCheckinViewModel vm)
        {
            QRCheckinVM = vm;
        }

        public override async void Execute(object parameter)
        {
            string ID = transformUrlToID(QRCheckinVM.ScannedCode);
            string URL = "https://kbyt.khambenh.gov.vn/api/v1/tokhai_yte/";

            if (ID != null)
            {
                try
                {
                    user = await QRProcessor.LoadActivity(URL, ID);
                    QRCheckinVM.MainVM.SelectedViewModel = new CheckinInfoViewModel(QRCheckinVM.MainVM, user);
                }
                catch (Exception e)
                {
                    QRCheckinVM.emptyScannedCode();
                    QRCheckinVM.ErrorMessage = e.Message;
                }
            }
        }

        public string transformUrlToID(string url)
        {
            if (url.Contains("id="))
            {
                string ID = url.Split("id=")[1];
                return ID;
            }
            return null;
        }
    }
}
