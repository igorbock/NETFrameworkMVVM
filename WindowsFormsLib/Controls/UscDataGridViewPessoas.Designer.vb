<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UscDataGridViewPessoas
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.DataGridViewPessoas = New System.Windows.Forms.DataGridView()
    Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colNascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colCPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewPessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPessoas
        '
        Me.DataGridViewPessoas.AllowUserToAddRows = False
        Me.DataGridViewPessoas.AllowUserToDeleteRows = False
        Me.DataGridViewPessoas.AllowUserToResizeColumns = False
        Me.DataGridViewPessoas.AllowUserToResizeRows = False
        Me.DataGridViewPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPessoas.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewPessoas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewPessoas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridViewPessoas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPessoas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPessoas.ColumnHeadersHeight = 24
        Me.DataGridViewPessoas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNome, Me.colNascimento, Me.colCPF, Me.colRG})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPessoas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewPessoas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPessoas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridViewPessoas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewPessoas.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridViewPessoas.MultiSelect = False
        Me.DataGridViewPessoas.Name = "DataGridViewPessoas"
        Me.DataGridViewPessoas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPessoas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPessoas.RowHeadersVisible = False
        Me.DataGridViewPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPessoas.Size = New System.Drawing.Size(375, 263)
        Me.DataGridViewPessoas.TabIndex = 1
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
        'UscDataGridViewPessoas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridViewPessoas)
        Me.Name = "UscDataGridViewPessoas"
        Me.Size = New System.Drawing.Size(375, 263)
        CType(Me.DataGridViewPessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewPessoas As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colNascimento As DataGridViewTextBoxColumn
    Friend WithEvents colCPF As DataGridViewTextBoxColumn
    Friend WithEvents colRG As DataGridViewTextBoxColumn
End Class
