using System;
using System.Collections.Generic;
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

namespace WpfApplication10
{

    public partial class DateSelectControl : UserControl
    {
        public DateSelectControl()
        {
            InitializeComponent();
        }

        public Brush MonthForeGround
        {
            get { return (Brush)GetValue(MonthForeGroundProperty); }
            set { SetValue(MonthForeGroundProperty, value); }
        }

        public static readonly DependencyProperty MonthForeGroundProperty =
        DependencyProperty.Register("MonthForeGround",
        typeof(Brush), typeof(DateSelectControl), new PropertyMetadata(Brushes.White));

        public DateTime Value
        {
            get { return (DateTime)GetValue(ValueProperty); }
            set
            {
                SetValue(ValueProperty, value);
            }
        }
        public static readonly DependencyProperty ValueProperty =
        DependencyProperty.Register("Value",
        typeof(DateTime), typeof(DateSelectControl), new PropertyMetadata(DateTime.Now));

        private void MonthUserControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            var data = new MonthUserControlModel()
            {
                MonthForeGround = MonthForeGround,
            };
            TblYear.Text = Value.Year.ToString();
            int month = Value.Month;
            switch (month)
            {
                case 1:
                    {
                        BtnMonth1.IsChecked = true;
                    }
                    break;
                case 2:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 3:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 4:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 5:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 6:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 7:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 8:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 9:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 10:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 11:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
                case 12:
                    {
                        BtnMonth2.IsChecked = true;
                    } break;
            }
            this.DataContext = data;
        }

        private void BtnPrevious_OnClick(object sender, RoutedEventArgs e)
        {
            int month = Value.Month;
            int year = Convert.ToInt32(TblYear.Text) - 1;
            var newDate = new DateTime(year, month, 1);
            Value = newDate;
            TblYear.Text = year.ToString();
        }

        private void BtnNext_OnClick(object sender, RoutedEventArgs e)
        {
            int month = Value.Month;
            int year = Convert.ToInt32(TblYear.Text) + 1;
            var newDate = new DateTime(year, month, 1);
            Value = newDate;
            TblYear.Text = year.ToString();
        }

        private void ButtonMonth_OnClick(object sender, RoutedEventArgs e)
        {
            int year = Value.Year;
            var button = sender as RadioButton;
            int month = Convert.ToInt32(button.Content.ToString().Replace("月", ""));
            var newDate = new DateTime(year, month, 1);
            Value = newDate;
        }
    }

    public class MonthUserControlModel
    {
        public Brush MonthForeGround { get; set; }
        public string Year { get; set; }
        public int Month { get; set; }
    }
}
