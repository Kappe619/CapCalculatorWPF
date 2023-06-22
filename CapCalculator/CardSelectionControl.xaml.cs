using System.ComponentModel;
using System.Windows;

namespace CapCalculator
{
    public partial class CardSelectionControlWithImage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Level
        {
            get { return (int)GetValue(LevelProperty); }
            set { SetValue(LevelProperty, value); }
        }
        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        public int Result
        {
            get { return (int)GetValue(ResultProperty); }
            set { SetValue(ResultProperty, value); }
        }

        public static readonly DependencyProperty ResultProperty =
            DependencyProperty.Register("Result", typeof(int), typeof(CardSelectionControlWithImage), new PropertyMetadata(0));

        public static readonly DependencyProperty LevelProperty =
            DependencyProperty.Register("Level", typeof(int), typeof(CardSelectionControlWithImage), new PropertyMetadata(4, new PropertyChangedCallback(OnChanged)));

        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register("SelectedIndex", typeof(int), typeof(CardSelectionControlWithImage), new PropertyMetadata(0));

        private static void OnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CardSelectionControlWithImage control = (CardSelectionControlWithImage)d;
            control.Recalculate();
        }

        public void Recalculate()
        {
            if (upDown != null)
            {
                if (SelectedIndex == 0)
                {
                    if (Level < 4) { Level = 4; }
                    upDown.Minimum = 4;
                    Result = CalcCommon(Level);
                }

                else if (SelectedIndex == 1)
                {
                    if (Level < 3) { Level = 3; }
                    upDown.Minimum = 3;
                    Result = CalcRare(Level);
                }

                else if (SelectedIndex == 2)
                {
                    if (Level < 2) { Level = 2; }
                    upDown.Minimum = 2;
                    Result = CalcEpic(Level);
                }

                else if (SelectedIndex == 3)
                {
                    upDown.Minimum = 1;
                    Result = CalcLegendary(Level);
                }
            }
        }

        public CardSelectionControlWithImage()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Recalculate();
        }

        //Upgrade costs, array index = card level
        private int[] commonCosts = { 0, 0, 0, 0, 0, 100, 275, 575 };
        private int[] rareCosts = { 0, 0, 0, 0, 125, 325, 650, 1075 };
        private int[] epicCosts = { 0, 0, 0, 175, 425, 800, 1275, 1825 };
        private int[] legendaryCosts = { 0, 0, 200, 475, 875, 1375, 1950, 2575 };

        int CalcCommon(int level)
        {
            return commonCosts[level];
        }

        int CalcRare(int level)
        {
            return rareCosts[level];
        }

        int CalcEpic(int level)
        {
            return epicCosts[level];
        }

        int CalcLegendary(int level)
        {
            return legendaryCosts[level];
        }
    }
}