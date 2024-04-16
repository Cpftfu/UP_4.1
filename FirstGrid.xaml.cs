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

namespace UP_4._1
{
	/// <summary>
	/// Логика взаимодействия для FirstGrid.xaml
	/// </summary>
	public partial class FirstGrid : Page
	{
		private MagazineEntities context = new MagazineEntities();

		public FirstGrid()
		{
			InitializeComponent();

			ClientsDataGrid.ItemsSource = context.Clients.ToList();
			ClientsComboBox.ItemsSource = context.Clients.ToList();
		}

		private void forExit_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Window.GetWindow(this).Close();
		}

		private void forGrid_Click(object sender, RoutedEventArgs e)
		{
			ClientsDataGrid.ItemsSource = context.Clients.ToList().Where(item => item.ClientMiddlename.Contains(forSearch.Text));
		}

		private void forClean_Click(object sender, RoutedEventArgs e)
		{
			ClientsDataGrid.ItemsSource = context.Clients.ToList();
			forSearch.Text = "";
			ClientsComboBox.SelectedItem = null;
		}

		private void ClientsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ClientsComboBox.SelectedItem != null)
			{
				var selected = ClientsComboBox.SelectedItem as Clients;
				ClientsDataGrid.ItemsSource = context.Clients.ToList().Where(item => item.ClientMiddlename == selected.ClientMiddlename);
			}
		}
	}
}
