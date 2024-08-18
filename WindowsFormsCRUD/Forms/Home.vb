Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Interfaces

Public Class Home

  Private ReadOnly Property _navigator As INavigationManager
  Private ReadOnly Property _login As LoginAbstract

  Public Property Usuario As String
    Get
      Return lblUsuario.Text
    End Get
    Set(value As String)
      lblUsuario.Text = $"Usuário | {value}"
    End Set
  End Property

  Public Sub New(navigator As INavigationManager, login As LoginAbstract)
    InitializeComponent()
    _navigator = navigator 'New NavigatorWindowsForm()
    _login = login

    DataBindings.Add(NameOf(Usuario), _login, "User.Nome", True, DataSourceUpdateMode.Never)

    AddHandler btnPessoa.Click, Sub() _navigator.ShowPage("frmPessoa")
    AddHandler btnEndereco.Click, Sub() _navigator.ShowPage("frmEndereco")
    AddHandler Load, AddressOf VerifyLogin
    AddHandler btnLogout.Click, AddressOf _login.SignOut
  End Sub
  Private Sub VerifyLogin()
    _login.IsAuthenticated()
  End Sub
End Class