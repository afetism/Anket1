using Anket1.Models;
using Anket1.Repository;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Anket1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private User _user { get; set; } = new();
        public User User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<User> Users { get; set; }   = new ObservableCollection<User>();
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public string LoadTxt { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;
        }

       
        public event PropertyChangedEventHandler? PropertyChanged;

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
          
                JsonHandler<User> saveData = new("users.json");

            saveData.Items.Add(User);
                saveData.SavaData();
            MessageBox.Show("Save All Data");
        }


        private void Button_Click_Load(object sender, RoutedEventArgs e)
        {

            JsonHandler<User> saveData = new("users.json");
            foreach(User user in saveData.Items)
            {
                if(LoadTxt ==user.Name)
                {
                    User=user;
                    MessageBox.Show("Founded User!");
                }
            }

        }

     

    }
}