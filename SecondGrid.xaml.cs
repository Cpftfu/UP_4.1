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
	/// Логика взаимодействия для SecondGrid.xaml
	/// </summary>
	public partial class SecondGrid : Page
	{
		private MagazineEntities context = new MagazineEntities();

		public SecondGrid()
		{
			InitializeComponent();
			ProductsDataGrid.ItemsSource = context.Products.ToList();
			ProductsComboBox.ItemsSource = context.Products.ToList();
		}

		private void forExit_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Window.GetWindow(this).Close();
		}

		private void forGrid_Click(object sender, RoutedEventArgs e)
		{
			ProductsDataGrid.ItemsSource = context.Products.ToList().Where(item => item.ProductName.Contains(forSearch.Text));
		}

		private void forClean_Click(object sender, RoutedEventArgs e)
		{
			ProductsDataGrid.ItemsSource = context.Products.ToList();
			forSearch.Text = "";
			ProductsComboBox.SelectedItem = null;
		}

		private void ProductsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ProductsComboBox.SelectedItem != null)
			{
				var selected = ProductsComboBox.SelectedItem as Products;
				ProductsDataGrid.ItemsSource = context.Products.ToList().Where(item => item.ProductName == selected.ProductName);
			}
		}
	}
}
