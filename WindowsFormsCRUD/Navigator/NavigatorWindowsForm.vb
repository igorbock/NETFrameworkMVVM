Imports System.Threading
Imports VisualBasicLib.Interfaces
Imports WindowsFormsCRUD.Classes

Namespace Navigator
  Public Class NavigatorWindowsForm
    Implements INavigationManager
    Public Sub ShowPage(pageName As String) Implements INavigationManager.ShowPage
      Dim thr As New Thread(New ThreadStart(Sub() FormUtils.StartSplashScreenLoad($"Carregando '{pageName}'...")))
      Try
        thr.Start()
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
      Finally
        thr.Abort()
      End Try
    End Sub

    Private Function GetPage(pageName As String) As Form
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
    End Function
  End Class
End Namespace
