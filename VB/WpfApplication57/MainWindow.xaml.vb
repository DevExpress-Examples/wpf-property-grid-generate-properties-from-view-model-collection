Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication57

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class PropertyDefinitionTemplateSelector
        Inherits DataTemplateSelector

        Public Property PropertyTemplate As DataTemplate

        Public Property CollectionTemplate As DataTemplate

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim [property] As [Property] = CType(item, [Property])
            If Not String.IsNullOrEmpty([property].CollectionName) Then Return CollectionTemplate
            Return PropertyTemplate
        End Function
    End Class

    Public Class ViewModel
        Inherits ViewModelBase

        Public Property EditObject As Employee

        Public Property Properties As ObservableCollection(Of [Property])

        Public Sub New()
            EditObject = New Employee() With {.FirstName = "John", .LastName = "Smith", .Position = "Senior Developer", .BirthDate = New DateTime(1987, 12, 15), .PreviousPositions = New Positions() From {"Junior Developer", "Middle Developer"}}
            Properties = New ObservableCollection(Of [Property]) From {New [Property]() With {.Name = "FirstName"}, New [Property]() With {.Name = "LastName"}, New [Property]() With {.Name = "Position"}, New [Property]() With {.Name = "BirthDate"}, New [Property]() With {.CollectionName = "PreviousPositions"}}
        End Sub
    End Class

    Public Class [Property]

        Public Property Name As String

        Public Property CollectionName As String
    End Class

    Public Class Employee

        Public Property FirstName As String

        Public Property LastName As String

        Public Property BirthDate As Date

        Public Property Position As String

        Public Property PreviousPositions As Positions
    End Class

    Public Class Positions
        Inherits List(Of String)

    End Class
End Namespace
