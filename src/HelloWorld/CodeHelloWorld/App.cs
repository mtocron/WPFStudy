using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CodeHelloWorld
{
	class App : Application
	{
		[STAThread]
		public static void Main(string[] args)
		{
			var app = new App();
			app.InitializeComponent();
			app.Run();
		}

		private void InitializeComponent()
		{
			Startup += App_Startup;
		}

		private void App_Startup(object sender, StartupEventArgs e)
		{
			var w = new MainWindow();
			w.Show();
		}
	}
}
