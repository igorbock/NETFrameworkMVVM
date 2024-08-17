<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.tbpLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtUser = New WindowsFormsCRUD.UscTextBox()
        Me.txtSenha = New WindowsFormsCRUD.UscTextBox()
        Me.tbpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpLogin
        '
        Me.tbpLogin.ColumnCount = 3
        Me.tbpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tbpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tbpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tbpLogin.Controls.Add(Me.txtUser, 0, 0)
        Me.tbpLogin.Controls.Add(Me.txtSenha, 0, 1)
        Me.tbpLogin.Controls.Add(Me.btnEntrar, 0, 2)
        Me.tbpLogin.Controls.Add(Me.btnSair, 1, 2)
        Me.tbpLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpLogin.Location = New System.Drawing.Point(0, 0)
        Me.tbpLogin.Margin = New System.Windows.Forms.Padding(1)
        Me.tbpLogin.Name = "tbpLogin"
        Me.tbpLogin.RowCount = 4
        Me.tbpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tbpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tbpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tbpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tbpLogin.Size = New System.Drawing.Size(302, 97)
        Me.tbpLogin.TabIndex = 0
        '
        'btnEntrar
        '
        Me.btnEntrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEntrar.Location = New System.Drawing.Point(1, 71)
        Me.btnEntrar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(148, 23)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSair.Location = New System.Drawing.Point(151, 71)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(148, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.AutoSize = True
        Me.txtUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpLogin.SetColumnSpan(Me.txtUser, 3)
        Me.txtUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUser.EditValue = ""
        Me.txtUser.IsPassword = False
        Me.txtUser.LabelText = "Usuário"
        Me.txtUser.Location = New System.Drawing.Point(1, 1)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(300, 33)
        Me.txtUser.TabIndex = 0
        '
        'txtSenha
        '
        Me.txtSenha.AutoSize = True
        Me.txtSenha.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpLogin.SetColumnSpan(Me.txtSenha, 3)
        Me.txtSenha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSenha.EditValue = ""
        Me.txtSenha.IsPassword = True
        Me.txtSenha.LabelText = "Senha"
        Me.txtSenha.Location = New System.Drawing.Point(1, 36)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSenha.MaxLength = 32767
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(300, 33)
        Me.txtSenha.TabIndex = 1
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 97)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbpLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.tbpLogin.ResumeLayout(False)
        Me.tbpLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpLogin As TableLayoutPanel
    Friend WithEvents txtUser As UscTextBox
    Friend WithEvents txtSenha As UscTextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnSair As Button
End Class
