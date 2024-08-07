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
        Me.tbpTextBox = New System.Windows.Forms.TableLayoutPanel()
        Me.tbpTextBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.ForeColor = System.Drawing.Color.Black
        Me.TextBox.Location = New System.Drawing.Point(101, 8)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(164, 17)
        Me.TextBox.TabIndex = 0
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
        Me.Label.TabIndex = 1
        Me.Label.Text = "Texto"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbpTextBox
        '
        Me.tbpTextBox.ColumnCount = 2
        Me.tbpTextBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tbpTextBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbpTextBox.Controls.Add(Me.Label, 0, 0)
        Me.tbpTextBox.Controls.Add(Me.TextBox, 1, 0)
        Me.tbpTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpTextBox.Location = New System.Drawing.Point(0, 0)
        Me.tbpTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.tbpTextBox.Name = "tbpTextBox"
        Me.tbpTextBox.RowCount = 1
        Me.tbpTextBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbpTextBox.Size = New System.Drawing.Size(266, 33)
        Me.tbpTextBox.TabIndex = 2
        '
        'UscTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tbpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UscTextBox"
        Me.Size = New System.Drawing.Size(266, 33)
        Me.tbpTextBox.ResumeLayout(False)
        Me.tbpTextBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents tbpTextBox As TableLayoutPanel
End Class
