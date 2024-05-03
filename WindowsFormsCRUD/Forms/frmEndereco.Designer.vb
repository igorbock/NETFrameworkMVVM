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
        Me.TableLayoutPanelEndereco = New System.Windows.Forms.TableLayoutPanel()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.TableLayoutPanelEndereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelEndereco
        '
        Me.TableLayoutPanelEndereco.ColumnCount = 2
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelEndereco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtRua, 1, 0)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtNumero, 1, 1)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtCidade, 1, 2)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.txtEstado, 1, 3)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.lblRua, 0, 0)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.lblNumero, 0, 1)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.lblCidade, 0, 2)
        Me.TableLayoutPanelEndereco.Controls.Add(Me.lblEstado, 0, 3)
        Me.TableLayoutPanelEndereco.Location = New System.Drawing.Point(27, 12)
        Me.TableLayoutPanelEndereco.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanelEndereco.Name = "TableLayoutPanelEndereco"
        Me.TableLayoutPanelEndereco.RowCount = 5
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.91358!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.08642!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanelEndereco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241.0!))
        Me.TableLayoutPanelEndereco.Size = New System.Drawing.Size(446, 386)
        Me.TableLayoutPanelEndereco.TabIndex = 0
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(226, 3)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(100, 20)
        Me.txtRua.TabIndex = 0
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(226, 32)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 1
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(226, 64)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCidade.TabIndex = 2
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(226, 109)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 3
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Location = New System.Drawing.Point(3, 0)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(27, 13)
        Me.lblRua.TabIndex = 4
        Me.lblRua.Text = "Rua"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(3, 29)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 5
        Me.lblNumero.Text = "Número"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(3, 61)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 6
        Me.lblCidade.Text = "Cidade"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(3, 106)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 7
        Me.lblEstado.Text = "Estado"
        '
        'frmEndereco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 408)
        Me.Controls.Add(Me.TableLayoutPanelEndereco)
        Me.Name = "frmEndereco"
        Me.Text = "frmEndereco"
        Me.TableLayoutPanelEndereco.ResumeLayout(False)
        Me.TableLayoutPanelEndereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelEndereco As TableLayoutPanel
    Friend WithEvents txtRua As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblRua As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblEstado As Label
End Class
