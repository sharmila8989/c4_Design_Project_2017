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

namespace MegaCardGame
{
    /// <summary>
    /// Interaction logic for BattlePhase.xaml
    /// </summary>
    public partial class BattlePhase : Page
    {
        public string typeOfAttack;
        public BattlePhase()
        {
            InitializeComponent();
           
        }
        

        private void normalAttackButton_Click(object sender, RoutedEventArgs e)
        {
            
            typeOfAttack = "normal";
        }

        private void specialAttackButton_Click(object sender, RoutedEventArgs e)
        {
            typeOfAttack = "special";
            
        }
    }
}
