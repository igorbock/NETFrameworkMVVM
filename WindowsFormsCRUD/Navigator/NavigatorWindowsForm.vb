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
            windowsForm.Show()
            windowsForm.BringToFront()
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

    Public Sub ShowInTab(pageName As String) Implements INavigationManager.ShowInTab
      Try
        Dim form As Form = GetPage(pageName)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        form.Visible = True
        For Each tab As TabPage In Home.tbcPages.TabPages
          If tab.Text = form.Text Then
            Home.tbcPages.SelectedTab = tab
            Exit Sub
          End If
        Next
        Dim newTabPage As TabPage = New TabPage
        newTabPage.Controls.Add(form)
        newTabPage.Text = form.Text
        Home.tbcPages.TabPages.Add(newTabPage)
        Home.tbcPages.SelectedTab = newTabPage
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub

    Private Function GetPage(pageName As String) As Form
      Try
        Dim formName As String = $"WindowsFormsCRUD.{pageName}"
        Dim formType As Type = Type.[GetType](formName)
        If formType IsNot Nothing Then
          Dim windowsForm As Form = TryCast(Activator.CreateInstance(formType), Form)
          If windowsForm IsNot Nothing Then
            Return windowsForm
          Else
            Throw New Exception("Formulário não encontrado.")
          End If
        Else
          Throw New Exception("Formulário não encontrado.")
        End If
      Catch ex As Exception
        Throw New Exception("Formulário não encontrado.")
      End Try
    End Function
  End Class
End Namespace
