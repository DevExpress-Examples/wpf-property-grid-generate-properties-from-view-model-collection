Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication57
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class MyViewModel
        Public Property SomeObject() As Item
        Public Property Properties() As ObservableCollection(Of [Property])
        Public Sub New()
            SomeObject = New Item() With {.Property1 = "Value1", .Property2 = "Value2", .Property3 = "Value3", .Property4 = "Value4", .Property5 = "Value5"}
            Properties = New ObservableCollection(Of [Property])()
            Properties.Add(New [Property]() With {.Name = "Property1"})
            Properties.Add(New [Property]() With {.Name = "Property3"})
            Properties.Add(New [Property]() With {.Name = "Property5"})
        End Sub
    End Class
    Public Class [Property]
        Public Property Name() As String
    End Class
    Public Class Item
        Public Property Property1() As String
        Public Property Property2() As String
        Public Property Property3() As String
        Public Property Property4() As String
        Public Property Property5() As String
    End Class
End Namespace
