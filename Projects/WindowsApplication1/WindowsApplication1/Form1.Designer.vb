<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chklaki = New System.Windows.Forms.CheckBox()
        Me.chkperempuan = New System.Windows.Forms.CheckBox()
        Me.btntampil = New System.Windows.Forms.Button()
        Me.txttampil = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'chklaki
        '
        Me.chklaki.AutoSize = True
        Me.chklaki.Location = New System.Drawing.Point(56, 57)
        Me.chklaki.Name = "chklaki"
        Me.chklaki.Size = New System.Drawing.Size(110, 24)
        Me.chklaki.TabIndex = 0
        Me.chklaki.Text = "LAKI-LAKI"
        Me.chklaki.UseVisualStyleBackColor = True
        '
        'chkperempuan
        '
        Me.chkperempuan.AutoSize = True
        Me.chkperempuan.Location = New System.Drawing.Point(56, 124)
        Me.chkperempuan.Name = "chkperempuan"
        Me.chkperempuan.Size = New System.Drawing.Size(117, 24)
        Me.chkperempuan.TabIndex = 1
        Me.chkperempuan.Text = "Perempuan"
        Me.chkperempuan.UseVisualStyleBackColor = True
        '
        'btntampil
        '
        Me.btntampil.Location = New System.Drawing.Point(73, 192)
        Me.btntampil.Name = "btntampil"
        Me.btntampil.Size = New System.Drawing.Size(89, 32)
        Me.btntampil.TabIndex = 2
        Me.btntampil.Text = "Tampil"
        Me.btntampil.UseVisualStyleBackColor = True
        '
        'txttampil
        '
        Me.txttampil.Location = New System.Drawing.Point(278, 52)
        Me.txttampil.Name = "txttampil"
        Me.txttampil.Size = New System.Drawing.Size(233, 116)
        Me.txttampil.TabIndex = 3
        Me.txttampil.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 457)
        Me.Controls.Add(Me.txttampil)
        Me.Controls.Add(Me.btntampil)
        Me.Controls.Add(Me.chkperempuan)
        Me.Controls.Add(Me.chklaki)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chklaki As System.Windows.Forms.CheckBox
    Friend WithEvents chkperempuan As System.Windows.Forms.CheckBox
    Friend WithEvents btntampil As System.Windows.Forms.Button
    Friend WithEvents txttampil As System.Windows.Forms.RichTextBox

End Class
