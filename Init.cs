using System;
using System.Windows;

namespace STEM
{
	class Init
	{
		public static bool Initialized = false;
		public static void CreateDirectories()
		{
			string rootDirectory = "STEM/";
			string voiceDirectory = rootDirectory + "voice/";
			string cacheDirectory = rootDirectory + "cache/";
			string dataDirectory = rootDirectory + "data/";

			try
			{
				System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/" + rootDirectory);
				System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/" + voiceDirectory);
				System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/" + cacheDirectory);
				System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/" + dataDirectory);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
			}
		}
	}
}
