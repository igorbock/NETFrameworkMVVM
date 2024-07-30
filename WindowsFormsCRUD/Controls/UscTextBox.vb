<System.ComponentModel.DefaultBindingProperty("EditValue")>
Public Class UscTextBox
  Public Property LabelText() As String
    Get
      Return Label.Text
    End Get
    Set(value As String)
      Label.Text = value
    End Set
  End Property
  Public Property EditValue As String
    Get
      Return TextBox.Text
    End Get
    Set(value As String)
      TextBox.Text = value
    End Set
  End Property
End Class
