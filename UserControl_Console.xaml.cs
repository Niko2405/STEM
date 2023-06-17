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

namespace STEM
{
    /// <summary>
    /// Interaktionslogik für UserControlConsole.xaml
    /// </summary>
    public partial class UserControl_Console : UserControl
    {
        public UserControl_Console()
        {
            InitializeComponent();
		}

		private void radioTargetSerial_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void radioTargetLocal_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void radioTargetServer_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void buttonSendCommand_Click(object sender, RoutedEventArgs e)
		{
			if (radioTargetSerial.IsChecked == true)
			{
				textBoxConsoleOutput.Text = "Sended command {" + textBoxConsoleInput.Text + "} to Serial";
			} else if (radioTargetLocal.IsChecked == true)
			{
				textBoxConsoleOutput.Text = "Sended command {" + textBoxConsoleInput.Text + "} to Local";
			} else if (radioTargetServer.IsChecked == true)
			{
				textBoxConsoleOutput.Text = "Sended command {" + textBoxConsoleInput.Text + "} to Server";
			}
		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			radioTargetLocal.IsChecked = true;
			// TODO: Add configs!
		}
	}
}
