Imports System.Windows.Input
Imports EntityFrameworkLib.Models
Imports VisualBasicLib.Abstracts
Imports VisualBasicLib.Classes
Imports VisualBasicLib.Interfaces
Imports VisualBasicLib.Repositories

Namespace ViewModels
  Public Class PessoaViewModel
    Inherits TypeTViewModel(Of Pessoa)

    Private ReadOnly Property _enderecoRepository As RepositoryAbstract(Of Endereco)

    Public Sub New(navManager As INavigationManager)
      MyBase.New(New PessoaRepository(), navManager)

      _enderecoRepository = New EnderecoRepository()
      Enderecos = _enderecoRepository.GetAll.Select(Function(a) $"{a.Rua}, {If(a.Numero IsNot Nothing, a.Numero.ToString, "S/N")} / {a.Cidade} - {a.Estado}").ToList
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
        If CurrentItem.IdEndereco Is Nothing Then
          Return _endereco
        Else
          Return _enderecoRepository.GetById(CurrentItem.IdEndereco).ToString
        End If
      End Get
      Set(value As String)
        _endereco = value
        OnPropertyChanged(NameOf(Endereco))
      End Set
    End Property
    Private _enderecos As List(Of String)
    Public Property Enderecos() As List(Of String)
      Get
        Return _enderecos
      End Get
      Set(value As List(Of String))
        _enderecos = value
      End Set
    End Property
    Public ReadOnly Property AddEnderecoCommand As ICommand
      Get
        Return New RelayCommand(Sub() _navigationManager.ShowPage("frmEndereco"))
      End Get
    End Property
  End Class
End Namespace
