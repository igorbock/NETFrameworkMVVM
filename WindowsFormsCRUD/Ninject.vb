Imports EntityFrameworkLib.Context
Imports EntityFrameworkLib.Models
Imports Ninject.Modules
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Interfaces
Imports VisualBasicLib.Repositories
Imports VisualBasicLib.ViewModels
Imports WindowsFormsCRUD.Navigator

Public Class Ninject
  Inherits NinjectModule

  Public Overrides Sub Load()
    Bind(Of LibDbContext).ToSelf()
    Bind(Of RepositoryAbstract(Of Pessoa)).To(Of PessoaRepository)()
    Bind(Of RepositoryAbstract(Of Endereco)).To(Of EnderecoRepository)()
    Bind(Of TypeTViewModel(Of Pessoa)).To(Of PessoaViewModel)()
    Bind(Of TypeTViewModel(Of Endereco)).To(Of EnderecoViewModel)()
    Bind(Of INavigationManager).To(Of NavigatorWindowsForm)()

    Bind(Of Home).ToSelf()
    Bind(Of frmPessoa).ToSelf()
  End Sub
End Class
