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

    kernel = New StandardKernel()
    kernel.Bind(Of RepositoryAbstract(Of Pessoa)).To(Of PessoaRepository)()
    kernel.Bind(Of RepositoryAbstract(Of Endereco)).To(Of EnderecoRepository)()
    kernel.Bind(Of TypeTViewModel(Of Pessoa)).To(Of PessoaViewModel)()
    kernel.Bind(Of TypeTViewModel(Of Endereco)).To(Of EnderecoViewModel)()
    kernel.Bind(Of INavigationManager).To(Of NavigatorWindowsForm)()

    Dim form As Home = kernel.Get(Of Home)

    Application.Run(form)
    thr.Abort()
  End Sub
End Module
