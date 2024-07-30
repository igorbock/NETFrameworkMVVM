Public Class UscNumeric
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
      Return NumericBox.Text
    End Get
    Set(value As String)
      NumericBox.Text = value
    End Set
  End Property
  Public Sub New()
    InitializeComponent()

    AddHandler NumericBox.KeyPress, AddressOf KeyPressMethod
    AddHandler NumericBox.TextChanged, AddressOf TextChangedMethod
  End Sub
  Private Sub KeyPressMethod(sender As Object, e As KeyPressEventArgs)
    e.Handled = Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False
  End Sub
  Private Sub TextChangedMethod(sender As Object, e As EventArgs)
    If System.Text.RegularExpressions.Regex.IsMatch(NumericBox.Text, "[^0-9]") Then
      NumericBox.Text = NumericBox.Text.Remove(NumericBox.Text.Length - 1)
    End If
  End Sub
End Class
