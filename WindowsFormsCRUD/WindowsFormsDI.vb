Imports Ninject.Modules
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Interfaces
Imports WindowsFormsLib
Imports WindowsFormsLib.Classes
Imports WindowsFormsLib.Navigator

Public Class WindowsFormsDI
  Inherits NinjectModule

  Public Overrides Sub Load()
    Bind(Of INavigationManager).To(Of NavigatorWindowsForm)()
    Bind(Of LoginAbstract).To(Of UserService).InSingletonScope()

    Bind(Of Home).ToSelf()
    Bind(Of frmPessoa).ToSelf()
    Bind(Of frmEndereco).ToSelf()
    Bind(Of frmLogin).ToSelf()
  End Sub
End Class
