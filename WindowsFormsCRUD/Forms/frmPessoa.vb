Imports VisualBasicLib.ViewModels
Imports WindowsFormsCRUD.Navigator

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

  Public Sub New()
    InitializeComponent()

    _viewModelPessoa = New PessoaViewModel(New NavigatorWindowsForm())

    btnCRUD.DataBindings.Add("NewEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonInsertVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("EditEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonEditVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("RemoveEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonDeleteVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("SaveEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonSaveVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("CancelEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonCancelVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("PrintEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("PreviousEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    btnCRUD.DataBindings.Add("NextEnabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)

    TextBoxNome.DataBindings.Add("Text", _viewModelPessoa, NameOf(_viewModelPessoa.Nome), True, DataSourceUpdateMode.OnPropertyChanged)
    MaskedTextBoxCPF.DataBindings.Add("Text", _viewModelPessoa, NameOf(_viewModelPessoa.CPF), True, DataSourceUpdateMode.OnPropertyChanged)
    MaskedTextBoxRG.DataBindings.Add("Text", _viewModelPessoa, NameOf(_viewModelPessoa.RG), True, DataSourceUpdateMode.OnPropertyChanged)
    DateTimePickerNascimento.DataBindings.Add("Text", _viewModelPessoa, NameOf(_viewModelPessoa.Nascimento), True, DataSourceUpdateMode.OnPropertyChanged)
    UscDataGridViewPessoas.DataBindings.Add("DataSource", _viewModelPessoa, NameOf(_viewModelPessoa.ListTypeT), True, DataSourceUpdateMode.OnPropertyChanged)
    UscDataGridViewPessoas.DataBindings.Add("Pessoa", _viewModelPessoa, NameOf(_viewModelPessoa.CurrentItem), True, DataSourceUpdateMode.OnPropertyChanged)
    DataBindings.Add("Enderecos", _viewModelPessoa, NameOf(_viewModelPessoa.Enderecos), True, DataSourceUpdateMode.OnPropertyChanged)
    cmbEndereco.DataBindings.Add("SelectedValue", _viewModelPessoa, NameOf(_viewModelPessoa.Endereco), True, DataSourceUpdateMode.OnPropertyChanged)

    ButtonNovo.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonInsertVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonEditar.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonEditVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonCancelar.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonCancelVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonSalvar.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonSaveVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    ButtonExcluir.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.ButtonDeleteVisible), True, DataSourceUpdateMode.OnPropertyChanged)
    GroupBoxPessoa.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableControl), True, DataSourceUpdateMode.OnPropertyChanged)
    UscDataGridViewPessoas.DataGridViewPessoas.DataBindings.Add("Enabled", _viewModelPessoa, NameOf(_viewModelPessoa.EnableListView), True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler _viewModelPessoa.ErrorOcurred, AddressOf Classes.FormUtils.ShowError
    AddHandler _viewModelPessoa.QuestionOcurred, Sub(sender, e) e.Iteration = Classes.FormUtils.ShowYesNoQuestion(sender, e)
    AddHandler Load, Sub() _viewModelPessoa.LoadCommand.Execute(Nothing)
    AddHandler ButtonNovo.Click, Sub() _viewModelPessoa.CreateCommand.Execute(Nothing)
    AddHandler ButtonExcluir.Click, Sub() _viewModelPessoa.DeleteCommand.Execute(Nothing)
    AddHandler ButtonSalvar.Click, Sub() _viewModelPessoa.SaveCommand.Execute(Nothing)
    AddHandler ButtonEditar.Click, Sub() _viewModelPessoa.UpdateCommand.Execute(Nothing)
    AddHandler ButtonCancelar.Click, Sub() _viewModelPessoa.CancelCommand.Execute(Nothing)
    AddHandler ButtonAdicionarEndereco.Click, Sub() _viewModelPessoa.AddEnderecoCommand.Execute(Nothing)

    AddHandler btnCRUD.NewEvent, Sub() _viewModelPessoa.CreateCommand.Execute(Nothing)
    AddHandler btnCRUD.EditEvent, Sub() _viewModelPessoa.UpdateCommand.Execute(Nothing)
    AddHandler btnCRUD.RemoveEvent, Sub() _viewModelPessoa.DeleteCommand.Execute(Nothing)
    AddHandler btnCRUD.SaveEvent, Sub() _viewModelPessoa.SaveCommand.Execute(Nothing)
    AddHandler btnCRUD.CancelEvent, Sub() _viewModelPessoa.CancelCommand.Execute(Nothing)
  End Sub
End Class
