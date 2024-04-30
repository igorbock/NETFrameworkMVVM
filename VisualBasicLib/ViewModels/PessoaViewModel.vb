Imports System.Collections.ObjectModel
Imports EntityFrameworkLib.Models
Imports EntityFrameworkLib.Models.DTOs
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Repositories

Namespace ViewModels
  Public Class PessoaViewModel
    Inherits TypeTViewModel(Of Pessoa, PessoaDTO)

    Private ReadOnly Property _enderecoRepository As RepositoryAbstract(Of Endereco)

    Public Sub New(typeTRepository As RepositoryAbstract(Of Pessoa))
      MyBase.New(typeTRepository)

      _enderecoRepository = New EnderecoRepository()
      LoadTypeTDTO()
    End Sub

    Private Sub LoadTypeTDTO()
      Dim enderecos As ObservableCollection(Of Endereco) = _enderecoRepository.GetAll()

      ListTypeTDTO = New ObservableCollection(Of PessoaDTO)((From p In ListTypeT
                                                             Join e In enderecos On e.Id Equals p.IdEndereco
                                                             Select New PessoaDTO With {
                                                               .Id = p.Id,
                                                               .CPF = p.CPF,
                                                               .RG = p.RG,
                                                               .Nascimento = p.Nascimento,
                                                               .Nome = p.Nome,
                                                               .IdEndereco = e.Id,
                                                               .Endereco = e.ToString
                                                              }).ToList)
    End Sub

    Public Property Nome() As String
      Get
        Return CurrentItem.Nome
      End Get
      Set(value As String)
        CurrentItem.Nome = value
        OnPropertyChanged(NameOf(Nome))
      End Set
    End Property
    Public Property CPF() As String
      Get
        Return CurrentItem.CPF
      End Get
      Set(value As String)
        CurrentItem.CPF = value
        OnPropertyChanged(NameOf(CPF))
      End Set
    End Property
    Public Property RG() As String
      Get
        Return CurrentItem.RG
      End Get
      Set(value As String)
        CurrentItem.RG = value
        OnPropertyChanged(NameOf(RG))
      End Set
    End Property
    Public Property Nascimento() As Date
      Get
        Return CurrentItem.Nascimento
      End Get
      Set(value As Date)
        CurrentItem.Nascimento = value
        OnPropertyChanged(NameOf(Nascimento))
      End Set
    End Property
    Private _endereco As String
    Public Property Endereco() As String
      Get
        If CurrentItem.Endereco Is Nothing Then
          Return _endereco
        Else
          Return CurrentItem.Endereco.ToString
        End If
      End Get
      Set(value As String)
        _endereco = value
        OnPropertyChanged(NameOf(Endereco))
      End Set
    End Property
  End Class
End Namespace
