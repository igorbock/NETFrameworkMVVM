﻿Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Input
Imports EntityFrameworkLib.Interfaces
Imports VisualBasicLib.Classes
Imports VisualBasicLib.Events
Imports VisualBasicLib.Interfaces

Namespace Abstracts
  Public MustInherit Class TypeTViewModel(Of TypeT As IEntity)
    Implements INotifyPropertyChanged

    Protected ReadOnly Property _typeTRepository As RepositoryAbstract(Of TypeT)
    Protected ReadOnly Property _navigationManager As INavigationManager

    Public Sub New(typeTRepository As RepositoryAbstract(Of TypeT), navManager As INavigationManager)
      _typeTRepository = typeTRepository
      _navigationManager = navManager
      ListTypeT = _typeTRepository.GetAll()
      CurrentItem = Activator.CreateInstance(Of TypeT)
      ReadMode()
    End Sub
    Private Property _listTypeT As ObservableCollection(Of TypeT)
    Public Property ListTypeT As ObservableCollection(Of TypeT)
      Get
        Return _listTypeT
      End Get
      Set(value As ObservableCollection(Of TypeT))
        _listTypeT = value
        OnPropertyChanged(NameOf(ListTypeT))
      End Set
    End Property
    Private Property _currentItem As TypeT
    Public Property CurrentItem As TypeT
      Get
        Return _currentItem
      End Get
      Set(value As TypeT)
        _currentItem = value
        OnPropertyChanged(NameOf(CurrentItem))
      End Set
    End Property
    Private _buttonInsertVisible As Boolean
    Public Property ButtonInsertVisible() As Boolean
      Get
        Return _buttonInsertVisible
      End Get
      Set(value As Boolean)
        _buttonInsertVisible = value
        OnPropertyChanged(NameOf(ButtonInsertVisible))
      End Set
    End Property
    Private _buttonEditVisible As Boolean
    Public Property ButtonEditVisible() As Boolean
      Get
        Return _buttonEditVisible
      End Get
      Set(value As Boolean)
        _buttonEditVisible = value
        OnPropertyChanged(NameOf(ButtonEditVisible))
      End Set
    End Property
    Private _buttonDeleteVisible As Boolean
    Public Property ButtonDeleteVisible() As Boolean
      Get
        Return _buttonDeleteVisible
      End Get
      Set(value As Boolean)
        _buttonDeleteVisible = value
        OnPropertyChanged(NameOf(ButtonDeleteVisible))
      End Set
    End Property
    Private _buttonSaveVisible As Boolean
    Public Property ButtonSaveVisible() As Boolean
      Get
        Return _buttonSaveVisible
      End Get
      Set(value As Boolean)
        _buttonSaveVisible = value
        OnPropertyChanged(NameOf(ButtonSaveVisible))
      End Set
    End Property
    Private _buttonCancelVisible As Boolean
    Public Property ButtonCancelVisible() As Boolean
      Get
        Return _buttonCancelVisible
      End Get
      Set(value As Boolean)
        _buttonCancelVisible = value
        OnPropertyChanged(NameOf(ButtonCancelVisible))
      End Set
    End Property
    Private _enableControl As Boolean
    Public Property EnableControl() As Boolean
      Get
        Return _enableControl
      End Get
      Set(value As Boolean)
        _enableControl = value
        OnPropertyChanged(NameOf(EnableControl))
      End Set
    End Property
    Private _enableListView As Boolean
    Public Property EnableListView() As Boolean
      Get
        Return _enableListView
      End Get
      Set(value As Boolean)
        _enableListView = value
        OnPropertyChanged(NameOf(EnableListView))
      End Set
    End Property
    Public Event ErrorOcurred As EventHandler(Of ErrorEventArgs)
    Protected Sub OnErrorOcurred(exception As Exception)
      RaiseEvent ErrorOcurred(Me, New ErrorEventArgs(exception))
    End Sub
    Public Event QuestionOcurred As EventHandler(Of IterationEventArgs)
    Protected Sub OnQuestionOcurred(e As IterationEventArgs)
      RaiseEvent QuestionOcurred(Me, e)
    End Sub

    Public Overridable ReadOnly Property SaveCommand As ICommand
      Get
        Return New RelayCommand(Sub() SaveTypeT())
      End Get
    End Property
    Public Overridable ReadOnly Property CancelCommand As ICommand
      Get
        Return New RelayCommand(Sub() CancelTypeT())
      End Get
    End Property
    Public Overridable ReadOnly Property CreateCommand As ICommand
      Get
        Return New RelayCommand(Sub() CreateTypeT())
      End Get
    End Property
    Public Overridable ReadOnly Property UpdateCommand As ICommand
      Get
        Return New RelayCommand(Sub() UpdateTypeT())
      End Get
    End Property
    Public Overridable ReadOnly Property DeleteCommand As ICommand
      Get
        Return New RelayCommand(Sub() DeleteTypeT())
      End Get
    End Property
    Protected Overridable Sub SaveTypeT()
      Try
        If _currentItem.Id = 0 Then
          _typeTRepository.Insert(_currentItem)
        Else
          _typeTRepository.Update(_currentItem)
        End If

        _typeTRepository.Commit()
        _typeTRepository.Save()
        ReadMode()

        ListTypeT = _typeTRepository.GetAll()
        CurrentItem = ListTypeT.Last()
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub CancelTypeT()
      Try
        _typeTRepository.Rollback()
        ReadMode()

        If _currentItem.Id = 0 Then
          CurrentItem = Activator.CreateInstance(Of TypeT)
        End If
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub CreateTypeT()
      Try
        _typeTRepository.Begin()
        EditMode()
        CurrentItem = Activator.CreateInstance(Of TypeT)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub UpdateTypeT()
      Try
        If _currentItem.Id = 0 Then Throw New ArgumentNullException(GetType(TypeT).Name)

        CurrentItem = _typeTRepository.GetById(_currentItem.Id)
        _typeTRepository.Begin()
        EditMode()
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Protected Overridable Sub DeleteTypeT()
      Try
        If _currentItem.Id = 0 Then Throw New ArgumentNullException(GetType(TypeT).Name)

        Dim eventArgs As New IterationEventArgs("Você deseja realmente excluir o registro selecionado?")
        OnQuestionOcurred(eventArgs)

        If eventArgs.Iteration.HasValue Then
          If eventArgs.Iteration = True Then
            _typeTRepository.Delete(_currentItem.Id)
            _typeTRepository.Save()
          End If
        End If

        ListTypeT = _typeTRepository.GetAll()
        CurrentItem = Activator.CreateInstance(Of TypeT)
      Catch ex As Exception
        OnErrorOcurred(ex)
      End Try
    End Sub
    Private Sub EditMode()
      ButtonInsertVisible = False
      ButtonEditVisible = False
      ButtonDeleteVisible = False
      ButtonSaveVisible = True
      ButtonCancelVisible = True
      EnableControl = True
      EnableListView = False
    End Sub
    Private Sub ReadMode()
      ButtonInsertVisible = True
      ButtonEditVisible = True
      ButtonDeleteVisible = True
      ButtonSaveVisible = False
      ButtonCancelVisible = False
      EnableControl = False
      EnableListView = True
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(propertyName As String)
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
  End Class
End Namespace
