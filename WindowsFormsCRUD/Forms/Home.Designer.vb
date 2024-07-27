<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tbcWindowsCRUD = New System.Windows.Forms.TabControl()
        Me.tbpCadastros = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnPessoa = New System.Windows.Forms.ToolStripButton()
        Me.btnEndereco = New System.Windows.Forms.ToolStripButton()
        Me.tbcPages = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ToolStrip.SuspendLayout()
        Me.tbcWindowsCRUD.SuspendLayout()
        Me.tbpCadastros.SuspendLayout()
        Me.tbcPages.SuspendLayout()
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
        'btnPessoa
        '
        Me.btnPessoa.Image = Global.WindowsFormsCRUD.My.Resources.Resources.homem_de_negocios1
        Me.btnPessoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPessoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPessoa.Name = "btnPessoa"
        Me.btnPessoa.Size = New System.Drawing.Size(47, 57)
        Me.btnPessoa.Text = "Pessoa"
        Me.btnPessoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        '
        'tbcPages
        '
        Me.tbcPages.Controls.Add(Me.TabPage1)
        Me.tbcPages.Controls.Add(Me.TabPage3)
        Me.tbcPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPages.Location = New System.Drawing.Point(0, 90)
        Me.tbcPages.Margin = New System.Windows.Forms.Padding(1)
        Me.tbcPages.Name = "tbcPages"
        Me.tbcPages.SelectedIndex = 0
        Me.tbcPages.Size = New System.Drawing.Size(800, 360)
        Me.tbcPages.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 334)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(192, 74)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbcPages)
        Me.Controls.Add(Me.tbcWindowsCRUD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.tbcWindowsCRUD.ResumeLayout(False)
        Me.tbpCadastros.ResumeLayout(False)
        Me.tbcPages.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents btnPessoa As ToolStripButton
    Friend WithEvents tbcWindowsCRUD As TabControl
    Friend WithEvents tbpCadastros As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnEndereco As ToolStripButton
    Friend WithEvents tbcPages As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
End Class
