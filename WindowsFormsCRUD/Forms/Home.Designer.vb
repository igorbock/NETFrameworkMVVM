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
        Me.tbcPages = New System.Windows.Forms.TabControl()
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip.SuspendLayout()
        Me.tbcWindowsCRUD.SuspendLayout()
        Me.tbpCadastros.SuspendLayout()
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        'tbcPages
        '
        Me.tbcPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPages.Location = New System.Drawing.Point(0, 0)
        Me.tbcPages.Margin = New System.Windows.Forms.Padding(1)
        Me.tbcPages.Name = "tbcPages"
        Me.tbcPages.SelectedIndex = 0
        Me.tbcPages.Size = New System.Drawing.Size(800, 335)
        Me.tbcPages.TabIndex = 2
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.tbcPages)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(800, 335)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 90)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(800, 360)
        Me.ToolStripContainer.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(3)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(170, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel1.Text = "Número:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Controls.Add(Me.tbcWindowsCRUD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.tbcWindowsCRUD.ResumeLayout(False)
        Me.tbpCadastros.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents btnPessoa As ToolStripButton
    Friend WithEvents tbcWindowsCRUD As TabControl
    Friend WithEvents tbpCadastros As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnEndereco As ToolStripButton
    Friend WithEvents tbcPages As TabControl
    Friend WithEvents ToolStripContainer As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
End Class
