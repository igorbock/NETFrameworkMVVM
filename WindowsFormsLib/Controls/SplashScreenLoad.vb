Public Class SplashScreenLoad
  Public Property Message() As String
    Get
      Return Label.Text
    End Get
    Set(value As String)
      Label.Text = value
    End Set
  End Property

  Public Sub New()
    InitializeComponent()
  End Sub
  Public Sub New(message As String)
    Me.New()

    Me.Message = message
  End Sub
  Protected Overrides Sub Finalize()
    Dispose()
  End Sub
End Class