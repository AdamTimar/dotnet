using System.Collections.ObjectModel;
using UserApp.Model;
namespace UserApp.ViewModel
{
    public class CollectionViewModel
    {
        //public List<User> Users { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Datas = "Administrator, 11" });
            Users.Add(new User() { Datas = "root, 52" });
            Users.Add(new User() { Datas = "Blackhawk, 32" });
            Users.Add(new User() { Datas = "User001, 45" });
            Users.Add(new User() { Datas = "Cortana, 22" });
        }
    }
}