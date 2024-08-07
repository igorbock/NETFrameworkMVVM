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
        Me.tbpNumeric = New System.Windows.Forms.TableLayoutPanel()
        Me.tbpNumeric.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericBox
        '
        Me.NumericBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NumericBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericBox.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericBox.ForeColor = System.Drawing.Color.Black
        Me.NumericBox.Location = New System.Drawing.Point(101, 8)
        Me.NumericBox.Margin = New System.Windows.Forms.Padding(1)
        Me.NumericBox.Name = "NumericBox"
        Me.NumericBox.Size = New System.Drawing.Size(160, 17)
        Me.NumericBox.TabIndex = 0
        '
        'Label
        '
        Me.Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Leelawadee", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(1, 9)
        Me.Label.Margin = New System.Windows.Forms.Padding(1)
        Me.Label.Name = "Label"
        Me.Label.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label.Size = New System.Drawing.Size(98, 14)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Valor"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbpNumeric
        '
        Me.tbpNumeric.ColumnCount = 2
        Me.tbpNumeric.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tbpNumeric.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbpNumeric.Controls.Add(Me.Label, 0, 0)
        Me.tbpNumeric.Controls.Add(Me.NumericBox, 1, 0)
        Me.tbpNumeric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpNumeric.Location = New System.Drawing.Point(0, 0)
        Me.tbpNumeric.Margin = New System.Windows.Forms.Padding(1)
        Me.tbpNumeric.Name = "tbpNumeric"
        Me.tbpNumeric.RowCount = 1
        Me.tbpNumeric.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbpNumeric.Size = New System.Drawing.Size(262, 33)
        Me.tbpNumeric.TabIndex = 2
        '
        'UscNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tbpNumeric)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UscNumeric"
        Me.Size = New System.Drawing.Size(262, 33)
        Me.tbpNumeric.ResumeLayout(False)
        Me.tbpNumeric.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NumericBox As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents tbpNumeric As TableLayoutPanel
End Class
