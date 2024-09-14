Imports EntityFrameworkLib.Interfaces
Imports VisualBasicLib.Abstracts
Imports WindowsFormsCRUD.Classes

Public MustInherit Class AbstractForm(Of TypeT As IEntity)
  Inherits Form

  Private ReadOnly Property _viewModel As TypeTViewModel(Of TypeT)
  Private Property _navigator As UscCRUD

  Public Sub New()
    MyBase.New()

    _navigator.DataBindings.Add("NewEnabled", _viewModel, NameOf(_viewModel.ButtonInsertVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("EditEnabled", _viewModel, NameOf(_viewModel.ButtonEditVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("RemoveEnabled", _viewModel, NameOf(_viewModel.ButtonDeleteVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("SaveEnabled", _viewModel, NameOf(_viewModel.ButtonSaveVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("CancelEnabled", _viewModel, NameOf(_viewModel.ButtonCancelVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("PrintEnabled", _viewModel, NameOf(_viewModel.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("PreviousEnabled", _viewModel, NameOf(_viewModel.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("NextEnabled", _viewModel, NameOf(_viewModel.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    _navigator.DataBindings.Add("CloseEnabled", _viewModel, NameOf(_viewModel.ButtonCloseVisible), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler _viewModel.ErrorOcurred, AddressOf ShowError
    AddHandler _viewModel.QuestionOcurred, Sub(sender, e) e.Iteration = ShowYesNoQuestion(sender, e)

    AddHandler _navigator.NewEvent, Sub() _viewModel.CreateCommand.Execute(Nothing)
    AddHandler _navigator.EditEvent, Sub() _viewModel.UpdateCommand.Execute(Nothing)
    AddHandler _navigator.RemoveEvent, Sub() _viewModel.DeleteCommand.Execute(Nothing)
    AddHandler _navigator.SaveEvent, Sub() _viewModel.SaveCommand.Execute(Nothing)
    AddHandler _navigator.CancelEvent, Sub() _viewModel.CancelCommand.Execute(Nothing)
    AddHandler _navigator.CloseEvent, Sub() _viewModel.CloseCommand.Execute(Nothing)
  End Sub

  Protected MustOverride Sub SetNavigator(navigator As UscCRUD)
End Class
