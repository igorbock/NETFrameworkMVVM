<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UscTextBox
  Inherits System.Windows.Forms.UserControl

  'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.Location = New System.Drawing.Point(0, 0)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(200, 33)
        Me.TextBox.TabIndex = 0
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(5, 9)
        Me.Label.Margin = New System.Windows.Forms.Padding(1)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(40, 13)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Texto"
        '
        'UscTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.TextBox)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UscTextBox"
        Me.Size = New System.Drawing.Size(200, 33)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox As TextBox
    Friend WithEvents Label As Label
End Class
