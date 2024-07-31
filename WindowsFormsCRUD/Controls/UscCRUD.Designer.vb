<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UscCRUD
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Image = Global.WindowsFormsCRUD.My.Resources.Resources.porta
        Me.btnClose.Location = New System.Drawing.Point(216, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 28)
        Me.btnClose.TabIndex = 8
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = Global.WindowsFormsCRUD.My.Resources.Resources.proximo_botao
        Me.btnNext.Location = New System.Drawing.Point(189, 0)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(28, 28)
        Me.btnNext.TabIndex = 7
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = Global.WindowsFormsCRUD.My.Resources.Resources.anterior
        Me.btnPrevious.Location = New System.Drawing.Point(162, 0)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(28, 28)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.WindowsFormsCRUD.My.Resources.Resources.impressora
        Me.btnPrint.Location = New System.Drawing.Point(135, 0)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(28, 28)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.WindowsFormsCRUD.My.Resources.Resources.recarregar
        Me.btnCancel.Location = New System.Drawing.Point(108, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(28, 28)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.WindowsFormsCRUD.My.Resources.Resources.disquete
        Me.btnSave.Location = New System.Drawing.Point(81, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(28, 28)
        Me.btnSave.TabIndex = 3
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.WindowsFormsCRUD.My.Resources.Resources.bin
        Me.btnDelete.Location = New System.Drawing.Point(54, 0)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(28, 28)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.WindowsFormsCRUD.My.Resources.Resources.editar
        Me.btnEdit.Location = New System.Drawing.Point(27, 0)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(28, 28)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = Global.WindowsFormsCRUD.My.Resources.Resources.add
        Me.btnNew.Location = New System.Drawing.Point(0, 0)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(28, 28)
        Me.btnNew.TabIndex = 0
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'UscCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UscCRUD"
        Me.Size = New System.Drawing.Size(244, 28)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClose As Button
End Class
