Imports System.Threading
Imports Ninject
Imports VisualBasicLib.Interfaces
Imports VisualBasicLib.Extensions.StringExtensions
Imports WindowsFormsCRUD.Classes

Namespace Navigator
  Public Class NavigatorWindowsForm
    Implements INavigationManager

    Private ReadOnly Property _kernel As IKernel

    Private Property _homePage As Home
    Public Property HomePage As Home
      Get
        If _homePage Is Nothing Then Me.HomePage = GetHomePage("Home")
        Return _homePage
      End Get
      Set(value As Home)
        _homePage = value
      End Set
    End Property
    Public Sub New(kernel As IKernel)
      _kernel = kernel
    End Sub
    Public Sub ShowDialog(pageName As String) Implements INavigationManager.ShowDialog
      Try
        Dim form As Form = GetOpenedOrCreatePage(pageName)
        form.TopLevel = True
        form.ShowDialog()
        form.BringToFront()
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub

    Public Sub ShowPage(pageName As String) Implements INavigationManager.ShowPage
      Dim thr As New Thread(New ThreadStart(Sub() FormUtils.StartSplashScreenLoad($"Carregando '{pageName}'...")))
      Try
        thr.Start()
        Dim form As Form = GetOpenedOrCreatePage(pageName)

        For Each tab As TabPage In HomePage.tbcPages.TabPages
          If tab.Text = form.Text Then
            HomePage.tbcPages.SelectedTab = tab
            Exit Sub
          End If
        Next

        Dim newTabPage As TabPage = New TabPage
        newTabPage.Controls.Add(form)
        newTabPage.Text = form.Text
        newTabPage.Name = pageName
        HomePage.tbcPages.TabPages.Add(newTabPage)
        HomePage.tbcPages.SelectedTab = newTabPage
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        thr.Abort()
      End Try
    End Sub

    Public Sub ClosePage() Implements INavigationManager.ClosePage
      Try
        Dim form As Form = GetOpenedOrCreatePage(HomePage.tbcPages.SelectedTab.Text.ToFormName())
        form.Close()
        HomePage.tbcPages.TabPages.Remove(HomePage.tbcPages.SelectedTab)
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub

    Public Sub ClosePage(pageName As String) Implements INavigationManager.ClosePage
      Try
        Dim form As Form = GetOpenedOrCreatePage(pageName)
        form.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub

    Private Function GetOpenedOrCreatePage(pageName As String) As Form
      For i As Integer = 0 To Application.OpenForms.Count - 1
        Dim form As Form = TryCast(Application.OpenForms.Item(i), Form)
        If form Is Nothing OrElse form.Name <> pageName Then Continue For
        Return form
      Next


      Dim formName As String = $"WindowsFormsCRUD.{pageName}"
      Dim formType As Type = Type.[GetType](formName)
      If formType IsNot Nothing Then
        Dim windowsForm As Form = _kernel.Get(formType)
        If windowsForm IsNot Nothing Then
          windowsForm.TopLevel = False
          windowsForm.FormBorderStyle = FormBorderStyle.None
          windowsForm.Dock = DockStyle.Fill
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
        Dim form As Form = Application.OpenForms.Item(i)
        If form Is Nothing OrElse form.Text <> homePageName Then Continue For
        Return form
      Next

      Throw New Exception("Home page não encontrada.")
    End Function

    Public Sub CloseAllPages() Implements INavigationManager.CloseAllPages
      For Each tab As TabPage In HomePage.tbcPages.TabPages
        Dim formName As String = tab.Name
        Dim form As Form = GetOpenedOrCreatePage(formName)
        form.Close()
        HomePage.tbcPages.TabPages.RemoveByKey(formName)
      Next
    End Sub
  End Class
End Namespace
