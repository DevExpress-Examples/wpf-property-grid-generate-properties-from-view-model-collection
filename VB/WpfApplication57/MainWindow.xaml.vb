Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication57

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class MyViewModel

        Public Property SomeObject As Item

        Public Property Properties As ObservableCollection(Of [Property])

        Public Sub New()
            SomeObject = New Item() With {.Property1 = "Value1", .Property2 = "Value2", .Property3 = "Value3", .Property4 = "Value4", .Property5 = "Value5"}
            Properties = New ObservableCollection(Of [Property])()
            Properties.Add(New [Property]() With {.Name = "Property1"})
            Properties.Add(New [Property]() With {.Name = "Property3"})
            Properties.Add(New [Property]() With {.Name = "Property5"})
        End Sub
    End Class

    Public Class [Property]

        Public Property Name As String
    End Class

    Public Class Item

        Public Property Property1 As String

        Public Property Property2 As String

        Public Property Property3 As String

        Public Property Property4 As String

        Public Property Property5 As String
    End Class
End Namespace
