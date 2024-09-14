Imports System.IO
Imports VisualBasicLib.Events

Namespace Classes
  Public Module FormUtils

    Private Property _splashForm As SplashScreenApp
    Private Property _splashFormLoad As SplashScreenLoad

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
      _splashForm = New SplashScreenApp()
      Application.Run(_splashForm)
    End Sub
    Public Sub CloseSplashScreen()
      If _splashForm IsNot Nothing AndAlso _splashForm.InvokeRequired Then
        _splashForm.Invoke(New MethodInvoker(AddressOf _splashForm.Close))
      ElseIf _splashForm IsNot Nothing Then
        _splashForm.Close()
      End If
    End Sub
    Public Sub StartSplashScreenLoad(message As String)
      _splashFormLoad = New SplashScreenLoad(message)
      Application.Run(_splashFormLoad)
    End Sub
    Public Sub CloseSplashScreenLoad()
      If _splashFormLoad IsNot Nothing AndAlso _splashFormLoad.InvokeRequired Then
        _splashFormLoad.Invoke(New MethodInvoker(AddressOf _splashFormLoad.Close))
      ElseIf _splashFormLoad IsNot Nothing Then
        _splashFormLoad.Close()
      End If
    End Sub
  End Module
End Namespace
