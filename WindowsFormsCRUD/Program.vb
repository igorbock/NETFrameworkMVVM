Imports System.Threading
Imports Ninject
Imports VisualBasicLib.Classes
Imports WindowsFormsCRUD.Classes

Public Module Program
  Private kernel As IKernel

  <STAThread()>
  Sub Main()
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(False)

    Dim thr As New Thread(New ThreadStart(AddressOf FormUtils.StartSplashScreen))
    thr.Start()
    Thread.Sleep(3000)
    thr.Abort()

    kernel = New StandardKernel(New WindowsFormsDI(), New NinjectDI())
#If DEBUG Then
    Application.Run(kernel.Get(Of Home))
#Else
    Application.Run(kernel.Get(Of frmLogin))
#End If
  End Sub
End Module
