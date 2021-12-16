using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;

namespace FriendOrganizer.UI.ViewModel
{
	public class MainViewModel: ViewModelBase
	{
		private readonly IFriendDataService _friendDataService;
		private Friend _selectedFriend;

		public MainViewModel(IFriendDataService friendDataService)
		{
			this._friendDataService = friendDataService;
		}

		public void Load()
		{
			var friends = _friendDataService.GetAll();
			Friends.Clear();
			Friends = new ObservableCollection<Friend>(friends);
		}

		public ObservableCollection<Friend> Friends { get; set; }

		

		public Friend SelectedFriend
		{
			get => _selectedFriend;
			set
			{
				_selectedFriend = value;
				OnPropertyChanged();
			}
		}

	}
}
