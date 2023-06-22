using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace CapCalculator
{
    public partial class MainWindow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int TotalCosts
        {
            get { return (int)GetValue(TotalCostsProperty); }
            set { SetValue(TotalCostsProperty, value); }
        }
        public static readonly DependencyProperty TotalCostsProperty =
            DependencyProperty.Register("TotalCosts", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public int CapsAvailable
        {
            get { return (int)GetValue(CapsAvailableProperty); }
            set { SetValue(CapsAvailableProperty, value); }
        }

        public static readonly DependencyProperty CapsAvailableProperty =
            DependencyProperty.Register("CapsAvailable", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));

        public int Buffer
        {
            get { return (int)GetValue(BufferProperty); }
            set { SetValue(BufferProperty, value); }
        }

        public static readonly DependencyProperty BufferProperty =
            DependencyProperty.Register("Buffer", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public int Costs1
        {
            get { return (int)GetValue(Costs1Property); }
            set { SetValue(Costs1Property, value); }
        }

        public static readonly DependencyProperty Costs1Property =
            DependencyProperty.Register("Costs1", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs2
        {
            get { return (int)GetValue(Costs2Property); }
            set { SetValue(Costs2Property, value); }
        }

        public static readonly DependencyProperty Costs2Property =
            DependencyProperty.Register("Costs2", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs3
        {
            get { return (int)GetValue(Costs3Property); }
            set { SetValue(Costs3Property, value); }
        }

        public static readonly DependencyProperty Costs3Property =
            DependencyProperty.Register("Costs3", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs4
        {
            get { return (int)GetValue(Costs4Property); }
            set { SetValue(Costs4Property, value); }
        }

        public static readonly DependencyProperty Costs4Property =
            DependencyProperty.Register("Costs4", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs5
        {
            get { return (int)GetValue(Costs5Property); }
            set { SetValue(Costs5Property, value); }
        }

        public static readonly DependencyProperty Costs5Property =
            DependencyProperty.Register("Costs5", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs6
        {
            get { return (int)GetValue(Costs6Property); }
            set { SetValue(Costs6Property, value); }
        }

        public static readonly DependencyProperty Costs6Property =
            DependencyProperty.Register("Costs6", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs7
        {
            get { return (int)GetValue(Costs7Property); }
            set { SetValue(Costs7Property, value); }
        }

        public static readonly DependencyProperty Costs7Property =
            DependencyProperty.Register("Costs7", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs8
        {
            get { return (int)GetValue(Costs8Property); }
            set { SetValue(Costs8Property, value); }
        }

        public static readonly DependencyProperty Costs8Property =
            DependencyProperty.Register("Costs8", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs9
        {
            get { return (int)GetValue(Costs9Property); }
            set { SetValue(Costs9Property, value); }
        }

        public static readonly DependencyProperty Costs9Property =
            DependencyProperty.Register("Costs9", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs10
        {
            get { return (int)GetValue(Costs10Property); }
            set { SetValue(Costs10Property, value); }
        }

        public static readonly DependencyProperty Costs10Property =
            DependencyProperty.Register("Costs10", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs11
        {
            get { return (int)GetValue(Costs11Property); }
            set { SetValue(Costs11Property, value); }
        }

        public static readonly DependencyProperty Costs11Property =
            DependencyProperty.Register("Costs11", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));
        public int Costs12
        {
            get { return (int)GetValue(Costs12Property); }
            set { SetValue(Costs12Property, value); }
        }

        public static readonly DependencyProperty Costs12Property =
            DependencyProperty.Register("Costs12", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(CostsChanged)));

        public static void CostsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)d;

            if (mainWindow != null)
            {
                mainWindow.TotalCosts =
                    mainWindow.Costs1 +
                    mainWindow.Costs2 +
                    mainWindow.Costs3 +
                    mainWindow.Costs4 +
                    mainWindow.Costs5 +
                    mainWindow.Costs6 +
                    mainWindow.Costs7 +
                    mainWindow.Costs8 +
                    mainWindow.Costs9 +
                    mainWindow.Costs10 +
                    mainWindow.Costs11 +
                    mainWindow.Costs12;

                mainWindow.Buffer = mainWindow.CapsAvailable - mainWindow.TotalCosts;
                if (mainWindow.Buffer < 0)
                {
                    mainWindow.BufferLbl.Background = Brushes.Red;
                    return;
                }
                else
                {
                    mainWindow.BufferLbl.Background = Brushes.LightGreen;
                }
            }
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void AvailableCapsTb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            //TODO: actuallisize buffer    
            control1.Recalculate();
        }

        private void AvailableCapsTb_GotFocus(object sender, RoutedEventArgs e)
        {
            //AvailableCapsTb.SelectAll();
        }
    }
}
