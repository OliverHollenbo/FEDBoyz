using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Model
{
	public class Debtors : BindableBase
	{
			private string DebtorName;
			string InitialValue;
			string DebtBalance;
			string Date;

			public Debtors()
			{
			}

			public Debtors(string? aDebtorName, string? aInitialValue, string? aDebtBalance, string? aDate)
			{
				DebtorName = aDebtorName;
				InitialValue = aInitialValue;
				DebtBalance = aDebtBalance;
				Date = aDate;
			}

			/// <summary>
			/// Performs only a shallow copy
			/// </summary>
			/// <returns></returns>
			public Debtors Clone()
			{
				return this.MemberwiseClone() as Debtors;
			}

			public string Debtorname
			{
				get
				{
					return DebtorName;
				}
				set
				{
					SetProperty(ref DebtorName, value); ;
				}
			}

			public string Initialvalue
			{
				get
				{
					return InitialValue;
				}
				set
				{
					SetProperty(ref InitialValue, value);
				}
			}


			public string Debtbalance
			{
				get
				{
					return DebtBalance;
				}
				set
				{
					SetProperty(ref DebtBalance, value);
				}
			}

			public string date
			{
				get
				{
					return Date;
				}
				set
				{
					SetProperty(ref Date, value);
				}
			}


	}
}

