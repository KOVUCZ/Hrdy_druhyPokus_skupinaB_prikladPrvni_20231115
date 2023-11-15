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

namespace Hrdy_druhyPokus_skupinaB_prikladPrvni_20231115
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            selector.SelectedIndex = 0;
        }

        private void selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(selector.SelectedIndex == 0) //koule
            {
                Input_r.Visibility = Visibility.Visible;
                LabelInput_r.Visibility = Visibility.Visible;
                Input_a.Visibility = Visibility.Hidden;
                LabelInput_a.Visibility = Visibility.Hidden;
            }
            else
            {
                Input_r.Visibility = Visibility.Hidden;
                LabelInput_r.Visibility= Visibility.Hidden;
                Input_a.Visibility = Visibility.Visible;
                LabelInput_a.Visibility = Visibility.Visible;

            }
        }
    }
}
