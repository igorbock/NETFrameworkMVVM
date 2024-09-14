<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndereco
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanelEndereco = New System.Windows.Forms.TableLayoutPanel()
        Me.gEnderecos = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnderecoCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRua = New WindowsFormsLib.UscTextBox()
        Me.txtCidade = New WindowsFormsLib.UscTextBox()
        Me.txtEstado = New WindowsFormsLib.UscTextBox()
        Me.txtNumero = New WindowsFormsLib.UscNumeric()
        Me.btnCRUD = New WindowsFormsLib.UscCRUD()
        Me.TableLayoutPanelEndereco.SuspendLayout()
        CType(Me.gEnderecos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelEndereco
        '
        Me.TableLayoutPanelEndereco.ColumnCount = 6
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtRua, 0, 1)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtCidade, 0, 3)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtEstado, 0, 4)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.gEnderecos, 0, 5)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtNumero, 0, 2)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.btnCRUD, 0, 0)
        Me.TableLayoutPanelEndereco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelEndereco.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelEndereco.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanelEndereco.Name = "TableLayoutPanelEndereco"
        Me.TableLayoutPanelEndereco.RowCount = 6
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndereco.Size = New System.Drawing.Size(504, 408)
        Me.TableLayoutPanelEndereco.TabIndex = 0
        '
        'gEnderecos
        '
        Me.gEnderecos.AllowUserToAddRows = False
        Me.gEnderecos.AllowUserToDeleteRows = False
        Me.gEnderecos.AllowUserToResizeColumns = False
        Me.gEnderecos.AllowUserToResizeRows = False
        Me.gEnderecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gEnderecos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gEnderecos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gEnderecos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gEnderecos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colRua, Me.colNumero, Me.colCidade, Me.colEstado, Me.colEnderecoCompleto})
        Me.TableLayoutPanelEndereco.SetColumnSpan(Me.gEnderecos, 6)
        Me.gEnderecos.DataMember = "Endereco"
        Me.gEnderecos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gEnderecos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gEnderecos.Location = New System.Drawing.Point(1, 171)
        Me.gEnderecos.Margin = New System.Windows.Forms.Padding(1)
        Me.gEnderecos.MultiSelect = False
        Me.gEnderecos.Name = "gEnderecos"
        Me.gEnderecos.ReadOnly = True
        Me.gEnderecos.RowHeadersVisible = False
        Me.gEnderecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gEnderecos.Size = New System.Drawing.Size(502, 236)
        Me.gEnderecos.TabIndex = 5
        '
        'colId
        '
        Me.colId.DataPropertyName = "Id"
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colId.Visible = False
        '
        'colRua
        '
        Me.colRua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRua.DataPropertyName = "Rua"
        Me.colRua.HeaderText = "Rua"
        Me.colRua.Name = "colRua"
        Me.colRua.ReadOnly = True
        Me.colRua.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colNumero
        '
        Me.colNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNumero.DataPropertyName = "Numero"
        Me.colNumero.HeaderText = "Número"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        Me.colNumero.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colCidade
        '
        Me.colCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCidade.DataPropertyName = "Cidade"
        Me.colCidade.HeaderText = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.ReadOnly = True
        Me.colCidade.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colEstado
        '
        Me.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEstado.DataPropertyName = "Estado"
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colEnderecoCompleto
        '
        Me.colEnderecoCompleto.DataPropertyName = "EnderecoCompleto"
        Me.colEnderecoCompleto.HeaderText = "Endereço Completo"
        Me.colEnderecoCompleto.Name = "colEnderecoCompleto"
        Me.colEnderecoCompleto.ReadOnly = True
        Me.colEnderecoCompleto.Visible = False
        '
        'txtRua
        '
        Me.txtRua.AutoSize = True
        Me.txtRua.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanelEndereco.SetColumnSpan(Me.txtRua, 6)
        Me.txtRua.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRua.EditValue = ""
        Me.txtRua.IsPassword = False
        Me.txtRua.LabelText = "Rua"
        Me.txtRua.Location = New System.Drawing.Point(1, 31)
        Me.txtRua.Margin = New System.Windows.Forms.Padding(1)
        Me.txtRua.MaxLength = 50
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(502, 33)
        Me.txtRua.TabIndex = 1
        '
        'txtCidade
        '
        Me.txtCidade.AutoSize = True
        Me.txtCidade.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanelEndereco.SetColumnSpan(Me.txtCidade, 6)
        Me.txtCidade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCidade.EditValue = ""
        Me.txtCidade.IsPassword = False
        Me.txtCidade.LabelText = "Cidade"
        Me.txtCidade.Location = New System.Drawing.Point(1, 101)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCidade.MaxLength = 30
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(502, 33)
        Me.txtCidade.TabIndex = 3
        '
        'txtEstado
        '
        Me.txtEstado.AutoSize = True
        Me.txtEstado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanelEndereco.SetColumnSpan(Me.txtEstado, 6)
        Me.txtEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEstado.EditValue = ""
        Me.txtEstado.IsPassword = False
        Me.txtEstado.LabelText = "Estado"
        Me.txtEstado.Location = New System.Drawing.Point(1, 136)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEstado.MaxLength = 2
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(502, 33)
        Me.txtEstado.TabIndex = 4
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanelEndereco.SetColumnSpan(Me.txtNumero, 6)
        Me.txtNumero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumero.EditValue = ""
        Me.txtNumero.LabelText = "Número"
        Me.txtNumero.Location = New System.Drawing.Point(1, 66)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(502, 33)
        Me.txtNumero.TabIndex = 2
        '
        'btnCRUD
        '
        Me.btnCRUD.CancelEnabled = True
        Me.btnCRUD.CloseEnabled = True
        Me.TableLayoutPanelEndereco.SetColumnSpan(Me.btnCRUD, 6)
        Me.btnCRUD.DataGridView = Me.gEnderecos
        Me.btnCRUD.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.btnCRUD.Size = New System.Drawing.Size(502, 28)
        Me.btnCRUD.TabIndex = 0
        '
        'frmEndereco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 408)
        Me.Controls.Add(Me.TableLayoutPanelEndereco)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEndereco"
        Me.Text = "Endereço"
        Me.TableLayoutPanelEndereco.ResumeLayout(False)
        Me.TableLayoutPanelEndereco.PerformLayout()
        CType(Me.gEnderecos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelEndereco As TableLayoutPanel
    Friend WithEvents txtRua As UscTextBox
    Friend WithEvents txtCidade As UscTextBox
    Friend WithEvents txtEstado As UscTextBox
    Friend WithEvents gEnderecos As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colRua As DataGridViewTextBoxColumn
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colCidade As DataGridViewTextBoxColumn
    Friend WithEvents colEstado As DataGridViewTextBoxColumn
    Friend WithEvents colEnderecoCompleto As DataGridViewTextBoxColumn
    Friend WithEvents txtNumero As UscNumeric
    Friend WithEvents btnCRUD As UscCRUD
End Class
