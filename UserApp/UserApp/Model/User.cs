using System.ComponentModel;

namespace UserApp.Model
{
    public class User : INotifyPropertyChanged
    {
        private string name;
        private int age;
        public string Datas { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"
               ));
                //OnPropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"
               ));
                //OnPropertyChanged("Name");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));//}
    }

}