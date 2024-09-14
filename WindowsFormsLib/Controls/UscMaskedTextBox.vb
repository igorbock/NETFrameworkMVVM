Public Class UscMaskedTextBox
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
      Return MaskedTextBox.Text
    End Get
    Set(value As String)
      MaskedTextBox.Text = value
    End Set
  End Property
  Public Property Mask As String
    Get
      Return MaskedTextBox.Mask
    End Get
    Set(value As String)
      MaskedTextBox.Mask = value
    End Set
  End Property
End Class
