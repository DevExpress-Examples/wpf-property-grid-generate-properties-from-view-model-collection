using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication57
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class MyViewModel
    {
        public Item SomeObject
        {
            get;
            set;
        }
        public ObservableCollection<Property> Properties
        {
            get;
            set;
        }
        public MyViewModel()
        {
            SomeObject = new Item() { Property1 = "Value1", Property2 = "Value2", Property3 = "Value3", Property4 = "Value4", Property5 = "Value5", };
            Properties = new ObservableCollection<Property>();
            Properties.Add(new Property() { Name = "Property1" });
            Properties.Add(new Property() { Name = "Property3" });
            Properties.Add(new Property() { Name = "Property5" });
        }
    }
    public class Property
    {
        public string Name
        {
            get;
            set;
        }
    }
    public class Item
    {
        public string Property1
        {
            get;
            set;
        }
        public string Property2
        {
            get;
            set;
        }
        public string Property3
        {
            get;
            set;
        }
        public string Property4
        {
            get;
            set;
        }
        public string Property5
        {
            get;
            set;
        }
    }
}
