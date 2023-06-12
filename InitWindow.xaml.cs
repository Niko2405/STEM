using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace STEM
{
	/// <summary>
	/// Interaktionslogik für InitWindow.xaml
	/// </summary>
	public partial class InitWindow : Window
	{
		public InitWindow()
		{
			InitializeComponent();
		}
		private async void InitWindow_loaded(object sender, RoutedEventArgs e)
		{
			// start init
			Init.CreateDirectories();
			//Init.DownloadVoiceFiles();

			// test delay async
			for (int i = 0; i <= 10; i++)
			{
				TitleLabel.Content = i.ToString() + "sec. passed";
				await Task.Delay(1000);
			}

			// set Initialized to true -> open menuWindow
			Init.Initialized = true;
			this.Close();
		}
	}
}
