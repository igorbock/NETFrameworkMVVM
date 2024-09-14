Imports EntityFrameworkLib.Models
Imports VisualBasicLib.Abstracts
Imports WindowsFormsLib.Classes

Public Class frmEndereco
  Private ReadOnly Property _viewModelEndereco As TypeTViewModel(Of Endereco)

  Public Sub New(viewModel As TypeTViewModel(Of Endereco))
    InitializeComponent()

    _viewModelEndereco = viewModel
    Me.Visible = True

    txtRua.TextBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Rua", True, DataSourceUpdateMode.OnPropertyChanged)
    txtNumero.NumericBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Numero", True, DataSourceUpdateMode.OnPropertyChanged)
    txtCidade.TextBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Cidade", True, DataSourceUpdateMode.OnPropertyChanged)
    txtEstado.TextBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Estado", True, DataSourceUpdateMode.OnPropertyChanged)
    gEnderecos.DataBindings.Add("DataSource", _viewModelEndereco, "ListTypeT", True, DataSourceUpdateMode.OnPropertyChanged)

    txtRua.TextBox.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtNumero.NumericBox.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtCidade.TextBox.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtEstado.TextBox.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    gEnderecos.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableListView), True, DataSourceUpdateMode.OnPropertyChanged)

    btnCRUD.DataBindings.Add("NewEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonInsertVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("EditEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonEditVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("RemoveEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonDeleteVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("SaveEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonSaveVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("CancelEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonCancelVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("RefreshEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonRefreshVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("PrintEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("PreviousEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("NextEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("CloseEnabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonCloseVisible), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler _viewModelEndereco.ErrorOcurred, AddressOf ShowError
    AddHandler _viewModelEndereco.QuestionOcurred, Sub(sender, e) e.Iteration = ShowYesNoQuestion(sender, e)

    AddHandler btnCRUD.NewEvent, Sub() _viewModelEndereco.CreateCommand.Execute(Nothing)
    AddHandler btnCRUD.EditEvent, Sub() _viewModelEndereco.UpdateCommand.Execute(Nothing)
    AddHandler btnCRUD.RemoveEvent, Sub() _viewModelEndereco.DeleteCommand.Execute(Nothing)
    AddHandler btnCRUD.SaveEvent, Sub() _viewModelEndereco.SaveCommand.Execute(Nothing)
    AddHandler btnCRUD.CancelEvent, Sub() _viewModelEndereco.CancelCommand.Execute(Nothing)
    AddHandler btnCRUD.CloseEvent, Sub() _viewModelEndereco.CloseCommand.Execute(Nothing)
    AddHandler gEnderecos.CellClick, Sub(sender, e) CellClick(e, gEnderecos)
  End Sub

  Private Sub CellClick(e As DataGridViewCellEventArgs, grid As DataGridView)
    If e.RowIndex >= 0 Then
      Dim linhaSelecionada As DataGridViewRow = grid.Rows(e.RowIndex)
      Dim typeTInstance As Endereco = linhaSelecionada.DataBoundItem
      _viewModelEndereco.CurrentItem = typeTInstance
      txtCidade.Refresh()
      txtEstado.Refresh()
      txtNumero.Refresh()
      txtRua.Refresh()
    End If
  End Sub
  Private Sub LoadForm(sender As Object, e As EventArgs) Handles Me.Load
    _viewModelEndereco.LoadCommand.Execute(Nothing)
  End Sub
End Class