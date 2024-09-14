<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreenApp
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
    Me.PictureBox = New System.Windows.Forms.PictureBox()
    CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox
    '
    Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox.Image = Global.WindowsFormsLib.My.Resources.Resources.AppCRUD
    Me.PictureBox.Location = New System.Drawing.Point(0, 0)
    Me.PictureBox.Name = "PictureBox"
    Me.PictureBox.Size = New System.Drawing.Size(399, 318)
    Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.PictureBox.TabIndex = 1
    Me.PictureBox.TabStop = False
    '
    'SplashScreenApp
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(399, 318)
    Me.ControlBox = False
    Me.Controls.Add(Me.PictureBox)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "SplashScreenApp"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PictureBox As PictureBox
End Class
