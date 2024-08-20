Imports VisualBasicLib.Abstracts

Public Class frmLogin
  Private ReadOnly Property _login As LoginAbstract

  Public Sub New(login As LoginAbstract)
    InitializeComponent()

    _login = login

    txtUser.TextBox.DataBindings.Add("Text", _login, "User.Nome", True, DataSourceUpdateMode.OnPropertyChanged)
    txtSenha.TextBox.DataBindings.Add("Text", _login, "User.HashSenha", True, DataSourceUpdateMode.OnPropertyChanged)

    AddHandler Load, AddressOf _login.HasUserInDatabase
    AddHandler btnEntrar.Click, AddressOf _login.SignIn
    AddHandler btnSair.Click, AddressOf CloseApp
  End Sub

  Private Sub CloseApp()
    Dim result As DialogResult = MessageBox.Show("Você deseja fechar o aplicativo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    If result = DialogResult.No Then Exit Sub
    Application.Exit()
  End Sub
End Class