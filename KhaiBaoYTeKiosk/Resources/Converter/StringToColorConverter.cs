using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace KhaiBaoYTeKiosk.Resources.Converter
{
    class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("Im in statement converter");

            if (value is string)
            {
                Debug.WriteLine("Im in statement 1");
                if(value.ToString() == "Không")
                {
                    Debug.WriteLine("Im in statement 2");

                    return Brushes.White;
                }
            }
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
