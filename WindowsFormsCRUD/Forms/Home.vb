Imports System.Threading
Imports VisualBasicLib.Interfaces
Imports WindowsFormsCRUD.Classes
Imports WindowsFormsCRUD.Navigator

Public Class Home

  Private ReadOnly Property _navigator As INavigationManager

  Public Sub New()
    Dim thr As New Thread(New ThreadStart(AddressOf FormUtils.StartSplashScreen))
    thr.Start()
    Thread.Sleep(3000)
    InitializeComponent()
    thr.Abort()

    _navigator = New NavigatorWindowsForm()

    AddHandler btnPessoa.Click, Sub() _navigator.ShowPage("frmPessoa")
    AddHandler btnEndereco.Click, Sub() _navigator.ShowPage("frmEndereco")
  End Sub
End Class