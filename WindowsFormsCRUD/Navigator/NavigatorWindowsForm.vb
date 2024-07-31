Imports System.Threading
Imports VisualBasicLib.Interfaces
Imports WindowsFormsCRUD.Classes

Namespace Navigator
  Public Class NavigatorWindowsForm
    Implements INavigationManager

    Private ReadOnly Property _homePage As Home
      Get
        Return GetHomePage("Home")
      End Get
    End Property

    Public Sub ShowPage(pageName As String) Implements INavigationManager.ShowPage
      Dim thr As New Thread(New ThreadStart(Sub() FormUtils.StartSplashScreenLoad($"Carregando '{pageName}'...")))
      Try
        thr.Start()
        Dim form As Form = GetOpenedOrCreatePage(pageName)

        For Each tab As TabPage In _homePage.tbcPages.TabPages
          If tab.Text = form.Text Then
            _homePage.tbcPages.SelectedTab = tab
            Exit Sub
          End If
        Next

        Dim newTabPage As TabPage = New TabPage
        newTabPage.Controls.Add(form)
        newTabPage.Text = form.Text
        _homePage.tbcPages.TabPages.Add(newTabPage)
        _homePage.tbcPages.SelectedTab = newTabPage
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        thr.Abort()
      End Try
    End Sub

    Public Sub ClosePage() Implements INavigationManager.ClosePage
      Try
        Dim form As Form = GetOpenedOrCreatePage(_homePage.tbcPages.SelectedTab.Text)
        form.Close()
        _homePage.tbcPages.TabPages.Remove(_homePage.tbcPages.SelectedTab)
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub

    Private Function GetOpenedOrCreatePage(pageName As String) As Form
      For i As Integer = 0 To Application.OpenForms.Count - 1
        Dim form As Form = TryCast(Application.OpenForms.Item(i), Form)
        If form Is Nothing OrElse form.Text <> pageName Then Continue For
        Return form
      Next

      Dim formName As String = $"WindowsFormsCRUD.{pageName}"
      Dim formType As Type = Type.[GetType](formName)
      If formType IsNot Nothing Then
        Dim windowsForm As Form = TryCast(Activator.CreateInstance(formType), Form)
        If windowsForm IsNot Nothing Then
          windowsForm.TopLevel = False
          windowsForm.FormBorderStyle = FormBorderStyle.None
          windowsForm.Dock = DockStyle.Fill
          windowsForm.Visible = True
          Return windowsForm
        Else
          Throw New Exception("Formulário não encontrado.")
        End If
      Else
        Throw New Exception("Formulário não encontrado.")
      End If
    End Function
    Private Function GetHomePage(homePageName As String) As Form
      For i As Integer = 0 To Application.OpenForms.Count - 1
        Dim form As Form = TryCast(Application.OpenForms.Item(i), Form)
        If form Is Nothing OrElse form.Text <> homePageName Then Continue For
        Return form
      Next

      Throw New Exception("Home page não encontrada.")
    End Function
  End Class
End Namespace
