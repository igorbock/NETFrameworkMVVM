<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UscNumeric
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
        Me.NumericBox = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NumericBox
        '
        Me.NumericBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NumericBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericBox.Font = New System.Drawing.Font("Leelawadee", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericBox.ForeColor = System.Drawing.Color.Black
        Me.NumericBox.Location = New System.Drawing.Point(54, 9)
        Me.NumericBox.Margin = New System.Windows.Forms.Padding(5, 1, 10, 1)
        Me.NumericBox.Name = "NumericBox"
        Me.NumericBox.Size = New System.Drawing.Size(205, 14)
        Me.NumericBox.TabIndex = 0
        Me.NumericBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Leelawadee", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(8, 10)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(34, 14)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Valor"
        '
        'UscNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.NumericBox)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UscNumeric"
        Me.Size = New System.Drawing.Size(262, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericBox As TextBox
    Friend WithEvents Label As Label
End Class
