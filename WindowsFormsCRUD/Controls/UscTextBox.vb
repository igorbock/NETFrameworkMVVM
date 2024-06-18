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

  Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBox.Enter
    Label.Location = New Point(8, -2)
    Label.BackColor = Color.FromArgb(240, 240, 231)
    TextBox.BackColor = Color.FromArgb(240, 240, 231)
    BackColor = Color.FromArgb(240, 240, 231)
    Label.Refresh()
    TextBox.Refresh()
  End Sub

  Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBox.Leave
    If String.IsNullOrEmpty(TextBox.Text) Then
      TextBox.Location = New Point(8, 12)
      Label.Location = New Point(8, 10)
    End If
    Label.BackColor = Color.White
    BackColor = Color.White
    TextBox.BackColor = Color.White
    TextBox.Refresh()
    Label.Refresh()
  End Sub
End Class
