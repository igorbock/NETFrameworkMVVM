Imports VisualBasicLib.Interfaces

Public Class Home

  Private ReadOnly Property _navigator As INavigationManager

  Public Sub New()
    InitializeComponent()
  End Sub

  Public Sub New(navigator As INavigationManager)
    InitializeComponent()
    _navigator = navigator 'New NavigatorWindowsForm()

    AddHandler btnPessoa.Click, Sub() _navigator.ShowPage("frmPessoa")
    AddHandler btnEndereco.Click, Sub() _navigator.ShowPage("frmEndereco")
  End Sub
End Class