Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Interfaces

Public Class frmNovoUsuario
  Private _navigation As INavigationManager
  Public Property Navigation() As INavigationManager
    Get
      Return _navigation
    End Get
    Set(value As INavigationManager)
      _navigation = value
    End Set
  End Property
  Private ReadOnly _login As LoginAbstract
  Public Sub New(navigation As INavigationManager, login As LoginAbstract)
    InitializeComponent()

    Me.Navigation = navigation
    _login = login

    txtNome.TextBox.DataBindings.Add("Text", _login, "RegistroDTO.Login", True, DataSourceUpdateMode.OnValidation)
    txtSenha.TextBox.DataBindings.Add("Text", _login, "RegistroDTO.Senha", True, DataSourceUpdateMode.OnValidation)
    txtConfirmaSenha.TextBox.DataBindings.Add("Text", _login, "RegistroDTO.ConfirmaSenha", True, DataSourceUpdateMode.OnValidation)

    AddHandler btnConfirmar.Click, AddressOf _login.SignUp
    AddHandler btnSair.Click, AddressOf Close
  End Sub
End Class