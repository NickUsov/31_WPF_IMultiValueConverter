using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _31_WPF_IMultiValueConverter
{
    class MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new DateTime((int)values[2], (int)values[1], (int)values[0]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            DateTime dt = (DateTime)value;
            return new object[3] { (object)dt.Day, (object)dt.Month, (object)dt.Year };
        }
    }
}
