Imports System.Threading
Imports Ninject
Imports VisualBasicLib.Classes
Imports WindowsFormsLib
Imports WindowsFormsLib.Classes

Public Module Program
  Private kernel As IKernel

  <STAThread()>
  Sub Main()
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(False)

    Dim thr As New Thread(New ThreadStart(AddressOf StartSplashScreen))
    thr.Start()
    Thread.Sleep(4000)
    CloseSplashScreen()

    kernel = New StandardKernel(New WindowsFormsDI(), New NinjectDI())
    Application.Run(kernel.Get(Of Home))
  End Sub
End Module
