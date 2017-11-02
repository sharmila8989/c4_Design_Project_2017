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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            _NavigationFrame.Navigate(new MainWindow());
            InitializeComponent();
            
        }

        GameController gController = new GameController();
        

        private void warriorButton_Click(object sender, RoutedEventArgs e)
        {
            // Disbaling the the player character button
            warriorButton.IsEnabled = false;
            thiefButton.IsEnabled = false;
            mageButton.IsEnabled = false;

            // Enaling the start game button
            startGameButton.IsEnabled = true;

            // Display Message Box to click on start game button
            MessageBox.Show("You have selected Warrior. Please click on start game button to start playing !");

            // creating warrior character
            gController.selectCharacter("Warrior");

        }

        private void thiefButton_Click(object sender, RoutedEventArgs e)
        {
            // Disabling the player character's button
            thiefButton.IsEnabled = false;
            mageButton.IsEnabled = false;
            warriorButton.IsEnabled = false;

            // Enabling start game button
            startGameButton.IsEnabled = true;

            // Display Message Box to click on start game button
            MessageBox.Show("You have selected Thief. Please click on start game button to start playing !");

            // creating thief character
            gController.selectCharacter("Thief");
        }

        private void mageButton_Click(object sender, RoutedEventArgs e)
        {
            // Disabling the player character's button
            
            mageButton.IsEnabled = false;
            thiefButton.IsEnabled = false;
            warriorButton.IsEnabled = false;
            
            // Enabling start game button
            startGameButton.IsEnabled = true;

            // Display Message Box to click on start game button
            MessageBox.Show("You have selected Mage. Please click on start game button to start playing !");

            // creating mage character
            gController.selectCharacter("Mage");

        }

        private void startGameButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to battle phase page once start game button is clicked 
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("BattlePhase.xaml", UriKind.Absolute));
        }
    }
}
