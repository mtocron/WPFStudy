using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CodeHelloWorld
{
	class MainWindow : Window
	{
		private Button _BtnHelloWorldButton;

		private void InitializeComponent()
		{
			Title = "MainWindow";
			Height = 350;
			Width = 525;

			_BtnHelloWorldButton = new Button
			{
				Content = "Hello World",
				HorizontalAlignment = HorizontalAlignment.Left,
				VerticalAlignment = VerticalAlignment.Top,
				Margin = new Thickness(10, 10, 0, 0),
				Width = 100
			};
			_BtnHelloWorldButton.Click += _BtnHelloWorldButton_Click;

			var grid = new Grid();
			grid.Children.Add(_BtnHelloWorldButton);

			Content = grid;
		}

		private void _BtnHelloWorldButton_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello world");
		}

		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
