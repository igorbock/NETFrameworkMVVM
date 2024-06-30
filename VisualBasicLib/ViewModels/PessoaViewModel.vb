﻿Imports System.Collections.ObjectModel
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
      Enderecos = _enderecoRepository.GetAll
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
    Public Property Endereco As Integer?
      Get
        Return CurrentItem.IdEndereco
      End Get
      Set(value As Integer?)
        CurrentItem.IdEndereco = value
        OnPropertyChanged(NameOf(Endereco))
      End Set
    End Property
    Private _enderecos As ObservableCollection(Of Endereco)
    Public Property Enderecos() As ObservableCollection(Of Endereco)
      Get
        Return _enderecos
      End Get
      Set(value As ObservableCollection(Of Endereco))
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
