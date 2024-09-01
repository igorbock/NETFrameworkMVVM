<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnPessoa = New System.Windows.Forms.ToolStripButton()
        Me.btnEndereco = New System.Windows.Forms.ToolStripButton()
        Me.tbcWindowsCRUD = New System.Windows.Forms.TabControl()
        Me.tbpCadastros = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.sttLogin = New System.Windows.Forms.StatusStrip()
        Me.btnLogout = New System.Windows.Forms.ToolStripSplitButton()
        Me.lblExpiracao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbcPages = New System.Windows.Forms.TabControl()
        Me.btnVersao = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnAtualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAtualizarRecente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip.SuspendLayout()
        Me.tbcWindowsCRUD.SuspendLayout()
        Me.tbpCadastros.SuspendLayout()
        Me.sttLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.CanOverflow = False
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPessoa, Me.btnEndereco})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(786, 60)
        Me.ToolStrip.TabIndex = 0
        '
        'btnPessoa
        '
        Me.btnPessoa.Image = Global.WindowsFormsCRUD.My.Resources.Resources.homem_de_negocios1
        Me.btnPessoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPessoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPessoa.Name = "btnPessoa"
        Me.btnPessoa.Size = New System.Drawing.Size(47, 57)
        Me.btnPessoa.Text = "Pessoa"
        Me.btnPessoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPessoa.ToolTipText = "Cadastro de Pessoa"
        '
        'btnEndereco
        '
        Me.btnEndereco.Image = Global.WindowsFormsCRUD.My.Resources.Resources.localizador_de_mapa
        Me.btnEndereco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEndereco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEndereco.Name = "btnEndereco"
        Me.btnEndereco.Size = New System.Drawing.Size(60, 57)
        Me.btnEndereco.Text = "Endereço"
        Me.btnEndereco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEndereco.ToolTipText = "Cadastro de Endereço"
        '
        'tbcWindowsCRUD
        '
        Me.tbcWindowsCRUD.Controls.Add(Me.tbpCadastros)
        Me.tbcWindowsCRUD.Controls.Add(Me.TabPage2)
        Me.tbcWindowsCRUD.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbcWindowsCRUD.Location = New System.Drawing.Point(0, 0)
        Me.tbcWindowsCRUD.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcWindowsCRUD.Name = "tbcWindowsCRUD"
        Me.tbcWindowsCRUD.SelectedIndex = 0
        Me.tbcWindowsCRUD.Size = New System.Drawing.Size(800, 90)
        Me.tbcWindowsCRUD.TabIndex = 1
        '
        'tbpCadastros
        '
        Me.tbpCadastros.Controls.Add(Me.ToolStrip)
        Me.tbpCadastros.Location = New System.Drawing.Point(4, 22)
        Me.tbpCadastros.Name = "tbpCadastros"
        Me.tbpCadastros.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCadastros.Size = New System.Drawing.Size(792, 64)
        Me.tbpCadastros.TabIndex = 0
        Me.tbpCadastros.Text = "Cadastros"
        Me.tbpCadastros.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 64)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Teste"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'sttLogin
        '
        Me.sttLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLogout, Me.lblExpiracao, Me.lblUsuario, Me.btnVersao})
        Me.sttLogin.Location = New System.Drawing.Point(0, 428)
        Me.sttLogin.Name = "sttLogin"
        Me.sttLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sttLogin.Size = New System.Drawing.Size(800, 22)
        Me.sttLogin.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnLogout.Image = Global.WindowsFormsCRUD.My.Resources.Resources.porta
        Me.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLogout.Size = New System.Drawing.Size(75, 20)
        Me.btnLogout.Text = "Logout"
        '
        'lblExpiracao
        '
        Me.lblExpiracao.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblExpiracao.Name = "lblExpiracao"
        Me.lblExpiracao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExpiracao.Size = New System.Drawing.Size(69, 17)
        Me.lblExpiracao.Text = "Expira em |"
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUsuario.Size = New System.Drawing.Size(56, 17)
        Me.lblUsuario.Text = "Usuário |"
        '
        'tbcPages
        '
        Me.tbcPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPages.Location = New System.Drawing.Point(0, 90)
        Me.tbcPages.Name = "tbcPages"
        Me.tbcPages.SelectedIndex = 0
        Me.tbcPages.Size = New System.Drawing.Size(800, 338)
        Me.tbcPages.TabIndex = 3
        '
        'btnVersao
        '
        Me.btnVersao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVersao.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAtualizarRecente, Me.btnAtualizar})
        Me.btnVersao.Image = CType(resources.GetObject("btnVersao.Image"), System.Drawing.Image)
        Me.btnVersao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVersao.Name = "btnVersao"
        Me.btnVersao.Size = New System.Drawing.Size(29, 20)
        Me.btnVersao.Text = "ToolStripDropDownButton1"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(216, 22)
        Me.btnAtualizar.Text = "Atualizar"
        '
        'btnAtualizarRecente
        '
        Me.btnAtualizarRecente.Name = "btnAtualizarRecente"
        Me.btnAtualizarRecente.Size = New System.Drawing.Size(216, 22)
        Me.btnAtualizarRecente.Text = "Buscar versão mais recente"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbcPages)
        Me.Controls.Add(Me.sttLogin)
        Me.Controls.Add(Me.tbcWindowsCRUD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.tbcWindowsCRUD.ResumeLayout(False)
        Me.tbpCadastros.ResumeLayout(False)
        Me.sttLogin.ResumeLayout(False)
        Me.sttLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents btnPessoa As ToolStripButton
    Friend WithEvents tbcWindowsCRUD As TabControl
    Friend WithEvents tbpCadastros As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnEndereco As ToolStripButton
    Friend WithEvents sttLogin As StatusStrip
    Friend WithEvents lblUsuario As ToolStripStatusLabel
    Friend WithEvents lblExpiracao As ToolStripStatusLabel
    Friend WithEvents btnLogout As ToolStripSplitButton
    Friend WithEvents tbcPages As TabControl
    Friend WithEvents btnVersao As ToolStripDropDownButton
    Friend WithEvents btnAtualizarRecente As ToolStripMenuItem
    Friend WithEvents btnAtualizar As ToolStripMenuItem
End Class
