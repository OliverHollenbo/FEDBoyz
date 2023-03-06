using Assignment1.ViewModel;
using Assignment1.Views;
using Assignment1.Model;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Assignment1.Model;


namespace Assignment1.ViewModel
{
	public class MainWindowViewModel : BindableBase
	{

		public MainWindowViewModel()
		{
			DebtorCollection = new ObservableCollection<Debtors>();
			debtorsCollection.Add(new Debtors("Mads","0","-1000", "27 Januar"));
			currentDebtor = DebtorCollection[0];
		}

		#region Properties

		private Debtors currentDebtor;
		public Debtors CurrentDebtor
		{
			get { return currentDebtor; }
			set { SetProperty(ref currentDebtor, value); }
		}

		private ObservableCollection<Debtors> debtorsCollection;

		public ObservableCollection<Debtors> DebtorCollection
		{
			get { return debtorsCollection; }
			set { SetProperty(ref debtorsCollection, value); }

		}
		private bool dirty = false;
		public bool Dirty
		{
			get { return dirty; }
			set
			{
				SetProperty(ref dirty, value);
				RaisePropertyChanged("Title");
			}
		}

		#endregion

		

		#region Commands	
		private DelegateCommand? _addCommand;

		public DelegateCommand AddCommand =>
				_addCommand ?? (_addCommand = new DelegateCommand(ExecuteAddCommand));

		void ExecuteAddCommand()
		{
			AddDebtorView a1 = new AddDebtorView();
			a1.Show();
			//var newDebtors = new Debtors();
			//var vm = new DebtorAddViewModel("Add new debtor", newDebtors);

			//var dlg = new DebtorView
			//{
			//	DataContext = vm
			//};
			//if (dlg.ShowDialog() == true)
			//{
			//	DebtorCollection.Add(newDebtors);
			//	CurrentDebtor = newDebtors; // Or CurrentIndex = Agents.Count - 1;
			//	Dirty = true;
			//}
		}

		#endregion



	}

}
