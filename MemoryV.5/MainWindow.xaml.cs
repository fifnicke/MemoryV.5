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
using System.Threading;
using System.Collections;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Media;
using System.Diagnostics;
using System.Windows.Media.Effects;

namespace MemoryV._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameOptions gameOptions = new GameOptions();
        private GameController gameController;

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            gameController = new SinglePlayerGameController(this.gameGrid, gameOptions.SelectedIconSet);
        }

        private void rectangleLeftMouseButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rectangle cardRectangle = e.Source as Rectangle;
            if (cardRectangle == null) return;

            gameController.PickCard(cardRectangle);
        }

        private void OptionsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OptionsWindow optionWindow = new OptionsWindow();
            optionWindow.DataContext = gameOptions;
            optionWindow.ShowDialog();
        }
        private void NewGameSinglePlayerCommand_executed(object sender, ExecutedRoutedEventArgs e)
        {
            borderPlayer1.DataContext = null;
            borderPlayer2.DataContext = null;
            gameController = new SinglePlayerGameController(gameGrid, gameOptions.SelectedIconSet);
            gameController.StartGame();
        }
        private void NewGameTwoPlayerCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TwoPlayerGameController gameController = new TwoPlayerGameController(gameGrid, gameOptions.SelectedIconSet);
            borderPlayer1.DataContext = gameController.Player1;
            borderPlayer2.DataContext = gameController.Player2;
            this.gameController = gameController;
            gameController.StartGame();
        }
        private void NewGameAgainstComputerCommand_Executred(object sender, ExecutedRoutedEventArgs e)
        {
            AgainstComputerGameController gameController = new AgainstComputerGameController(gameGrid, gameOptions.SelectedIconSet);
            borderPlayer1.DataContext = gameController.Player1;
            borderPlayer2.DataContext = gameController.Player2;
            this.gameController = gameController;
            gameController.StartGame();
        }

        private void exit_menuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void vsComp_Click(object sender, RoutedEventArgs e)
        {
            AgainstComputerGameController gameController = new AgainstComputerGameController(gameGrid, gameOptions.SelectedIconSet);
            borderPlayer1.DataContext = gameController.Player1;
            borderPlayer2.DataContext = gameController.Player2;
            this.gameController = gameController;
            gameController.StartGame();
        }

        private void TwoPlayer_Click(object sender, RoutedEventArgs e)
        {
            TwoPlayerGameController gameController = new TwoPlayerGameController(gameGrid, gameOptions.SelectedIconSet);
            borderPlayer1.DataContext = gameController.Player1;
            borderPlayer2.DataContext = gameController.Player2;
            this.gameController = gameController;
            gameController.StartGame();
        }

        private void Single_Click(object sender, RoutedEventArgs e)
        {
            borderPlayer1.DataContext = null;
            borderPlayer2.DataContext = null;
            gameController = new SinglePlayerGameController(gameGrid, gameOptions.SelectedIconSet);
            gameController.StartGame();
        }

        private void options_Click(object sender, RoutedEventArgs e)
        {
            OptionsWindow optionWindow = new OptionsWindow();
            optionWindow.DataContext = gameOptions;
            optionWindow.ShowDialog();
        }
    }
}
