using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace labor3.Model
{
    public class User : INotifyPropertyChanged
    {
        private string name;
        private int age;

        
        public string Name
        {
            get { return name; }
            set
            {
                name  = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                //OnPropertyChanged("Name");
            }
        }
        public int Age { get { return age; }
                set { age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age")); }
        }
        public string Full { get { return Name +"   "+ Age; }  }

        public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
 //}
 }
}