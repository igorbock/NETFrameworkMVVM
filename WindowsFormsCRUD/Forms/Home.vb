Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Interfaces

Public Class Home

  Private ReadOnly Property _navigator As INavigationManager
  Private ReadOnly Property _login As LoginAbstract

  Public Sub New(navigator As INavigationManager, login As LoginAbstract)
    InitializeComponent()
    _navigator = navigator 'New NavigatorWindowsForm()
    _login = login

    AddHandler btnPessoa.Click, Sub() _navigator.ShowPage("frmPessoa")
    AddHandler btnEndereco.Click, Sub() _navigator.ShowPage("frmEndereco")
    AddHandler Load, AddressOf VerifyLogin
    AddHandler btnLogout.Click, AddressOf _login.SignOut
  End Sub
  Private Sub VerifyLogin()
    _login.IsAuthenticated()
    If String.IsNullOrEmpty(_login.User.Nome) Then
      lblUsuario.Text = "Usuário |"
    Else
      lblUsuario.Text = $"Usuário | {_login.User.Nome}"
    End If
  End Sub
End Class