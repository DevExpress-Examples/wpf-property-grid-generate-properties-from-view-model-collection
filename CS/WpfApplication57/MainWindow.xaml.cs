using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication57 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class PropertyDefinitionTemplateSelector : DataTemplateSelector {
        public DataTemplate PropertyTemplate { get; set; }
        public DataTemplate CollectionTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            Property property = (Property)item;
            if (!string.IsNullOrEmpty(property.CollectionName))
                return CollectionTemplate;
            return PropertyTemplate;
        }
    }
    public class ViewModel : ViewModelBase{
        public Employee EditObject { get; set; }
        public ObservableCollection<Property> Properties { get; set; }
        public ViewModel() {
            EditObject = new Employee() {
                FirstName = "John",
                LastName = "Smith",
                Position = "Senior Developer",
                BirthDate = new DateTime(1987, 12, 15),
                PreviousPositions = new Positions() { "Junior Developer", "Middle Developer" }
            };
            Properties = new ObservableCollection<Property> {
                new Property() { Name = "FirstName" },
                new Property() { Name = "LastName" },
                new Property() { Name = "Position" },
                new Property() { Name = "BirthDate" },
                new Property() { CollectionName = "PreviousPositions" }
            };
        }
    }
    public class Property {
        public string Name { get; set; }
        public string CollectionName { get; set; }
    }
    public class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public Positions PreviousPositions { get; set; }
    }
    public class Positions : List<string> {
    }
}
