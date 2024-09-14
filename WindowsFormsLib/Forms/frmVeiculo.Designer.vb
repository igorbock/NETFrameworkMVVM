<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeiculo
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Exigido pelo Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
  'Pode ser modificado usando o Windows Form Designer.  
  'Não o modifique usando o editor de códigos.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.tbpBaseCRUD = New System.Windows.Forms.TableLayoutPanel()
    Me.navigator = New WindowsFormsLib.UscCRUD()
    Me.tbpBaseCRUD.SuspendLayout()
    Me.SuspendLayout()
    '
    'tbpBaseCRUD
    '
    Me.tbpBaseCRUD.ColumnCount = 1
    Me.tbpBaseCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbpBaseCRUD.Controls.Add(Me.navigator, 0, 0)
    Me.tbpBaseCRUD.Dock = System.Windows.Forms.DockStyle.Top
    Me.tbpBaseCRUD.Location = New System.Drawing.Point(0, 0)
    Me.tbpBaseCRUD.Margin = New System.Windows.Forms.Padding(1)
    Me.tbpBaseCRUD.Name = "tbpBaseCRUD"
    Me.tbpBaseCRUD.RowCount = 1
    Me.tbpBaseCRUD.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbpBaseCRUD.Size = New System.Drawing.Size(800, 30)
    Me.tbpBaseCRUD.TabIndex = 0
    '
    'navigator
    '
    Me.navigator.CancelEnabled = True
    Me.navigator.CloseEnabled = True
    Me.navigator.Dock = System.Windows.Forms.DockStyle.Fill
    Me.navigator.EditEnabled = True
    Me.navigator.Location = New System.Drawing.Point(1, 1)
    Me.navigator.Margin = New System.Windows.Forms.Padding(1)
    Me.navigator.Name = "navigator"
    Me.navigator.NewEnabled = True
    Me.navigator.NextEnabled = True
    Me.navigator.PreviousEnabled = True
    Me.navigator.PrintEnabled = True
    Me.navigator.RemoveEnabled = True
    Me.navigator.SaveEnabled = True
    Me.navigator.Size = New System.Drawing.Size(798, 28)
    Me.navigator.TabIndex = 0
    '
    'frmVeiculo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.ControlBox = False
    Me.Controls.Add(Me.tbpBaseCRUD)
    Me.Name = "frmVeiculo"
    Me.Text = "frmVeiculo"
    Me.tbpBaseCRUD.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents tbpBaseCRUD As TableLayoutPanel
  Friend WithEvents navigator As UscCRUD
End Class
