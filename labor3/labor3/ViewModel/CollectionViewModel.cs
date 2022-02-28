using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using labor3.Model;

namespace labor3.ViewModel
{
    public class CollectionViewModel
    {
        //public List<User> Users { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Administrator" , Age=28 });
            Users.Add(new User() { Name = "root", Age = 27 });
            Users.Add(new User() { Name = "Blackhawk" , Age = 23 });
            Users.Add(new User() { Name = "User001", Age = 43 });
            Users.Add(new User() { Name = "Cortana", Age = 22 });
        }
    }

}
