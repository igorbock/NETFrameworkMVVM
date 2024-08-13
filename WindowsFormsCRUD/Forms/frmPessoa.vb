Imports EntityFrameworkLib.Models.DTOs
Imports VisualBasicLib.ViewModels
Imports VisualBasicLib.Extensions.PessoaExtensions
Imports VisualBasicLib.Abstracts
Imports EntityFrameworkLib.Models

Public Class frmPessoa
  Private ReadOnly Property _viewModelPessoa As PessoaViewModel
  Public Property Enderecos As Object
    Get
      Return bsEndereco.DataSource
    End Get
    Set(value As Object)
      bsEndereco.DataSource = value
    End Set
  End Property

  Public Sub New(viewModelPessoa As TypeTViewModel(Of Pessoa))
    InitializeComponent()

    _viewModelPessoa = viewModelPessoa

    txtNome.TextBox.DataBindings.Add("Text", _viewModelPessoa, "CurrentItem.Nome", True, DataSourceUpdateMode.OnPropertyChanged)
    txtCPF.MaskedTextBox.DataBindings.Add("Text", _viewModelPessoa, "CurrentItem.CPF", True, DataSourceUpdateMode.OnPropertyChanged)
    txtRG.MaskedTextBox.DataBindings.Add("Text", _viewModelPessoa, "CurrentItem.RG", True, DataSourceUpdateMode.OnPropertyChanged)
    txtNascimento.DataBindings.Add("Text", _viewModelPessoa, "CurrentItem.Nascimento", True, DataSourceUpdateMode.OnPropertyChanged)
    cmbEndereco.DataBindings.Add("SelectedValue", _viewModelPessoa, "CurrentItem.IdEndereco", True, DataSourceUpdateMode.OnPropertyChanged)
    cmbEndereco.DataBindings.Add("DataSource", _viewModelPessoa, "Enderecos", True, DataSourceUpdateMode.OnPropertyChanged)
    gPessoas.DataBindings.Add("DataSource", _viewModelPessoa, NameOf(_viewModelPessoa.Pessoas), True, DataSourceUpdateMode.OnPropertyChanged)

    txtNome.TextBox.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtCPF.MaskedTextBox.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtRG.MaskedTextBox.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    txtNascimento.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    cmbEndereco.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    gPessoas.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableListView), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("NewEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonInsertVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("EditEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonEditVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("RemoveEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonDeleteVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("SaveEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonSaveVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("CancelEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonCancelVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("PrintEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("PreviousEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("NextEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("CloseEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonCloseVisible), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler _viewModelPessoa.ErrorOcurred, AddressOf Classes.FormUtils.ShowError
    AddHandler _viewModelPessoa.QuestionOcurred, Sub(sender, e) e.Iteration = Classes.FormUtils.ShowYesNoQuestion(sender, e)

    AddHandler btnCRUD.NewEvent, Sub() _viewModelPessoa.CreateCommand.Execute(Nothing)
    AddHandler btnCRUD.EditEvent, Sub() _viewModelPessoa.UpdateCommand.Execute(Nothing)
    AddHandler btnCRUD.RemoveEvent, Sub() _viewModelPessoa.DeleteCommand.Execute(Nothing)
    AddHandler btnCRUD.SaveEvent, Sub() _viewModelPessoa.SaveCommand.Execute(Nothing)
    AddHandler btnCRUD.CancelEvent, Sub() _viewModelPessoa.CancelCommand.Execute(Nothing)
    AddHandler btnCRUD.CloseEvent, Sub() _viewModelPessoa.CloseCommand.Execute(Nothing)
    AddHandler gPessoas.CellClick, Sub(sender, e) CellClick(e, gPessoas)

    Visible = True
  End Sub

  Private Sub CellClick(e As DataGridViewCellEventArgs, grid As DataGridView)
    If e.RowIndex >= 0 Then
      Dim linhaSelecionada As DataGridViewRow = grid.Rows(e.RowIndex)
      Dim typeTInstance As PessoaDTO = linhaSelecionada.DataBoundItem
      _viewModelPessoa.CurrentItem = typeTInstance.ToPessoa()
      txtNome.Refresh()
      txtCPF.Refresh()
      txtRG.Refresh()
      txtNascimento.Refresh()
      cmbEndereco.Refresh()
    End If
  End Sub
  Private Sub LoadForm(sender As Object, e As EventArgs) Handles Me.Load
    _viewModelPessoa.LoadCommand.Execute(Nothing)
  End Sub
End Class
