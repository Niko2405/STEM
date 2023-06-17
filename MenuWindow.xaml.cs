using System;
using System.Windows;

namespace STEM
{
	/// <summary>
	/// Interaktionslogik für Menu.xaml
	/// </summary>
	public partial class MenuWindow : Window
	{
		public MenuWindow()
		{
			InitializeComponent();
		}

		private void ButtonConsole_Click(object sender, RoutedEventArgs e)
		{
			MenuControl.Content = new UserControl_Console();
		}

		private void ButtonExit_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
