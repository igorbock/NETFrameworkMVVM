<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPessoa
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPessoa))
        Me.DateTimePickerNascimento = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanelPessoas = New System.Windows.Forms.TableLayoutPanel()
        Me.MaskedTextBoxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxRG = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.LabelEndereco = New System.Windows.Forms.Label()
        Me.LabelCPF = New System.Windows.Forms.Label()
        Me.cmbEndereco = New System.Windows.Forms.ComboBox()
        Me.bsEndereco = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelRG = New System.Windows.Forms.Label()
        Me.LabelNascimento = New System.Windows.Forms.Label()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.ButtonAdicionarEndereco = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonExcluir = New System.Windows.Forms.Button()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.GroupBoxPessoa = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelMVVM = New System.Windows.Forms.TableLayoutPanel()
        Me.UscDataGridViewPessoas = New WindowsFormsCRUD.UscDataGridViewPessoas()
        Me.GroupBoxComandos = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelComandos = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.btnCRUD = New WindowsFormsCRUD.UscCRUD()
        Me.TableLayoutPanelPessoas.SuspendLayout()
        CType(Me.bsEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPessoa.SuspendLayout()
        Me.TableLayoutPanelMVVM.SuspendLayout()
        Me.GroupBoxComandos.SuspendLayout()
        Me.TableLayoutPanelComandos.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerNascimento
        '
        Me.TableLayoutPanelPessoas.SetColumnSpan(Me.DateTimePickerNascimento, 2)
        Me.DateTimePickerNascimento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerNascimento.Location = New System.Drawing.Point(71, 67)
        Me.DateTimePickerNascimento.Margin = New System.Windows.Forms.Padding(1)
        Me.DateTimePickerNascimento.Name = "DateTimePickerNascimento"
        Me.DateTimePickerNascimento.Size = New System.Drawing.Size(476, 20)
        Me.DateTimePickerNascimento.TabIndex = 7
        '
        'TableLayoutPanelPessoas
        '
        Me.TableLayoutPanelPessoas.ColumnCount = 3
        Me.TableLayoutPanelPessoas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelPessoas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPessoas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanelPessoas.Controls.Add(Me.MaskedTextBoxCPF, 1, 1)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.MaskedTextBoxRG, 1, 2)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.TextBoxNome, 1, 0)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.LabelEndereco, 0, 4)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.LabelCPF, 0, 1)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.cmbEndereco, 1, 4)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.LabelRG, 0, 2)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.LabelNascimento, 0, 3)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.DateTimePickerNascimento, 1, 3)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.LabelNome, 0, 0)
        Me.TableLayoutPanelPessoas.Controls.Add(Me.ButtonAdicionarEndereco, 2, 4)
        Me.TableLayoutPanelPessoas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPessoas.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelPessoas.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanelPessoas.Name = "TableLayoutPanelPessoas"
        Me.TableLayoutPanelPessoas.RowCount = 5
        Me.TableLayoutPanelPessoas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanelPessoas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanelPessoas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanelPessoas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanelPessoas.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPessoas.Size = New System.Drawing.Size(548, 113)
        Me.TableLayoutPanelPessoas.TabIndex = 0
        '
        'MaskedTextBoxCPF
        '
        Me.TableLayoutPanelPessoas.SetColumnSpan(Me.MaskedTextBoxCPF, 2)
        Me.MaskedTextBoxCPF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaskedTextBoxCPF.Location = New System.Drawing.Point(71, 23)
        Me.MaskedTextBoxCPF.Margin = New System.Windows.Forms.Padding(1)
        Me.MaskedTextBoxCPF.Mask = "000.000.000-00"
        Me.MaskedTextBoxCPF.Name = "MaskedTextBoxCPF"
        Me.MaskedTextBoxCPF.Size = New System.Drawing.Size(476, 20)
        Me.MaskedTextBoxCPF.TabIndex = 3
        Me.MaskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MaskedTextBoxRG
        '
        Me.TableLayoutPanelPessoas.SetColumnSpan(Me.MaskedTextBoxRG, 2)
        Me.MaskedTextBoxRG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaskedTextBoxRG.Location = New System.Drawing.Point(71, 45)
        Me.MaskedTextBoxRG.Margin = New System.Windows.Forms.Padding(1)
        Me.MaskedTextBoxRG.Mask = "0000000000"
        Me.MaskedTextBoxRG.Name = "MaskedTextBoxRG"
        Me.MaskedTextBoxRG.Size = New System.Drawing.Size(476, 20)
        Me.MaskedTextBoxRG.TabIndex = 5
        '
        'TextBoxNome
        '
        Me.TableLayoutPanelPessoas.SetColumnSpan(Me.TextBoxNome, 2)
        Me.TextBoxNome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNome.Location = New System.Drawing.Point(71, 1)
        Me.TextBoxNome.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(476, 20)
        Me.TextBoxNome.TabIndex = 1
        '
        'LabelEndereco
        '
        Me.LabelEndereco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEndereco.AutoSize = True
        Me.LabelEndereco.Location = New System.Drawing.Point(1, 94)
        Me.LabelEndereco.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelEndereco.Name = "LabelEndereco"
        Me.LabelEndereco.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelEndereco.Size = New System.Drawing.Size(68, 13)
        Me.LabelEndereco.TabIndex = 8
        Me.LabelEndereco.Text = ":Endereço"
        '
        'LabelCPF
        '
        Me.LabelCPF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCPF.AutoSize = True
        Me.LabelCPF.Location = New System.Drawing.Point(1, 26)
        Me.LabelCPF.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelCPF.Name = "LabelCPF"
        Me.LabelCPF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelCPF.Size = New System.Drawing.Size(68, 13)
        Me.LabelCPF.TabIndex = 2
        Me.LabelCPF.Text = ":CPF"
        '
        'cmbEndereco
        '
        Me.cmbEndereco.DataSource = Me.bsEndereco
        Me.cmbEndereco.DisplayMember = "EnderecoCompleto"
        Me.cmbEndereco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEndereco.FormattingEnabled = True
        Me.cmbEndereco.Location = New System.Drawing.Point(71, 89)
        Me.cmbEndereco.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbEndereco.Name = "cmbEndereco"
        Me.cmbEndereco.Size = New System.Drawing.Size(440, 21)
        Me.cmbEndereco.TabIndex = 5
        Me.cmbEndereco.ValueMember = "Id"
        '
        'bsEndereco
        '
        Me.bsEndereco.DataSource = GetType(EntityFrameworkLib.Models.Endereco)
        '
        'LabelRG
        '
        Me.LabelRG.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRG.AutoSize = True
        Me.LabelRG.Location = New System.Drawing.Point(1, 48)
        Me.LabelRG.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelRG.Name = "LabelRG"
        Me.LabelRG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelRG.Size = New System.Drawing.Size(68, 13)
        Me.LabelRG.TabIndex = 4
        Me.LabelRG.Text = ":RG"
        '
        'LabelNascimento
        '
        Me.LabelNascimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelNascimento.AutoSize = True
        Me.LabelNascimento.Location = New System.Drawing.Point(1, 70)
        Me.LabelNascimento.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelNascimento.Name = "LabelNascimento"
        Me.LabelNascimento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelNascimento.Size = New System.Drawing.Size(68, 13)
        Me.LabelNascimento.TabIndex = 6
        Me.LabelNascimento.Text = ":Nascimento"
        '
        'LabelNome
        '
        Me.LabelNome.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(1, 4)
        Me.LabelNome.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelNome.Size = New System.Drawing.Size(68, 13)
        Me.LabelNome.TabIndex = 0
        Me.LabelNome.Text = ":Nome"
        '
        'ButtonAdicionarEndereco
        '
        Me.ButtonAdicionarEndereco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAdicionarEndereco.Image = CType(resources.GetObject("ButtonAdicionarEndereco.Image"), System.Drawing.Image)
        Me.ButtonAdicionarEndereco.Location = New System.Drawing.Point(513, 89)
        Me.ButtonAdicionarEndereco.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonAdicionarEndereco.Name = "ButtonAdicionarEndereco"
        Me.ButtonAdicionarEndereco.Size = New System.Drawing.Size(34, 23)
        Me.ButtonAdicionarEndereco.TabIndex = 10
        Me.ButtonAdicionarEndereco.UseVisualStyleBackColor = True
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.Location = New System.Drawing.Point(397, 1)
        Me.ButtonSalvar.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(73, 23)
        Me.ButtonSalvar.TabIndex = 1
        Me.ButtonSalvar.Text = "Salvar"
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'ButtonExcluir
        '
        Me.ButtonExcluir.Location = New System.Drawing.Point(155, 1)
        Me.ButtonExcluir.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonExcluir.Name = "ButtonExcluir"
        Me.ButtonExcluir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExcluir.TabIndex = 2
        Me.ButtonExcluir.Text = "Excluir"
        Me.ButtonExcluir.UseVisualStyleBackColor = True
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(1, 1)
        Me.ButtonNovo.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNovo.TabIndex = 0
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'GroupBoxPessoa
        '
        Me.GroupBoxPessoa.Controls.Add(Me.TableLayoutPanelPessoas)
        Me.GroupBoxPessoa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxPessoa.Enabled = False
        Me.GroupBoxPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPessoa.Location = New System.Drawing.Point(1, 1)
        Me.GroupBoxPessoa.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBoxPessoa.Name = "GroupBoxPessoa"
        Me.GroupBoxPessoa.Size = New System.Drawing.Size(554, 132)
        Me.GroupBoxPessoa.TabIndex = 0
        Me.GroupBoxPessoa.TabStop = False
        Me.GroupBoxPessoa.Text = "Pessoa"
        '
        'TableLayoutPanelMVVM
        '
        Me.TableLayoutPanelMVVM.ColumnCount = 1
        Me.TableLayoutPanelMVVM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMVVM.Controls.Add(Me.GroupBoxPessoa, 0, 0)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.UscDataGridViewPessoas, 0, 1)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.GroupBoxComandos, 0, 2)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.btnCRUD, 0, 3)
        Me.TableLayoutPanelMVVM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMVVM.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMVVM.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanelMVVM.Name = "TableLayoutPanelMVVM"
        Me.TableLayoutPanelMVVM.RowCount = 4
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelMVVM.Size = New System.Drawing.Size(554, 418)
        Me.TableLayoutPanelMVVM.TabIndex = 0
        '
        'UscDataGridViewPessoas
        '
        Me.UscDataGridViewPessoas.DataSource = Nothing
        Me.UscDataGridViewPessoas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UscDataGridViewPessoas.Location = New System.Drawing.Point(3, 137)
        Me.UscDataGridViewPessoas.Name = "UscDataGridViewPessoas"
        Me.UscDataGridViewPessoas.Pessoa = Nothing
        Me.UscDataGridViewPessoas.Size = New System.Drawing.Size(550, 202)
        Me.UscDataGridViewPessoas.TabIndex = 3
        '
        'GroupBoxComandos
        '
        Me.GroupBoxComandos.Controls.Add(Me.TableLayoutPanelComandos)
        Me.GroupBoxComandos.Location = New System.Drawing.Point(1, 343)
        Me.GroupBoxComandos.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBoxComandos.Name = "GroupBoxComandos"
        Me.GroupBoxComandos.Size = New System.Drawing.Size(554, 44)
        Me.GroupBoxComandos.TabIndex = 1
        Me.GroupBoxComandos.TabStop = False
        Me.GroupBoxComandos.Text = "Comandos"
        '
        'TableLayoutPanelComandos
        '
        Me.TableLayoutPanelComandos.ColumnCount = 6
        Me.TableLayoutPanelComandos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelComandos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelComandos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelComandos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanelComandos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelComandos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelComandos.Controls.Add(Me.ButtonEditar, 1, 0)
        Me.TableLayoutPanelComandos.Controls.Add(Me.ButtonNovo, 0, 0)
        Me.TableLayoutPanelComandos.Controls.Add(Me.ButtonExcluir, 2, 0)
        Me.TableLayoutPanelComandos.Controls.Add(Me.ButtonCancelar, 5, 0)
        Me.TableLayoutPanelComandos.Controls.Add(Me.ButtonSalvar, 4, 0)
        Me.TableLayoutPanelComandos.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelComandos.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanelComandos.Name = "TableLayoutPanelComandos"
        Me.TableLayoutPanelComandos.RowCount = 1
        Me.TableLayoutPanelComandos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelComandos.Size = New System.Drawing.Size(548, 25)
        Me.TableLayoutPanelComandos.TabIndex = 0
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Location = New System.Drawing.Point(78, 1)
        Me.ButtonEditar.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditar.TabIndex = 1
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(472, 1)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 4
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'btnCRUD
        '
        Me.btnCRUD.CancelEnabled = True
        Me.btnCRUD.EditEnabled = True
        Me.btnCRUD.Location = New System.Drawing.Point(1, 389)
        Me.btnCRUD.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCRUD.Name = "btnCRUD"
        Me.btnCRUD.NewEnabled = True
        Me.btnCRUD.NextEnabled = True
        Me.btnCRUD.PreviousEnabled = True
        Me.btnCRUD.PrintEnabled = True
        Me.btnCRUD.RemoveEnabled = True
        Me.btnCRUD.SaveEnabled = True
        Me.btnCRUD.Size = New System.Drawing.Size(217, 28)
        Me.btnCRUD.TabIndex = 5
        '
        'frmPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 418)
        Me.Controls.Add(Me.TableLayoutPanelMVVM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPessoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MVVM"
        Me.TableLayoutPanelPessoas.ResumeLayout(False)
        Me.TableLayoutPanelPessoas.PerformLayout()
        CType(Me.bsEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPessoa.ResumeLayout(False)
        Me.TableLayoutPanelMVVM.ResumeLayout(False)
        Me.GroupBoxComandos.ResumeLayout(False)
        Me.TableLayoutPanelComandos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePickerNascimento As DateTimePicker
  Friend WithEvents TableLayoutPanelPessoas As TableLayoutPanel
  Friend WithEvents ButtonSalvar As Button
  Friend WithEvents ButtonExcluir As Button
  Friend WithEvents ButtonNovo As Button
  Friend WithEvents TextBoxNome As TextBox
  Friend WithEvents LabelNome As Label
  Friend WithEvents LabelCPF As Label
  Friend WithEvents LabelRG As Label
  Friend WithEvents LabelEndereco As Label
  Friend WithEvents LabelNascimento As Label
    Friend WithEvents MaskedTextBoxCPF As MaskedTextBox
    Friend WithEvents MaskedTextBoxRG As MaskedTextBox
  Friend WithEvents GroupBoxPessoa As GroupBox
  Friend WithEvents TableLayoutPanelMVVM As TableLayoutPanel
  Friend WithEvents GroupBoxComandos As GroupBox
  Friend WithEvents TableLayoutPanelComandos As TableLayoutPanel
  Friend WithEvents UscDataGridViewPessoas As UscDataGridViewPessoas
  Friend WithEvents ButtonEditar As Button
  Friend WithEvents ButtonCancelar As Button
  Friend WithEvents ButtonAdicionarEndereco As Button
    Friend WithEvents cmbEndereco As ComboBox
    Friend WithEvents bsEndereco As BindingSource
    Friend WithEvents btnCRUD As UscCRUD
End Class
