Imports VisualBasicLib.Interfaces
Imports WindowsFormsCRUD.Navigator

Public Class Home

  Private ReadOnly Property _navigator As INavigationManager

  Public Sub New()
    InitializeComponent()

    _navigator = New NavigatorWindowsForm()

    AddHandler btnPessoa.Click, Sub() _navigator.ShowPage("frmPessoa")
    AddHandler btnEndereco.Click, Sub() _navigator.ShowPage("frmEndereco")
  End Sub
End Class