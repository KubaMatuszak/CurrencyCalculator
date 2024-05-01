
using CurrencyCalculator.ApiServices;
using CurrencyCalculator.CurriencesLists;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyCalculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			FromList.ItemsSource = CurriencesLists.CurriencesLists.from;
			ToList.ItemsSource = CurriencesLists.CurriencesLists.to;
			
			
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ApiService service = new ApiService();
			var output = service.GetExchangeRate(FromList.SelectedItem.ToString(), ToList.SelectedItem.ToString());
			MessageBox.Show(output.ToString(),"wynik",MessageBoxButton.OK);

		}
	}
}