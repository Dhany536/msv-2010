<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFungsi2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btneqit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bilangan = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbilsatu = New System.Windows.Forms.TextBox()
        Me.txtbildua = New System.Windows.Forms.TextBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Hitung Bilangan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btneqit
        '
        Me.btneqit.Location = New System.Drawing.Point(539, 387)
        Me.btneqit.Name = "btneqit"
        Me.btneqit.Size = New System.Drawing.Size(144, 45)
        Me.btneqit.TabIndex = 1
        Me.btneqit.Text = "eqit"
        Me.btneqit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 294)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Bilangan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 28)
        Me.ComboBox1.TabIndex = 4
        '
        'bilangan
        '
        Me.bilangan.FormattingEnabled = True
        Me.bilangan.ItemHeight = 20
        Me.bilangan.Location = New System.Drawing.Point(438, 122)
        Me.bilangan.Name = "bilangan"
        Me.bilangan.Size = New System.Drawing.Size(214, 224)
        Me.bilangan.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hasil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(681, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bilangan 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(681, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bilangan 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(681, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hasil"
        '
        'txtbilsatu
        '
        Me.txtbilsatu.Location = New System.Drawing.Point(791, 122)
        Me.txtbilsatu.Name = "txtbilsatu"
        Me.txtbilsatu.Size = New System.Drawing.Size(159, 26)
        Me.txtbilsatu.TabIndex = 9
        '
        'txtbildua
        '
        Me.txtbildua.Location = New System.Drawing.Point(791, 172)
        Me.txtbildua.Name = "txtbildua"
        Me.txtbildua.Size = New System.Drawing.Size(159, 26)
        Me.txtbildua.TabIndex = 10
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(791, 228)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(159, 26)
        Me.txthasil.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(719, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Perhitungan"
        '
        'FormFungsi2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 545)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.txtbildua)
        Me.Controls.Add(Me.txtbilsatu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bilangan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btneqit)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormFungsi2"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btneqit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bilangan As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbilsatu As System.Windows.Forms.TextBox
    Friend WithEvents txtbildua As System.Windows.Forms.TextBox
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
