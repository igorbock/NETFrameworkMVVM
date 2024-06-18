Imports System.ComponentModel
Imports EntityFrameworkLib.Models

Public Class UscDataGridViewPessoas
  Implements INotifyPropertyChanged

  Private _pessoa As Pessoa
  Public Property Pessoa As Pessoa
    Get
      Return _pessoa
    End Get
    Set(value As Pessoa)
      _pessoa = value
      OnPropertyChanged(NameOf(Pessoa))
    End Set
  End Property

  Public Property DataSource() As Object
    Get
      Return DataGridViewPessoas.DataSource
    End Get
    Set(value As Object)
      DataGridViewPessoas.DataSource = value
      OnPropertyChanged(NameOf(DataSource))
    End Set
  End Property

  Private Sub DataGridViewPessoas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPessoas.SelectionChanged
    Try
      Dim row As Integer = DataGridViewPessoas.SelectedRows(0).Index
      Pessoa = CType(DataGridViewPessoas.Rows(row).DataBoundItem, Pessoa)
    Catch ex As Exception

    End Try
  End Sub

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
  Protected Sub OnPropertyChanged(propertyName As String)
    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub
End Class
