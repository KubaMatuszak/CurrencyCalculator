using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator.CurriencesLists
{
	public static class CurriencesLists
	{
		public static ObservableCollection<string> from = new ObservableCollection<string>
		{
			"PLN",
			"EUR"
		};
		public static ObservableCollection<string> to = new ObservableCollection<string>
		{
			"USD",
			"EUR"
		};
	}
}
