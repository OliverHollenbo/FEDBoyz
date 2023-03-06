using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Assignment1.Model;
using Prism.Commands;
using Prism.Mvvm;

namespace Assignment1.ViewModel
{
	public class DebtorAddViewModel : BindableBase
	{


		public DebtorAddViewModel(string title, Debtors debtors)
		{
			Title = title;
			debtors = CurrentDebtors;

		}


		string title;

		public string Title
		{
			get { return title; }
			set { SetProperty(ref title, value); }
		}

		Debtors currentDebtors;

		public Debtors CurrentDebtors
		{
			get { return currentDebtors; }
			set { SetProperty(ref currentDebtors, value); }
		}
		public bool IsValid
		{
			get
			{
				bool isValid = true;
				if (string.IsNullOrWhiteSpace(CurrentDebtors.Debtorname))
					isValid = false;
				if (string.IsNullOrWhiteSpace(CurrentDebtors.Initialvalue))
					isValid = false;
				return isValid;
			}
			
		}



		#region Command

		private ICommand _saveBtnCommand;

		public ICommand saveBtnCommand
		{
			get
			{
				return _saveBtnCommand ?? (_saveBtnCommand = new DelegateCommand(
						SaveBtnCommand_Execute, saveBtnCommand_CanExecute)
					.ObservesProperty(() => CurrentDebtors.Debtorname)
					.ObservesProperty(() => CurrentDebtors.Initialvalue));
			}
		}
		private void SaveBtnCommand_Execute()
		{
			// No action here - is handled i code behind
		}

		private bool saveBtnCommand_CanExecute()
		{
			return IsValid;
		}

		#endregion



	}

}
