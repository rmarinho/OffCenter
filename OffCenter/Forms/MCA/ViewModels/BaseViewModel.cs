using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MCA
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		private bool _isbusy;

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected bool SetField<T>(ref T field, T value, Action action = null, IEnumerable<string> additionalprops = null, [CallerMemberName] string propertyName = null)
		{

			if (EqualityComparer<T>.Default.Equals(field, value))
				return false;
			field = value;
			OnPropertyChanged(propertyName);
			//Check for related fields
			if (additionalprops != null)
			{
				foreach (var s in additionalprops)
					OnPropertyChanged(s);
			};

			if (action != null)
				action();
			return true;
		}

		public bool IsBusy
		{
			get
			{
				return _isbusy;
			}
			set
			{
				SetField(ref _isbusy, value);
			}
		}
	}
}
