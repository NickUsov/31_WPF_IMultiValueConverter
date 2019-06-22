using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _31_WPF_IMultiValueConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Model();
        }
    }

    public class YearValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int year = Convert.ToInt32(value);
            if (year < 0)
                return new ValidationResult(false, "dklfgjf");
            else
                return new ValidationResult(true, "cool!");
        }
    }
    public class MonthValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int month = Convert.ToInt32(value);
            if (month < 0)
                return new ValidationResult(false, "dklfgjf");
            else
                return new ValidationResult(true, "cool!");
        }
    }
    public class DayValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int day = Convert.ToInt32(value);
            if (day < 0)
                return new ValidationResult(false, "dklfgjf");
            else
                return new ValidationResult(true, "cool!");
        }
    }
}
