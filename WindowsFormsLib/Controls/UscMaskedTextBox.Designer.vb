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
        Me.tbpMask = New System.Windows.Forms.TableLayoutPanel()
        Me.tbpMask.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label.Font = New System.Drawing.Font("Leelawadee", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(1, 9)
        Me.Label.Margin = New System.Windows.Forms.Padding(1)
        Me.Label.Name = "Label"
        Me.Label.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label.Size = New System.Drawing.Size(98, 14)
        Me.Label.TabIndex = 2
        Me.Label.Text = "Texto"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaskedTextBox
        '
        Me.MaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaskedTextBox.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox.Location = New System.Drawing.Point(101, 8)
        Me.MaskedTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.MaskedTextBox.Name = "MaskedTextBox"
        Me.MaskedTextBox.Size = New System.Drawing.Size(164, 17)
        Me.MaskedTextBox.TabIndex = 3
        Me.MaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'tbpMask
        '
        Me.tbpMask.ColumnCount = 2
        Me.tbpMask.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tbpMask.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbpMask.Controls.Add(Me.Label, 0, 0)
        Me.tbpMask.Controls.Add(Me.MaskedTextBox, 1, 0)
        Me.tbpMask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpMask.Location = New System.Drawing.Point(0, 0)
        Me.tbpMask.Margin = New System.Windows.Forms.Padding(1)
        Me.tbpMask.Name = "tbpMask"
        Me.tbpMask.RowCount = 1
        Me.tbpMask.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbpMask.Size = New System.Drawing.Size(266, 33)
        Me.tbpMask.TabIndex = 4
        '
        'UscMaskedTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tbpMask)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UscMaskedTextBox"
        Me.Size = New System.Drawing.Size(266, 33)
        Me.tbpMask.ResumeLayout(False)
        Me.tbpMask.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents MaskedTextBox As MaskedTextBox
    Friend WithEvents tbpMask As TableLayoutPanel
End Class
