Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Interfaces

Public Class Home

  Private ReadOnly Property _navigator As INavigationManager
  Private ReadOnly Property _login As LoginAbstract

  Public Property Usuario As String
    Get
      Dim userName As String = lblUsuario.Text.Split("|").Last()
      Return userName
    End Get
    Set(value As String)
      lblUsuario.Text = $"Usuário | {value}"
    End Set
  End Property
  Public Property ExpiraEm As Date
    Get
      Dim stringDateTime As String = lblExpiracao.Text.Split("|").Last().Trim()
      Return Date.Parse(stringDateTime)
    End Get
    Set(value As Date)
      lblExpiracao.Text = $"Expira em | {value.ToLongTimeString}"
    End Set
  End Property

  Public Sub New(navigator As INavigationManager, login As LoginAbstract)
    InitializeComponent()
    _navigator = navigator
    _login = login

    DataBindings.Add(NameOf(Usuario), _login, "UserName", True, DataSourceUpdateMode.OnValidation)
    DataBindings.Add(NameOf(ExpiraEm), _login, "Jwtoken.ValidTo", True, DataSourceUpdateMode.OnValidation)

    AddHandler btnPessoa.Click, Sub() _navigator.ShowPage("frmPessoa")
    AddHandler btnEndereco.Click, Sub() _navigator.ShowPage("frmEndereco")
    AddHandler Load, AddressOf _login.IsAuthenticated
    AddHandler btnLogout.Click, AddressOf _login.SignOut
  End Sub
End Class