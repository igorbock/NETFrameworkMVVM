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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bsEndereco = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanelMVVM = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCRUD = New WindowsFormsLib.UscCRUD()
        Me.txtNome = New WindowsFormsLib.UscTextBox()
        Me.txtCPF = New WindowsFormsLib.UscMaskedTextBox()
        Me.txtRG = New WindowsFormsLib.UscMaskedTextBox()
        Me.gPessoas = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNascimento = New System.Windows.Forms.DateTimePicker()
        Me.cmbEndereco = New System.Windows.Forms.ComboBox()
        CType(Me.bsEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelMVVM.SuspendLayout()
        CType(Me.gPessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsEndereco
        '
        Me.bsEndereco.DataSource = GetType(EntityFrameworkLib.Models.Endereco)
        '
        'TableLayoutPanelMVVM
        '
        Me.TableLayoutPanelMVVM.ColumnCount = 1
        Me.TableLayoutPanelMVVM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMVVM.Controls.Add(Me.btnCRUD, 0, 0)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.txtNome, 0, 1)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.txtCPF, 0, 2)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.txtRG, 0, 3)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.gPessoas, 0, 6)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.txtNascimento, 0, 4)
        Me.TableLayoutPanelMVVM.Controls.Add(Me.cmbEndereco, 0, 5)
        Me.TableLayoutPanelMVVM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMVVM.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMVVM.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanelMVVM.Name = "TableLayoutPanelMVVM"
        Me.TableLayoutPanelMVVM.RowCount = 7
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMVVM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMVVM.Size = New System.Drawing.Size(554, 418)
        Me.TableLayoutPanelMVVM.TabIndex = 0
        '
        'btnCRUD
        '
        Me.btnCRUD.CancelEnabled = True
        Me.btnCRUD.CloseEnabled = True
        Me.btnCRUD.DataGridView = Me.gPessoas
        Me.btnCRUD.EditEnabled = True
        Me.btnCRUD.Location = New System.Drawing.Point(1, 1)
        Me.btnCRUD.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCRUD.Name = "btnCRUD"
        Me.btnCRUD.NewEnabled = True
        Me.btnCRUD.NextEnabled = True
        Me.btnCRUD.PreviousEnabled = True
        Me.btnCRUD.PrintEnabled = True
        Me.btnCRUD.RefreshEnabled = True
        Me.btnCRUD.RemoveEnabled = True
        Me.btnCRUD.SaveEnabled = True
        Me.btnCRUD.Size = New System.Drawing.Size(554, 28)
        Me.btnCRUD.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.AutoSize = True
        Me.txtNome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNome.EditValue = ""
        Me.txtNome.IsPassword = False
        Me.txtNome.LabelText = "Nome"
        Me.txtNome.Location = New System.Drawing.Point(1, 31)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNome.MaxLength = 32767
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(554, 33)
        Me.txtNome.TabIndex = 6
        '
        'txtCPF
        '
        Me.txtCPF.AutoSize = True
        Me.txtCPF.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCPF.EditValue = ""
        Me.txtCPF.LabelText = "CPF"
        Me.txtCPF.Location = New System.Drawing.Point(1, 66)
        Me.txtCPF.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCPF.Mask = "000.000.000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(554, 33)
        Me.txtCPF.TabIndex = 10
        '
        'txtRG
        '
        Me.txtRG.AutoSize = True
        Me.txtRG.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRG.EditValue = ""
        Me.txtRG.LabelText = "RG"
        Me.txtRG.Location = New System.Drawing.Point(1, 101)
        Me.txtRG.Margin = New System.Windows.Forms.Padding(1)
        Me.txtRG.Mask = "0000000000"
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(554, 33)
        Me.txtRG.TabIndex = 11
        '
        'gPessoas
        '
        Me.gPessoas.AllowUserToAddRows = False
        Me.gPessoas.AllowUserToDeleteRows = False
        Me.gPessoas.AllowUserToResizeColumns = False
        Me.gPessoas.AllowUserToResizeRows = False
        Me.gPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gPessoas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gPessoas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gPessoas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gPessoas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNome, Me.colNascimento, Me.colCPF, Me.colRG, Me.colEndereco})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gPessoas.DefaultCellStyle = DataGridViewCellStyle2
        Me.gPessoas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gPessoas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gPessoas.Location = New System.Drawing.Point(1, 208)
        Me.gPessoas.Margin = New System.Windows.Forms.Padding(1)
        Me.gPessoas.MultiSelect = False
        Me.gPessoas.Name = "gPessoas"
        Me.gPessoas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Leelawadee", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gPessoas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gPessoas.RowHeadersVisible = False
        Me.gPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gPessoas.Size = New System.Drawing.Size(554, 209)
        Me.gPessoas.TabIndex = 12
        '
        'colId
        '
        Me.colId.DataPropertyName = "Id"
        Me.colId.FillWeight = 40.0!
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colNome
        '
        Me.colNome.DataPropertyName = "Nome"
        Me.colNome.FillWeight = 120.0!
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        Me.colNome.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colNascimento
        '
        Me.colNascimento.DataPropertyName = "Nascimento"
        Me.colNascimento.FillWeight = 80.0!
        Me.colNascimento.HeaderText = "Nascimento"
        Me.colNascimento.Name = "colNascimento"
        Me.colNascimento.ReadOnly = True
        Me.colNascimento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colCPF
        '
        Me.colCPF.DataPropertyName = "CPF"
        Me.colCPF.FillWeight = 99.61929!
        Me.colCPF.HeaderText = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.ReadOnly = True
        Me.colCPF.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colRG
        '
        Me.colRG.DataPropertyName = "RG"
        Me.colRG.FillWeight = 99.61929!
        Me.colRG.HeaderText = "RG"
        Me.colRG.Name = "colRG"
        Me.colRG.ReadOnly = True
        Me.colRG.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colEndereco
        '
        Me.colEndereco.DataPropertyName = "Endereco"
        Me.colEndereco.HeaderText = "Endereço"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.ReadOnly = True
        Me.colEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtNascimento
        '
        Me.txtNascimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNascimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtNascimento.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNascimento.Location = New System.Drawing.Point(1, 136)
        Me.txtNascimento.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNascimento.MinimumSize = New System.Drawing.Size(4, 33)
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(554, 33)
        Me.txtNascimento.TabIndex = 13
        Me.txtNascimento.Value = New Date(2024, 8, 6, 0, 0, 0, 0)
        '
        'cmbEndereco
        '
        Me.cmbEndereco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEndereco.DisplayMember = "EnderecoCompleto"
        Me.cmbEndereco.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEndereco.FormattingEnabled = True
        Me.cmbEndereco.ItemHeight = 16
        Me.cmbEndereco.Location = New System.Drawing.Point(1, 176)
        Me.cmbEndereco.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbEndereco.Name = "cmbEndereco"
        Me.cmbEndereco.Size = New System.Drawing.Size(554, 24)
        Me.cmbEndereco.TabIndex = 14
        Me.cmbEndereco.ValueMember = "Id"
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
        Me.Text = "Pessoa"
        CType(Me.bsEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelMVVM.ResumeLayout(False)
        Me.TableLayoutPanelMVVM.PerformLayout()
        CType(Me.gPessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanelMVVM As TableLayoutPanel
    Friend WithEvents bsEndereco As BindingSource
    Friend WithEvents btnCRUD As UscCRUD
    Friend WithEvents txtNome As UscTextBox
    Friend WithEvents txtCPF As UscMaskedTextBox
    Friend WithEvents txtRG As UscMaskedTextBox
    Friend WithEvents gPessoas As DataGridView
    Friend WithEvents txtNascimento As DateTimePicker
    Friend WithEvents cmbEndereco As ComboBox
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colNascimento As DataGridViewTextBoxColumn
    Friend WithEvents colCPF As DataGridViewTextBoxColumn
    Friend WithEvents colRG As DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As DataGridViewTextBoxColumn
End Class
