<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UscMaskedTextBox
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
        Me.Label = New System.Windows.Forms.Label()
        Me.MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label.Font = New System.Drawing.Font("Leelawadee", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(8, 10)
        Me.Label.Margin = New System.Windows.Forms.Padding(1)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(36, 14)
        Me.Label.TabIndex = 2
        Me.Label.Text = "Texto"
        '
        'MaskedTextBox
        '
        Me.MaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaskedTextBox.Font = New System.Drawing.Font("Leelawadee", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox.Location = New System.Drawing.Point(54, 10)
        Me.MaskedTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.MaskedTextBox.Name = "MaskedTextBox"
        Me.MaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MaskedTextBox.Size = New System.Drawing.Size(207, 14)
        Me.MaskedTextBox.TabIndex = 3
        Me.MaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'UscMaskedTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.MaskedTextBox)
        Me.Controls.Add(Me.Label)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UscMaskedTextBox"
        Me.Size = New System.Drawing.Size(266, 33)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents MaskedTextBox As MaskedTextBox
End Class
