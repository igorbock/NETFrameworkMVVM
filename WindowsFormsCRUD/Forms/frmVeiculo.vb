Imports EntityFrameworkLib.Interfaces
Imports EntityFrameworkLib.Models
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.ViewModels
Imports WindowsFormsCRUD.Navigator

Public Class frmVeiculo
  Private ReadOnly Property _formNumber As Integer
  Private ReadOnly Property _viewModel As TypeTViewModel(Of Pessoa)

  Public Sub New()
    InitializeComponent()
  End Sub

  Public Sub New(number As Integer)
    Me.New()

    _formNumber = number
    '_viewModel = New PessoaViewModel(New NavigatorWindowsForm)

    navigator.DataBindings.Add("NewEnabled", _viewModel, NameOf(_viewModel.ButtonInsertVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("EditEnabled", _viewModel, NameOf(_viewModel.ButtonEditVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("RemoveEnabled", _viewModel, NameOf(_viewModel.ButtonDeleteVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("SaveEnabled", _viewModel, NameOf(_viewModel.ButtonSaveVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("CancelEnabled", _viewModel, NameOf(_viewModel.ButtonCancelVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("PrintEnabled", _viewModel, NameOf(_viewModel.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("PreviousEnabled", _viewModel, NameOf(_viewModel.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("NextEnabled", _viewModel, NameOf(_viewModel.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    navigator.DataBindings.Add("CloseEnabled", _viewModel, NameOf(_viewModel.ButtonCloseVisible), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler navigator.NewEvent, Sub() _viewModel.CreateCommand.Execute(Nothing)
    AddHandler navigator.EditEvent, Sub() _viewModel.UpdateCommand.Execute(Nothing)
    AddHandler navigator.RemoveEvent, Sub() _viewModel.DeleteCommand.Execute(Nothing)
    AddHandler navigator.SaveEvent, Sub() _viewModel.SaveCommand.Execute(Nothing)
    AddHandler navigator.CancelEvent, Sub() _viewModel.CancelCommand.Execute(Nothing)
    AddHandler navigator.CloseEvent, Sub() _viewModel.CloseCommand.Execute(Nothing)
  End Sub
End Class