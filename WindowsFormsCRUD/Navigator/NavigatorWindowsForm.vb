Imports VisualBasicLib.Interfaces

Namespace Navigator
  Public Class NavigatorWindowsForm
    Implements INavigationManager
    Public Sub ShowPage(pageName As String) Implements INavigationManager.ShowPage
      Try
        Dim formName As String = $"WindowsFormsCRUD.{pageName}"
        Dim formType As Type = Type.[GetType](formName)
        If formType IsNot Nothing Then
          Dim windowsForm As Form = TryCast(Activator.CreateInstance(formType), Form)
          If windowsForm IsNot Nothing Then
            windowsForm.ShowDialog()
          Else
            MessageBox.Show("Formulário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If
        Else
          MessageBox.Show("Formulário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      Catch ex As Exception
        MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub
  End Class
End Namespace
