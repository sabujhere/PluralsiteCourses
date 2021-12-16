using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
	public class FriendDataService : IFriendDataService
	{
		public IEnumerable<Friend> GetAll()
		{
			yield return new Friend(){FirstName = "Bob", LastName = "G"};
			yield return new Friend(){FirstName = "Martin", LastName = "K"};
			yield return new Friend(){FirstName = "Khurram", LastName = "A"};
		}
	}
}
