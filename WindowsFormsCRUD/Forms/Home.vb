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
  End Sub
End Class