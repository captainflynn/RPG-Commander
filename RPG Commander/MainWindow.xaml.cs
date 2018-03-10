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

namespace RPG_Commander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtStrPoints_LostKeyboardFocus(object sender, TextChangedEventArgs e)
        {
            if (txtStrPoints.Text != null && !string.IsNullOrWhiteSpace(txtStrPoints.Text))
            {
                int StrPoints = Convert.ToInt32(txtStrPoints.Text);
                int StrMod = 0;


                if (StrPoints >= 0 && StrPoints <= 30)
                {
                    StrMod = (StrPoints - 10) / 2;
					if (StrMod < 0)
					{
						txtStrMod.Text = Convert.ToString(StrMod);
					}
					else
					{
						txtStrMod.Text = "+" + Convert.ToString(StrMod);
					}
                }
                else
                {
					txtStrPoints.Text = "30";
                }
            }
        }

        private void txtStrPoints_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
    }
}
