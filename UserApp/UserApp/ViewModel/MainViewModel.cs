using UserApp.Model;

namespace UserApp.ViewModel
{
    class MainViewModel
    {
        public User User { get; set; }
        public MainViewModel()
        {
            User = new User() { Name = "Cortana" };
        }
        public void ChangeName(string newName)
        {
            User.Name = newName;
        }
    }
}