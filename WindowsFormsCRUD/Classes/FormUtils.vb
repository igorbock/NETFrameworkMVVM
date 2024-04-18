Imports System.IO

Namespace Classes
  Public Class FormUtils
    Public Shared Sub ShowError(sender As Object, e As ErrorEventArgs)
      Dim exception As Exception = e.GetException()
      MessageBox.Show(exception.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
  End Class
End Namespace
