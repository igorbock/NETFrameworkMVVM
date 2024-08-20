<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovoUsuario
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
        Me.tbpRegistro = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtNome = New WindowsFormsCRUD.UscTextBox()
        Me.txtSenha = New WindowsFormsCRUD.UscTextBox()
        Me.txtConfirmaSenha = New WindowsFormsCRUD.UscTextBox()
        Me.tbpRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpRegistro
        '
        Me.tbpRegistro.ColumnCount = 2
        Me.tbpRegistro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbpRegistro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbpRegistro.Controls.Add(Me.txtNome, 0, 0)
        Me.tbpRegistro.Controls.Add(Me.txtSenha, 0, 1)
        Me.tbpRegistro.Controls.Add(Me.txtConfirmaSenha, 0, 2)
        Me.tbpRegistro.Controls.Add(Me.btnConfirmar, 0, 3)
        Me.tbpRegistro.Controls.Add(Me.btnSair, 1, 3)
        Me.tbpRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpRegistro.Location = New System.Drawing.Point(0, 0)
        Me.tbpRegistro.Margin = New System.Windows.Forms.Padding(1)
        Me.tbpRegistro.Name = "tbpRegistro"
        Me.tbpRegistro.RowCount = 4
        Me.tbpRegistro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tbpRegistro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tbpRegistro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tbpRegistro.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tbpRegistro.Size = New System.Drawing.Size(302, 132)
        Me.tbpRegistro.TabIndex = 0
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirmar.Location = New System.Drawing.Point(1, 106)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(149, 25)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSair.Location = New System.Drawing.Point(152, 106)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(149, 25)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.AutoSize = True
        Me.txtNome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpRegistro.SetColumnSpan(Me.txtNome, 2)
        Me.txtNome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNome.EditValue = ""
        Me.txtNome.IsPassword = False
        Me.txtNome.LabelText = "Nome"
        Me.txtNome.Location = New System.Drawing.Point(1, 1)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNome.MaxLength = 255
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(300, 33)
        Me.txtNome.TabIndex = 0
        '
        'txtSenha
        '
        Me.txtSenha.AutoSize = True
        Me.txtSenha.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpRegistro.SetColumnSpan(Me.txtSenha, 2)
        Me.txtSenha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSenha.EditValue = ""
        Me.txtSenha.IsPassword = True
        Me.txtSenha.LabelText = "Senha"
        Me.txtSenha.Location = New System.Drawing.Point(1, 36)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSenha.MaxLength = 255
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(300, 33)
        Me.txtSenha.TabIndex = 1
        '
        'txtConfirmaSenha
        '
        Me.txtConfirmaSenha.AutoSize = True
        Me.txtConfirmaSenha.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtConfirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpRegistro.SetColumnSpan(Me.txtConfirmaSenha, 2)
        Me.txtConfirmaSenha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConfirmaSenha.EditValue = ""
        Me.txtConfirmaSenha.IsPassword = True
        Me.txtConfirmaSenha.LabelText = "Confirma Senha"
        Me.txtConfirmaSenha.Location = New System.Drawing.Point(1, 71)
        Me.txtConfirmaSenha.Margin = New System.Windows.Forms.Padding(1)
        Me.txtConfirmaSenha.MaxLength = 32767
        Me.txtConfirmaSenha.Name = "txtConfirmaSenha"
        Me.txtConfirmaSenha.Size = New System.Drawing.Size(300, 33)
        Me.txtConfirmaSenha.TabIndex = 2
        '
        'frmNovoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 132)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbpRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNovoUsuario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de usuário"
        Me.tbpRegistro.ResumeLayout(False)
        Me.tbpRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpRegistro As TableLayoutPanel
    Friend WithEvents txtNome As UscTextBox
    Friend WithEvents txtSenha As UscTextBox
    Friend WithEvents txtConfirmaSenha As UscTextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnSair As Button
End Class
