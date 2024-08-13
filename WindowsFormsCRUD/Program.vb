Imports System.Threading
Imports EntityFrameworkLib.Models
Imports Ninject
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Interfaces
Imports VisualBasicLib.Repositories
Imports VisualBasicLib.ViewModels
Imports WindowsFormsCRUD.Classes
Imports WindowsFormsCRUD.Navigator

Public Module Program
  Private kernel As IKernel

  <STAThread()>
  Sub Main()
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(False)

    Dim thr As New Thread(New ThreadStart(AddressOf FormUtils.StartSplashScreen))
    thr.Start()
    Thread.Sleep(3000)

    kernel = New StandardKernel(New Ninject())
    thr.Abort()
    Application.Run(kernel.Get(Of Home))
  End Sub
End Module
