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

namespace Omega
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		public LoginWindow()
		{
			MessageBox.Show("Hello, " + System.Environment.UserName + ". Program is locked in test mode. Server is deactivated! The login is \nUsername: root\nPassword: root", "WARN", MessageBoxButton.OK, MessageBoxImage.Warning);
			InitializeComponent();
		}

		private void ButtonExit_Click(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);
        }

		private void ButtonLogin_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("No omega.dll found. Please exit", "ERR", MessageBoxButton.OK, MessageBoxImage.Error);
		}
    }
}
