using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SelectedItemsTestApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty MyListProperty = DependencyProperty.Register("MyList",
            typeof(List<string>), typeof(MainWindow), new PropertyMetadata(default(List<string>)));
        public List<string> MyList { get { return (List<string>)GetValue(MyListProperty); } set { SetValue(MyListProperty, value); } }

        public static readonly DependencyProperty ObservableListProperty = DependencyProperty.Register("ObservableList",
            typeof(ObservableCollection<string>), typeof(MainWindow), new PropertyMetadata(default(ObservableCollection<string>)));
        public ObservableCollection<string> ObservableList { get { return (ObservableCollection<string>)GetValue(ObservableListProperty); } set { SetValue(ObservableListProperty, value); } }
        public static readonly DependencyProperty OtherObservableListProperty = DependencyProperty.Register("OtherObservableList",
            typeof (ObservableCollection<string>), typeof (MainWindow), new PropertyMetadata(default(ObservableCollection<string>)));
        public ObservableCollection<string> OtherObservableList { get { return (ObservableCollection<string>) GetValue(OtherObservableListProperty); } set { SetValue(OtherObservableListProperty, value); } }
        public MainWindow()
        {
            MyList = new List<string>(new[] { "foo", "bar", "baz" });
            ObservableList = new ObservableCollection<string>();
            OtherObservableList = new ObservableCollection<string>();
            InitializeComponent();
        }
    }
}
