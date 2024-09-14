<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UscCRUD
  Inherits System.Windows.Forms.UserControl

  'O UserControl substitui o descarte para limpar a lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.tipCRUD = New System.Windows.Forms.ToolTip(Me.components)
    Me.btnRefresh = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnNext = New System.Windows.Forms.Button()
    Me.btnPrevious = New System.Windows.Forms.Button()
    Me.btnPrint = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.btnSave = New System.Windows.Forms.Button()
    Me.btnDelete = New System.Windows.Forms.Button()
    Me.btnEdit = New System.Windows.Forms.Button()
    Me.btnNew = New System.Windows.Forms.Button()
    Me.tbpCRUD = New System.Windows.Forms.TableLayoutPanel()
    Me.tbpCRUD.SuspendLayout()
    Me.SuspendLayout()
    '
    'tipCRUD
    '
    Me.tipCRUD.AutoPopDelay = 5000
    Me.tipCRUD.InitialDelay = 300
    Me.tipCRUD.ReshowDelay = 100
    Me.tipCRUD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
    '
    'btnRefresh
    '
    Me.btnRefresh.Image = Global.WindowsFormsLib.My.Resources.Resources.atualizar
    Me.btnRefresh.Location = New System.Drawing.Point(151, 1)
    Me.btnRefresh.Margin = New System.Windows.Forms.Padding(1)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(28, 28)
    Me.btnRefresh.TabIndex = 9
    Me.btnRefresh.UseVisualStyleBackColor = True
    '
    'btnClose
    '
    Me.btnClose.Image = Global.WindowsFormsLib.My.Resources.Resources.porta
    Me.btnClose.Location = New System.Drawing.Point(271, 1)
    Me.btnClose.Margin = New System.Windows.Forms.Padding(1)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(28, 28)
    Me.btnClose.TabIndex = 8
    Me.tipCRUD.SetToolTip(Me.btnClose, "Sair/Fechar")
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'btnNext
    '
    Me.btnNext.Image = Global.WindowsFormsLib.My.Resources.Resources.proximo_botao
    Me.btnNext.Location = New System.Drawing.Point(241, 1)
    Me.btnNext.Margin = New System.Windows.Forms.Padding(1)
    Me.btnNext.Name = "btnNext"
    Me.btnNext.Size = New System.Drawing.Size(28, 28)
    Me.btnNext.TabIndex = 7
    Me.tipCRUD.SetToolTip(Me.btnNext, "Próximo")
    Me.btnNext.UseVisualStyleBackColor = True
    '
    'btnPrevious
    '
    Me.btnPrevious.Image = Global.WindowsFormsLib.My.Resources.Resources.anterior
    Me.btnPrevious.Location = New System.Drawing.Point(211, 1)
    Me.btnPrevious.Margin = New System.Windows.Forms.Padding(1)
    Me.btnPrevious.Name = "btnPrevious"
    Me.btnPrevious.Size = New System.Drawing.Size(28, 28)
    Me.btnPrevious.TabIndex = 6
    Me.tipCRUD.SetToolTip(Me.btnPrevious, "Anterior")
    Me.btnPrevious.UseVisualStyleBackColor = True
    '
    'btnPrint
    '
    Me.btnPrint.Image = Global.WindowsFormsLib.My.Resources.Resources.impressora
    Me.btnPrint.Location = New System.Drawing.Point(181, 1)
    Me.btnPrint.Margin = New System.Windows.Forms.Padding(1)
    Me.btnPrint.Name = "btnPrint"
    Me.btnPrint.Size = New System.Drawing.Size(28, 28)
    Me.btnPrint.TabIndex = 5
    Me.tipCRUD.SetToolTip(Me.btnPrint, "Imprimir")
    Me.btnPrint.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.Image = Global.WindowsFormsLib.My.Resources.Resources.recarregar
    Me.btnCancel.Location = New System.Drawing.Point(121, 1)
    Me.btnCancel.Margin = New System.Windows.Forms.Padding(1)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(28, 28)
    Me.btnCancel.TabIndex = 4
    Me.tipCRUD.SetToolTip(Me.btnCancel, "Cancelar")
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'btnSave
    '
    Me.btnSave.Image = Global.WindowsFormsLib.My.Resources.Resources.disquete
    Me.btnSave.Location = New System.Drawing.Point(91, 1)
    Me.btnSave.Margin = New System.Windows.Forms.Padding(1)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(28, 28)
    Me.btnSave.TabIndex = 3
    Me.tipCRUD.SetToolTip(Me.btnSave, "Salvar")
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'btnDelete
    '
    Me.btnDelete.Image = Global.WindowsFormsLib.My.Resources.Resources.bin
    Me.btnDelete.Location = New System.Drawing.Point(61, 1)
    Me.btnDelete.Margin = New System.Windows.Forms.Padding(1)
    Me.btnDelete.Name = "btnDelete"
    Me.btnDelete.Size = New System.Drawing.Size(28, 28)
    Me.btnDelete.TabIndex = 2
    Me.tipCRUD.SetToolTip(Me.btnDelete, "Remover")
    Me.btnDelete.UseVisualStyleBackColor = True
    '
    'btnEdit
    '
    Me.btnEdit.Image = Global.WindowsFormsLib.My.Resources.Resources.editar
    Me.btnEdit.Location = New System.Drawing.Point(31, 1)
    Me.btnEdit.Margin = New System.Windows.Forms.Padding(1)
    Me.btnEdit.Name = "btnEdit"
    Me.btnEdit.Size = New System.Drawing.Size(28, 28)
    Me.btnEdit.TabIndex = 1
    Me.tipCRUD.SetToolTip(Me.btnEdit, "Editar")
    Me.btnEdit.UseVisualStyleBackColor = True
    '
    'btnNew
    '
    Me.btnNew.Image = Global.WindowsFormsLib.My.Resources.Resources.add
    Me.btnNew.Location = New System.Drawing.Point(1, 1)
    Me.btnNew.Margin = New System.Windows.Forms.Padding(1)
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Size = New System.Drawing.Size(28, 28)
    Me.btnNew.TabIndex = 0
    Me.tipCRUD.SetToolTip(Me.btnNew, "Adicionar")
    Me.btnNew.UseVisualStyleBackColor = True
    '
    'tbpCRUD
    '
    Me.tbpCRUD.ColumnCount = 10
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.Controls.Add(Me.btnClose, 9, 0)
    Me.tbpCRUD.Controls.Add(Me.btnNew, 0, 0)
    Me.tbpCRUD.Controls.Add(Me.btnEdit, 1, 0)
    Me.tbpCRUD.Controls.Add(Me.btnDelete, 2, 0)
    Me.tbpCRUD.Controls.Add(Me.btnSave, 3, 0)
    Me.tbpCRUD.Controls.Add(Me.btnCancel, 4, 0)
    Me.tbpCRUD.Controls.Add(Me.btnRefresh, 5, 0)
    Me.tbpCRUD.Controls.Add(Me.btnNext, 8, 0)
    Me.tbpCRUD.Controls.Add(Me.btnPrint, 6, 0)
    Me.tbpCRUD.Controls.Add(Me.btnPrevious, 7, 0)
    Me.tbpCRUD.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbpCRUD.Location = New System.Drawing.Point(0, 0)
    Me.tbpCRUD.Margin = New System.Windows.Forms.Padding(1)
    Me.tbpCRUD.Name = "tbpCRUD"
    Me.tbpCRUD.RowCount = 1
    Me.tbpCRUD.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbpCRUD.Size = New System.Drawing.Size(300, 30)
    Me.tbpCRUD.TabIndex = 10
    '
    'UscCRUD
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.tbpCRUD)
    Me.Margin = New System.Windows.Forms.Padding(1)
    Me.Name = "UscCRUD"
    Me.Size = New System.Drawing.Size(300, 30)
    Me.tbpCRUD.ResumeLayout(False)
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
  Friend WithEvents tipCRUD As ToolTip
  Friend WithEvents btnRefresh As Button
  Friend WithEvents tbpCRUD As TableLayoutPanel
End Class
