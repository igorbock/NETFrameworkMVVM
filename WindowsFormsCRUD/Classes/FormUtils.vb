Imports System.IO
Imports VisualBasicLib.Events

Namespace Classes
  Public Class FormUtils
    Public Shared Sub ShowError(sender As Object, e As ErrorEventArgs)
      Dim exception As Exception = e.GetException()
      MessageBox.Show(exception.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Shared Function ShowYesNoQuestion(sender As Object, e As IterationEventArgs) As Boolean
      Dim response As DialogResult = MessageBox.Show(e.Message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
      Return IIf(response = DialogResult.Yes, True, False)
    End Function
    Public Shared Function SelectTypeT(Of TypeT)(grid As DataGridView) As TypeT
      Dim row As Integer = grid.SelectedRows(0).Index
      Dim retorno As TypeT = CType(grid.Rows(row).DataBoundItem, TypeT)
      Return retorno
    End Function
    Public Shared Sub StartSplashScreen()
      Application.Run(New SplashScreenApp())
    End Sub
    Public Shared Sub StartSplashScreenLoad(message As String)
      Application.Run(New SplashScreenLoad(message))
    End Sub
  End Class
End Namespace
