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
	/// Логика взаимодействия для ThirdGrid.xaml
	/// </summary>
	public partial class ThirdGrid : Page
	{
		private MagazineEntities context = new MagazineEntities();

		public ThirdGrid()
		{
			InitializeComponent();

			OrdersDataGrid.ItemsSource = context.Orders.ToList();
			OrdersComboBox.ItemsSource = context.Orders.ToList();
		}

		private void forExit_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Window.GetWindow(this).Close();
		}

		private void forGrid_Click(object sender, RoutedEventArgs e)
		{
			//OrdersDataGrid.ItemsSource = context.Orders.ToList().Where(item => item.Client_ID.Contains(forSearch.Text));
		}

		private void forClean_Click(object sender, RoutedEventArgs e)
		{
			OrdersDataGrid.ItemsSource = context.Orders.ToList();
			forSearch.Text = "";
			OrdersComboBox.SelectedItem = null;
		}

		private void OrdersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (OrdersComboBox.SelectedItem != null)
			{
				var selected = OrdersComboBox.SelectedItem as Orders;
				OrdersDataGrid.ItemsSource = context.Orders.ToList().Where(item => item.Client_ID == selected.Client_ID);
			}
		}
	}
}
