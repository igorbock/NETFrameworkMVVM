Public Class UscCRUD
  Public Event NewEvent As EventHandler
  Public Event EditEvent As EventHandler
  Public Event RemoveEvent As EventHandler
  Public Event SaveEvent As EventHandler
  Public Event CancelEvent As EventHandler
  Public Event PrintEvent As EventHandler
  Public Event PreviousEvent As EventHandler
  Public Event NextEvent As EventHandler
  Public Event CloseEvent As EventHandler

  Public Property NewEnabled() As Boolean
    Get
      Return btnNew.Enabled
    End Get
    Set(value As Boolean)
      btnNew.Enabled = value
    End Set
  End Property
  Public Property EditEnabled() As Boolean
    Get
      Return btnEdit.Enabled
    End Get
    Set(value As Boolean)
      btnEdit.Enabled = value
    End Set
  End Property
  Public Property RemoveEnabled() As Boolean
    Get
      Return btnDelete.Enabled
    End Get
    Set(value As Boolean)
      btnDelete.Enabled = value
    End Set
  End Property
  Public Property SaveEnabled() As Boolean
    Get
      Return btnSave.Enabled
    End Get
    Set(value As Boolean)
      btnSave.Enabled = value
    End Set
  End Property
  Public Property CancelEnabled() As Boolean
    Get
      Return btnCancel.Enabled
    End Get
    Set(value As Boolean)
      btnCancel.Enabled = value
    End Set
  End Property
  Public Property PrintEnabled() As Boolean
    Get
      Return btnPrint.Enabled
    End Get
    Set(value As Boolean)
      btnPrint.Enabled = value
    End Set
  End Property
  Public Property PreviousEnabled() As Boolean
    Get
      Return btnPrevious.Enabled
    End Get
    Set(value As Boolean)
      btnPrevious.Enabled = value
    End Set
  End Property
  Public Property NextEnabled() As Boolean
    Get
      Return btnNext.Enabled
    End Get
    Set(value As Boolean)
      btnNext.Enabled = value
    End Set
  End Property
  Public Property CloseEnabled() As Boolean
    Get
      Return btnClose.Enabled
    End Get
    Set(value As Boolean)
      btnClose.Enabled = value
    End Set
  End Property

  Public Sub New()
    InitializeComponent()

    AddHandler btnNew.Click, Sub(sender, e) RaiseEvent NewEvent(sender, e)
    AddHandler btnEdit.Click, Sub(sender, e) RaiseEvent EditEvent(sender, e)
    AddHandler btnDelete.Click, Sub(sender, e) RaiseEvent RemoveEvent(sender, e)
    AddHandler btnSave.Click, Sub(sender, e) RaiseEvent SaveEvent(sender, e)
    AddHandler btnCancel.Click, Sub(sender, e) RaiseEvent CancelEvent(sender, e)
    AddHandler btnPrint.Click, Sub(sender, e) RaiseEvent PrintEvent(sender, e)
    AddHandler btnPrevious.Click, Sub(sender, e) RaiseEvent PreviousEvent(sender, e)
    AddHandler btnNext.Click, Sub(sender, e) RaiseEvent NextEvent(sender, e)
    AddHandler btnClose.Click, Sub(sender, e) RaiseEvent CloseEvent(sender, e)
  End Sub
End Class
