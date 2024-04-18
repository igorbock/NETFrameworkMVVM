Public Class UscTextBox
  Public Property LabelText() As String
    Get
      Return Label.Text
    End Get
    Set(value As String)
      Label.Text = value
    End Set
  End Property

  Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBox.Enter
    TextBox.Location = New Point(0, 20)
    Label.Location = New Point(5, 0)
  End Sub

  Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBox.Leave
    If String.IsNullOrEmpty(TextBox.Text) Then
      TextBox.Location = New Point(0, 0)
      Label.Location = New Point(5, 9)
    End If
  End Sub
End Class
