Imports EntityFrameworkLib.Models
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.ViewModels
Imports WindowsFormsCRUD.Navigator

Public Class frmEndereco
  Private ReadOnly Property _viewModelEndereco As TypeTViewModel(Of Endereco)

  Public Sub New()
    InitializeComponent()

    _viewModelEndereco = New EnderecoViewModel(New NavigatorWindowsForm)

    txtRua.TextBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Rua", True, DataSourceUpdateMode.OnPropertyChanged)
    txtNumero.TextBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Numero", True, DataSourceUpdateMode.OnPropertyChanged)
    txtCidade.TextBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Cidade", True, DataSourceUpdateMode.OnPropertyChanged)
    txtEstado.TextBox.DataBindings.Add("Text", _viewModelEndereco, "CurrentItem.Estado", True, DataSourceUpdateMode.OnPropertyChanged)
    gEnderecos.DataBindings.Add("DataSource", _viewModelEndereco, "ListTypeT", True, DataSourceUpdateMode.OnPropertyChanged)

    btnNovo.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonInsertVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnEditar.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonEditVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCancelar.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonCancelVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnSalvar.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonSaveVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnExcluir.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.ButtonDeleteVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    txtRua.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtNumero.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtCidade.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtEstado.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    gEnderecos.DataBindings.Add("Enabled", _viewModelEndereco, NameOf(_viewModelEndereco.EnableListView), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler _viewModelEndereco.ErrorOcurred, AddressOf Classes.FormUtils.ShowError
    AddHandler _viewModelEndereco.QuestionOcurred, Sub(sender, e) e.Iteration = Classes.FormUtils.ShowYesNoQuestion(sender, e)
    AddHandler btnNovo.Click, Sub() _viewModelEndereco.CreateCommand.Execute(Nothing)
    AddHandler btnExcluir.Click, Sub() _viewModelEndereco.DeleteCommand.Execute(Nothing)
    AddHandler btnSalvar.Click, Sub() _viewModelEndereco.SaveCommand.Execute(Nothing)
    AddHandler btnEditar.Click, Sub() _viewModelEndereco.UpdateCommand.Execute(Nothing)
    AddHandler btnCancelar.Click, Sub() _viewModelEndereco.CancelCommand.Execute(Nothing)
    AddHandler gEnderecos.CellClick, Sub(sender, e) CellClick(e, gEnderecos)
  End Sub

  Private Sub SelectCurrentItem()
    Try
      _viewModelEndereco.CurrentItem = Classes.FormUtils.SelectTypeT(Of Endereco)(gEnderecos)

    Catch ex As Exception
    End Try
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
End Class