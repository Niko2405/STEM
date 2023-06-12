using System.Threading.Tasks;
using System.Windows;

namespace STEM
{
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		public LoginWindow()
		{
			MessageBox.Show("Hello, " + System.Environment.UserName.ToUpper() + ". Program is locked in test mode. Server is unreachable!", "LOCKED", MessageBoxButton.OK, MessageBoxImage.Warning);
			InitializeComponent();
		}
		private async void ButtonLogin_Click(object sender, RoutedEventArgs e)
		{
			// INIT
			InitWindow initWindow = new InitWindow();
			MenuWindow menuWindow = new MenuWindow();
			initWindow.Show();

			// Wait for init is finish
			while (!Init.Initialized)
			{
				await Task.Delay(100);
			}
			MessageBox.Show("Components initialized", "Init", MessageBoxButton.OK, MessageBoxImage.Information);
			
			// show the main menu window
			menuWindow.Show();
			this.Close();
			//MessageBox.Show("No function imported in resources. Idiot", "Fatal Error", MessageBoxButton.OK,MessageBoxImage.Error);
		}

		private void ButtonExit_Click(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);
		}
	}
}
