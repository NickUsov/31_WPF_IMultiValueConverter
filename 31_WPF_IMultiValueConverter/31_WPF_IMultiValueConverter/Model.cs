using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace _31_WPF_IMultiValueConverter
{
    public class Model : DependencyObject, INotifyPropertyChanged
    {
        static Model()
        {
            DateProperty = DependencyProperty.Register("DATE", typeof(DateTime), typeof(Model));
        }
        public Model()
        {
            day = 1;
            month = 1;
            year = 2000;
            MultiBinding binding = new MultiBinding();
            Binding bind1 = new Binding("DAY");
            bind1.Source = this;
            binding.Bindings.Add(bind1);

            Binding bind2 = new Binding("MONTH");
            bind2.Source = this;
            binding.Bindings.Add(bind2);

            Binding bind3 = new Binding("YEAR");
            bind3.Source = this;
            binding.Bindings.Add(bind3);

            binding.Converter = new MultiValueConverter();
            binding.Mode = BindingMode.TwoWay;
            BindingOperations.SetBinding(this, DateProperty, binding);
        }
        public static readonly DependencyProperty DateProperty;
        public DateTime DATE
        {
            get { return (DateTime)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        private int day;
        public int DAY
        {
            set
            {
                day = value;
                OnPropertyChanged("DAY");
            }
            get { return day; }
        }
        private int month;
        public int MONTH
        {
            set
            {
                month = value;
                OnPropertyChanged("MONTH");
            }
            get { return month; }
        }
        private int year;
        public int YEAR
        {
            set
            {
                year = value;
                OnPropertyChanged("YEAR");
            }
            get { return year; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
