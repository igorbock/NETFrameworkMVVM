Imports VisualBasicLib.ViewModels
Imports WindowsFormsCRUD.Navigator

Public Class frmPessoa
  Private ReadOnly Property _viewModelPessoa As PessoaViewModel

  Public Sub New()
    InitializeComponent()

    _viewModelPessoa = New PessoaViewModel(New NavigatorWindowsForm())

    TextBoxNome.DataBindings.Add("Text", _viewModelPessoa, "Nome", True, DataSourceUpdateMode.OnPropertyChanged)
    MaskedTextBoxCPF.DataBindings.Add("Text", _viewModelPessoa, "CPF", True, DataSourceUpdateMode.OnPropertyChanged)
    MaskedTextBoxRG.DataBindings.Add("Text", _viewModelPessoa, "RG", True, DataSourceUpdateMode.OnPropertyChanged)
    TextBoxEndereco.DataBindings.Add("Text", _viewModelPessoa, "Endereco", True, DataSourceUpdateMode.OnPropertyChanged)
    DateTimePickerNascimento.DataBindings.Add("Text", _viewModelPessoa, "Nascimento", True, DataSourceUpdateMode.OnPropertyChanged)
    UscDataGridViewPessoas.DataBindings.Add("DataSource", _viewModelPessoa, "ListTypeT", True, DataSourceUpdateMode.OnPropertyChanged)
    UscDataGridViewPessoas.DataBindings.Add("Pessoa", _viewModelPessoa, "CurrentItem", True, DataSourceUpdateMode.OnPropertyChanged)

    ButtonNovo.DataBindings.Add("Enabled", _viewModelPessoa, "ButtonInsertVisible", True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonEditar.DataBindings.Add("Enabled", _viewModelPessoa, "ButtonEditVisible", True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonCancelar.DataBindings.Add("Enabled", _viewModelPessoa, "ButtonCancelVisible", True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonSalvar.DataBindings.Add("Enabled", _viewModelPessoa, "ButtonSaveVisible", True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonExcluir.DataBindings.Add("Enabled", _viewModelPessoa, "ButtonDeleteVisible", True, DataSourceUpdateMode.OnPropertyChanged)
    GroupBoxPessoa.DataBindings.Add("Enabled", _viewModelPessoa, "EnableControl", True, DataSourceUpdateMode.OnPropertyChanged)
    UscDataGridViewPessoas.DataGridViewPessoas.DataBindings.Add("Enabled", _viewModelPessoa, "EnableListView", True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler _viewModelPessoa.ErrorOcurred, AddressOf Classes.FormUtils.ShowError
    AddHandler ButtonNovo.Click, Sub() _viewModelPessoa.CreateCommand.Execute(Nothing)
    AddHandler ButtonExcluir.Click, Sub() _viewModelPessoa.DeleteCommand.Execute(Nothing)
    AddHandler ButtonSalvar.Click, Sub() _viewModelPessoa.SaveCommand.Execute(Nothing)
    AddHandler ButtonEditar.Click, Sub() _viewModelPessoa.UpdateCommand.Execute(Nothing)
    AddHandler ButtonCancelar.Click, Sub() _viewModelPessoa.CancelCommand.Execute(Nothing)
    AddHandler ButtonAdicionarEndereco.Click, Sub() _viewModelPessoa.AddEnderecoCommand.Execute(Nothing)
  End Sub
End Class
