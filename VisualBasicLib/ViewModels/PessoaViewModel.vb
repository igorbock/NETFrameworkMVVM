Imports EntityFrameworkLib.Models
Imports VisualBasicLib.Abstracts

Namespace ViewModels
  Public Class PessoaViewModel
    Inherits TypeTViewModel(Of Pessoa)

    Public Sub New(typeTRepository As RepositoryAbstract(Of Pessoa))
      MyBase.New(typeTRepository)
    End Sub
  End Class
End Namespace
