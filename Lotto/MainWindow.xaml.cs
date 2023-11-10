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

namespace Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int szamlalo = 0;
        List<int> szamok = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSorsol_Click(object sender, RoutedEventArgs e)
        {
            szamlalo++;
            int rand = random.Next(0, 100);
            labelFelirat.Content = rand;
            szamok.Add(rand);
            switch (szamlalo)
            {
                case 1:
                    labelElso.Content = rand;
                    break;
                case 2:
                    labelMasodik.Content = rand;
                    break;
                case 3:
                    labelHarmadik.Content = rand;
                    break;
                case 4:
                    labelNegyedik.Content = rand;
                    break;
                case 5:
                    labelOtodik.Content = rand;
                    break;
                default:
                    break;
            }
            if (szamlalo == 5)
            {
                buttonSorsol.Content = "Rendez";
            }
            else if (szamlalo == 6)
            {
                szamok.Sort();
                labelElso.Content = szamok[0];
                labelMasodik.Content = szamok[1];
                labelHarmadik.Content = szamok[2];
                labelNegyedik.Content = szamok[3];
                labelOtodik.Content = szamok[4];
                labelFelirat.Content = "";
                buttonSorsol.Content = "Sorsol";
            }
            else if (szamlalo == 7)
            {
                labelElso.Content = "";
                labelMasodik.Content = "";
                labelHarmadik.Content = "";
                labelNegyedik.Content = "";
                labelOtodik.Content = "";
                labelFelirat.Content = "";
                szamlalo = 0;
                szamok.Clear();
            }
        }
    }
}
