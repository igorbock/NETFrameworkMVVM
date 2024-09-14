Imports System.IO
Imports VisualBasicLib.Events

Namespace Classes
  Public Module FormUtils

    Private Property splashForm As SplashScreenApp

    Public Sub ShowError(sender As Object, e As ErrorEventArgs)
      Dim exception As Exception = e.GetException()
      MessageBox.Show(exception.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Function ShowYesNoQuestion(sender As Object, e As IterationEventArgs) As Boolean
      Dim response As DialogResult = MessageBox.Show(e.Message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
      Return IIf(response = DialogResult.Yes, True, False)
    End Function
    Public Function SelectTypeT(Of TypeT)(grid As DataGridView) As TypeT
      Dim row As Integer = grid.SelectedRows(0).Index
      Dim retorno As TypeT = CType(grid.Rows(row).DataBoundItem, TypeT)
      Return retorno
    End Function
    Public Sub RefreshControls(form As Form)
      For Each control As Control In form.Controls.Find("Usc", True)
        control.Refresh()
      Next
    End Sub
    Public Sub StartSplashScreen()
      splashForm = New SplashScreenApp()
      Application.Run(splashForm)
    End Sub
    Public Sub CloseSplashScreen()
      If splashForm IsNot Nothing AndAlso splashForm.InvokeRequired Then
        splashForm.Invoke(New MethodInvoker(AddressOf splashForm.Close))
      ElseIf splashForm IsNot Nothing Then
        splashForm.Close()
      End If
    End Sub
    Public Sub StartSplashScreenLoad(message As String)
      Application.Run(New SplashScreenLoad(message))
    End Sub
  End Module
End Namespace
