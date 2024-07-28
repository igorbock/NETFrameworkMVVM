Imports VisualBasicLib.Interfaces
Imports WindowsFormsCRUD.Navigator

Public Class Home

  Private ReadOnly Property _navigator As INavigationManager

  Public Sub New()
    InitializeComponent()

    _navigator = New NavigatorWindowsForm()

    AddHandler btnPessoa.Click, Sub() _navigator.ShowInTab("frmPessoa")
    AddHandler btnEndereco.Click, Sub() _navigator.ShowInTab("frmEndereco")
  End Sub
End Class